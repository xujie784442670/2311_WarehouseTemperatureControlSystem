using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WtcsDao;

namespace WtcsService
{
    public class StoreService
    {
        public static DataSet ds;
        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet SelectAll()
        {
            string sql = StoreHelper.sql;
            SqlConnection con = StoreHelper.Con();
            SqlDataAdapter data = new SqlDataAdapter(sql, con);

            //创建缓存区
            ds = new DataSet();

            //把数据放入缓存区
            data.Fill(ds);

            return ds;
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DataSet SelectLike(string text)
        {
            StoreHelper.GetSql(text);
            string sql = StoreHelper.sql;
            SqlConnection con = StoreHelper.Con();
            SqlDataAdapter data = new SqlDataAdapter(sql, con);

            //创建缓存区
            ds = new DataSet();

            //把数据放入缓存区
            data.Fill(ds);

            return ds;
        }

        /// <summary>
        /// 单个删除
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int DeleteOne(Int32 text)
        {
            string sql = StoreHelper.DeleteSql(text);
            SqlConnection con = StoreHelper.Con();
            SqlCommand com = new SqlCommand(sql, con);

            int v = com.ExecuteNonQuery();
            return v;
        }


        public static int Delete(List<int> text, int count)
        {
            string sql = StoreHelper.DeleteSql(text,count);
            SqlConnection con = StoreHelper.Con();
            SqlCommand com = new SqlCommand(sql, con);

            int v = com.ExecuteNonQuery();
            return v;
        }
    }
}
