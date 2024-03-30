using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WtcsDao
{
    public class StoreHelper
    {
        public static SqlConnection con;

        public static string sql = "select * from StoreInfos";

        public static string deleteSql = "delete from StoreInfos where ";
        /// <summary>
        /// 创建连接对象
        /// </summary>
        /// <returns></returns>
        public static SqlConnection Con()
        {
            con = new SqlConnection("server=.;uid=sa;pwd=123;database=WTCDatabase");

            con.Open();

            return con;
        }


        /// <summary>
        /// 查询语句
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetSql(string text)
        {
            sql += $" where (StoreName like '%{text}%' or StoreNumber like '%{text}%')"; 
            return sql;
        }

        //删除sql语句
        public static string DeleteSql(Int32 text)
        {
            deleteSql += $"StoreId = {text}";
            
            return deleteSql;
        }

        //批量删除sql语句
        public static string DeleteSql(List<int> text,int count)
        {
            int first = text[0];
            int last = text.Last();
            deleteSql += "StoreId in ";
            foreach (var item in text)
            {
                if (item == first)
                {
                    deleteSql += $"({item},";
                }else if (item == last)
                {
                    deleteSql += $"{item})";
                    break;
                }
                else
                {
                    deleteSql += $"{item},";
                }
                
                
            }
           Debug.WriteLine(deleteSql);
            return deleteSql;
        }
    }
}
