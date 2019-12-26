using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CommunityManagement
{
    public enum useridentity
    {
        administrators,
        user
    }

    public class PublicString
    {
        /// <summary>
        /// 析构函数
        /// </summary>
         ~PublicString()
        {
        }
        /// <summary>
        /// 数据库连接字段,包括服务器,连接的数据库,登陆信息等
        /// </summary>
        public static string Sqlconn
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            }
        }

    }
    public class userSwitch
    {
        public static string Getidentity(string e)
        {
            switch(e)
            {
                case "0":              
                    return "管理员";
                case "1":
                    return "普通用户";
                default:
                    return "普通用户";
            }
        }
    }
}
