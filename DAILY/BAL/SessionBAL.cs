using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;

namespace QLKS.BAL
{
    class SessionBAL
    {
        public static string sUsername;
        public static string sPassword;

        public static void Write(string username, string password)
        {
            sUsername = username;
            sPassword = password;
        }

        public static OracleConnection CreateConnection(string username, string password)
        {
            string connectionString = string.Format(
                ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString,
                username,
                password);

            return new OracleConnection(connectionString);
        }

        public static bool IsLoginSuccess(string username, string password)
        {
            using (OracleConnection connection = SessionBAL.CreateConnection(username, password))
            {
                try
                {
                    connection.Open();
                    return IsAgencyUsername(username);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static bool IsAgencyUsername(string username)
        {
            return username.Substring(0, 5) == "DAILY";
        }
    }
}
