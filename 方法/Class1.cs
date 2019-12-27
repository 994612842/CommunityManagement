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
    /// <summary>
    /// 公用字段，包括sql数据库信息，是否第一次运行
    /// </summary>
    public class PublicString
    {
        /// <summary>
        /// 析构函数
        /// </summary>
         ~PublicString()
        {
        }
        /// <summary>
        /// 直接调用的数据库连接字段,包括服务器,连接的数据库,登陆信息等
        /// </summary>
        public static string Sqlconn
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            }
        }

        /// <summary>
        /// 是否第一次运行此程序
        /// </summary>
        public bool isFirstRun
        {
            get {
                return bool.Parse(ConfigurationManager.AppSettings["IsFirstRun"].Trim());
            }
            set
            {
                Configuration first = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                first.AppSettings.Settings["IsFirstRun"].Value = value.ToString();
                first.Save();
                ConfigurationManager.RefreshSection("appsettings");
                //ConfigurationManager.AppSettings["IsFirstRun"] = value.ToString();
            }
        }
    }

    /// <summary>
    /// 对配置文件进行读或写操作
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 判断是否为第一次运行
        /// </summary>
        /// <param name="publicString"></param>
        /// <returns></returns>
        public bool Read(PublicString publicString)
        {
            if (publicString.isFirstRun == true)
                return true;
            else
                return false;

            //读：
            //string s = ConfigurationManager.AppSettings["y"];
            // 加：
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //AppSettingsSection app = config.AppSettings;
            //app.Settings.Add("x", "this is X");
            //config.Save(ConfigurationSaveMode.Modified);
            //修改：
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //AppSettingsSection app = config.AppSettings;
            //app.Settings.Add("x", "this is X");
            //app.Settings["x"].Value = "this is not Y"; 
            //config.Save(ConfigurationSaveMode.Modified);
            // 删除：
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //AppSettingsSection app = config.AppSettings;
            //app.Settings.Remove("x");
            //config.Save(ConfigurationSaveMode.Modified);

            //将用户的输入的配置更新保存到App.config

            //Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //cfa.AppSettings.Settings["first_run"].Value = "False";
            //cfa.AppSettings.Settings["server"].Value = server;
            //cfa.AppSettings.Settings["database"].Value = database;
            //cfa.AppSettings.Settings["uid"].Value = uid;
            //cfa.AppSettings.Settings["pwd"].Value = pwd;
            //cfa.Save();
            //ConfigurationManager.RefreshSection("appSettings");
        }
        /// <summary>
        /// 使用SQL server 身份验证登录到服务器
        /// </summary>
        /// <param name="DS">服务器</param>
        /// <param name="DB">数据库</param>
        /// <param name="UD">用户名</param>
        /// <param name="PSD">密码</param>
        public void Write(string DS,string DB,string UD,string PSD,PublicString publicString)
        {
            Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            cfg.ConnectionStrings.ConnectionStrings["connectionString"].ConnectionString = 
                $"Data Source={DS};" +
                $"Initial Catalog={DB};" +
                "Persist Security Info=True;" +
                $"User ID={UD};" +
                $"Password={PSD}";

            cfg.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            publicString.isFirstRun = false;
        }
        /// <summary>
        /// 使用Windows身份验证登录到服务器
        /// </summary>
        /// <param name="DS">"Data Source"要登录的服务器 </param>
        /// <param name="DB">"Initial Catalog"要连接的数据库</param>
        public void Write(string DS, string DB,PublicString publicString)
        {
            Configuration cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            cfg.ConnectionStrings.ConnectionStrings["connectionString"].ConnectionString =
                $"Data Source={DS};" +
                $"Initial Catalog={DB};" +
                "Integrated Security = True;";

            cfg.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            publicString.isFirstRun = false;
        }
    }
    /// <summary>
    /// 判断用户类型
    /// </summary>
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
