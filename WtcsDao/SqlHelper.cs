using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace AcmsDao;

public class SqlBuilder
{
    public string TableName { get; private set; }
    public List<SqlParam> SqlSets { get; private set; } = new();
    public List<SqlParam> SqlWheres { get; private set; } = new();
    public List<SqlParam> SqlInserts { get; private set; } = new();

    public SqlBuilder(string tableName)
    {
        TableName = tableName;
    }

    /// <summary>
    /// 添加sql参数
    /// </summary>
    /// <param name="sqlParams">SQL参数存储集合</param>
    /// <param name="condition">条件</param>
    /// <param name="type">SQL类型</param>
    /// <param name="columnName">列名</param>
    /// <param name="sql">条件sql</param>
    /// <param name="parameters">参数列表</param>
    /// <returns></returns>
    public SqlBuilder AddSqlParam(List<SqlParam> sqlParams, bool condition, SqlType? type, string columnName,
        string sql, params SQLiteParameter[] parameters)
    {
        if (condition)
        {
            sqlParams.Add(new SqlParam
            {
                ColumnName = columnName,
                Sql = sql,
                Parameters = new List<SQLiteParameter>(parameters),
                SqlType = type
            });
        }

        return this;
    }

    /// <summary>
    /// 添加set参数
    /// </summary>
    /// <param name="condition">条件</param>
    /// <param name="columnName">列名</param>
    /// <param name="value">值</param>
    /// <returns></returns>
    public SqlBuilder Set(bool condition, string columnName, object value)
    {
        return AddSqlParam(SqlSets, condition, null, columnName, $"{columnName} = @{columnName}",
            new SQLiteParameter($"@{columnName}", value));
    }

    /// <summary>
    /// 添加where参数
    /// </summary>
    /// <param name="condition">条件</param>
    /// <param name="type">条件类型</param>
    /// <param name="sql">sql</param>
    /// <param name="parameters">参数</param>
    /// <returns></returns>
    public SqlBuilder Where(bool condition, SqlType type, string sql, params SQLiteParameter[] parameters)
    {
        return AddSqlParam(SqlWheres, condition, type, "", sql, parameters);
    }

    /// <summary>
    /// 添加where参数,默认为And
    /// </summary>
    /// <param name="condition">条件</param>
    /// <param name="sql">sql</param>
    /// <param name="parameters">参数</param>
    /// <returns></returns>
    public SqlBuilder And(bool condition, string sql, params SQLiteParameter[] parameters)
    {
        return Where(condition, SqlType.And, sql, parameters);
    }

    /// <summary>
    /// 添加where参数,默认为Or
    /// </summary>
    /// <param name="condition">条件</param>
    /// <param name="sql">sql</param>
    /// <param name="parameters">参数</param>
    /// <returns></returns>
    public SqlBuilder Or(bool condition, string sql, params SQLiteParameter[] parameters)
    {
        return Where(condition, SqlType.Or, sql, parameters);
    }

    /// <summary>
    /// 添加insert参数
    /// </summary>
    /// <param name="condition">条件</param>
    /// <param name="columnName">列名</param>
    /// <param name="value">值</param>
    /// <returns></returns>
    public SqlBuilder Insert(bool condition, string columnName, object value)
    {
        return AddSqlParam(SqlInserts, condition, null, columnName, $"@{columnName}",
            new SQLiteParameter($"@{columnName}", value));
    }

    /// <summary>
    /// 构建查询
    /// </summary>
    /// <param name="sql">sql输出</param>
    /// <param name="parameters">参数输出</param>
    public void BuildQuery(out string sql, out List<SQLiteParameter> parameters)
    {
        var sqlTemplate = $"select * from {TableName} where 1=1";
        parameters = new();
        foreach (var sqlWhere in SqlWheres)
        {
            var type = sqlWhere.SqlType ?? SqlType.And;
            sqlTemplate += $" {type} {sqlWhere.Sql}";
            parameters.AddRange(sqlWhere.Parameters);
        }

        sql = sqlTemplate;
    }

    /// <summary>
    /// 构建更新
    /// </summary>
    /// <param name="sql">sql输出</param>
    /// <param name="parameters">参数输出</param>
    public void BuildUpdate(out string sql, out List<SQLiteParameter> parameters)
    {
        var sqlTemplate = $"update {TableName} set ";
        parameters = new();
        foreach (var sqlSet in SqlSets)
        {
            sqlTemplate += $"{sqlSet.Sql},";
            parameters.AddRange(sqlSet.Parameters);
        }

        sqlTemplate = sqlTemplate.TrimEnd(',');
        sqlTemplate += " where 1=1";
        foreach (var sqlWhere in SqlWheres)
        {
            var type = sqlWhere.SqlType ?? SqlType.And;
            sqlTemplate += $" {type} {sqlWhere.Sql}";
            parameters.AddRange(sqlWhere.Parameters);
        }

        sql = sqlTemplate;
    }

    /// <summary>
    /// 构建插入
    /// </summary>
    /// <param name="sql">sql输出</param>
    /// <param name="parameters">参数输出</param>
    public void BuildInsert(out string sql, out List<SQLiteParameter> parameters)
    {
        var sqlTemplate = $"insert into {TableName}";
        var columns = string.Join(",", SqlInserts.Select(x => x.ColumnName));
        var values = string.Join(",", SqlInserts.Select(x => x.Sql));
        sqlTemplate += $"({columns}) values({values})";
        parameters = new();
        foreach (var sqlInsert in SqlInserts)
        {
            parameters.AddRange(sqlInsert.Parameters);
        }

        sql = sqlTemplate;
    }

    /// <summary>
    /// 构建删除
    /// </summary>
    /// <param name="sql">sql输出</param>
    /// <param name="parameters">参数输出</param>
    public void BuildDelete(out string sql, out List<SQLiteParameter> parameters)
    {
        var sqlTemplate = $"delete from {TableName} where 1=1";
        parameters = new();
        foreach (var sqlWhere in SqlWheres)
        {
            var type = sqlWhere.SqlType ?? SqlType.And;
            sqlTemplate += $" {type} {sqlWhere.Sql}";
            parameters.AddRange(sqlWhere.Parameters);
        }

        sql = sqlTemplate;
    }
}

public class SqlParam
{
    public string ColumnName { get; set; }
    public string Sql { get; set; }
    public List<SQLiteParameter> Parameters { get; set; }
    public SqlType? SqlType { get; set; }
}

public enum SqlType
{
    And,
    Or
}