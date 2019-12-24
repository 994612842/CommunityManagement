using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMMethod
{
    public enum useridentity
    {
        administrators,
        user
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
