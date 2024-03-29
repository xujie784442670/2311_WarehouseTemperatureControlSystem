using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;

namespace AcmsDao
{
    public class SqliteHelper
    {
        public static bool IsDebug { get; set; } = false;
        public static bool IsPrintSql { get; set; } = false;
        public static bool IsPrintResult { get; set; } = false;
        public static string ConnectionString { get; private set; }

        public static bool IsInit => !string.IsNullOrWhiteSpace(ConnectionString);
        public static void Println(string guid,string sql,params SQLiteParameter[] parameters)
        {
            if(!IsDebug) return;
            if(!IsPrintSql) return;
            Debug.WriteLine($"[{guid}] ==> Sql       : {sql}");
            Debug.WriteLine($"[{guid}] ==> Parameters: {string.Join(",", parameters.Select(p => p.Value))}");
        }

        public static void Println(string guid, int rows)
        {
            if (!IsDebug) return;
            if (!IsPrintResult) return;
            Debug.WriteLine($"[{guid}] <== Rows: {rows}");
        }

        public static void Println(string guid, DataTable dt)
        {
            if (!IsDebug) return;
            if (!IsPrintResult) return;
            // 打印列名
            Debug.WriteLine($"[{guid}] <== Columns: {string.Join("\t", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName))}");
            // 打印数据
            foreach (DataRow row in dt.Rows)
            {
                Debug.WriteLine($"[{guid}] <== Row: {string.Join("\t", row.ItemArray)}");
            }
            Debug.WriteLine($"[{guid}] <== Rows: {dt.Rows.Count}");
        }

        /// <summary>
        /// 初始化帮助类
        /// </summary>
        /// <param name="dbPath">数据库文件路径</param>
        /// <param name="pwd">数据库密码(可选)</param>
        public static void Init(string dbPath, string? pwd = "")
        {
            var builder = new SQLiteConnectionStringBuilder
            {
                DataSource = dbPath
            };
            if (!string.IsNullOrEmpty(pwd))
            {
                builder.Password = pwd;
            }

            ConnectionString = builder.ToString();
        }

        private static void CheckInit()
        {
            if (!IsInit)
            {
                throw new System.Exception("未初始化数据库连接,请调用SQLiteHelper.Init方法进行初始化");
            }
        }

        private static SQLiteConnection GetConnection()
        {
            CheckInit();
            var connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        private static SQLiteCommand CreateCommand(string sql, params SQLiteParameter[] parameters)
        {
            var cmd = GetConnection().CreateCommand();
            cmd.CommandText = sql;
            if (parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            return cmd;
        }

        // sql的执行
        // 结果的处理

        public static T? QueryOne<T>(string sql, Func<DataRow, string[], T> resultHandler,
            params SQLiteParameter[] parameters)
        {
            var result = Query(sql, resultHandler, parameters);
            if(result.Count>1) throw new Exception("查询结果不唯一");
            return result.Count == 0 ? default : result[0];
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <typeparam name="T">返回结果的实体类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="handler">结果处理器接口实现</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static List<T> Query<T>(string sql,
            IResultHandler<T> handler,
            params SQLiteParameter[] parameters)
        {
            return Query(sql, handler.HandleResult, parameters);
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <typeparam name="T">返回结果的实体类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="resultHandler">结果处理器</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static List<T> Query<T>(string sql, Func<DataRow, string[], T> resultHandler,
            params SQLiteParameter[] parameters)
        {
            using var cmd = CreateCommand(sql, parameters);
            var guid = Guid.NewGuid().ToString();
            // 打印sql
            Println(guid,cmd.CommandText, parameters);
            // 执行sql语句
            using var reader = cmd.ExecuteReader();
            // 将结果转换为DataTable
            var dt = new DataTable();
            dt.Load(reader);
            // 打印结果
            Println(guid, dt);
            // 获取列名
            var columnNames = new string[dt.Columns.Count];
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                columnNames[i] = dt.Columns[i].ColumnName;
            }
            // 结果处理
            var result = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                result.Add(resultHandler(row, columnNames));
            }
            return result;
        }

        public static T QueryScalar<T>(string sql, params SQLiteParameter[] parameters)
        {
            using var cmd = CreateCommand(sql, parameters);
            var guid = Guid.NewGuid().ToString();
            // 打印sql
            Println(guid, cmd.CommandText, parameters);
            // 执行sql语句
            var result = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(result);
            // 打印结果
            Println(guid, dt);
            var value = dt.Rows[0][0];
            return dt.Rows.Count > 0 ? (T)value : default;
        }

        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] parameters)
        {
            using var cmd = CreateCommand(sql, parameters);
            var guid = Guid.NewGuid().ToString();
            // 打印sql
            Println(guid, cmd.CommandText, parameters);
            var rows = cmd.ExecuteNonQuery();
            Println(guid,rows);
            return rows;
        }




        public static long GetLastInsertRowId(string tableName)
        {
            return QueryScalar<long>($"select seq from sqlite_sequence where name='{tableName}'");
        }
    }

    public interface IResultHandler<T>
    {
        T HandleResult(DataRow row, string[] columnNames);
    }
}