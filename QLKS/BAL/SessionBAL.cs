using System;
using System.Configuration;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.BAL
{
    class SessionBAL
    {
        public static OracleConnection sConnection;

        public static String getUserRole = "";

        public static bool Begin(string username, string password)
        {
            string connectionString = string.Format(ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString,
                username,
                password);

            sConnection = new OracleConnection(connectionString);

            try
            {
                sConnection.Open();
                return true;
            }
            catch (Exception)
            {
                sConnection = null;
            }

            return false;
        }

        public static void Finish()
        {
            try
            {
                sConnection.Close();
                sConnection.Dispose();
            }
            catch (Exception)
            {
                sConnection = null;
            }
        }

        public static bool IsAgencyUsername(string username)
        {
            try
            {
                return username.Substring(0, 5) == "DAILY";
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public static bool IsReceptionistUsername(string username)
        {
            try
            {
                return username.Substring(0, 5) == "LETAN";
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsAdminUsername(string username)
        {
            return username == "QLKS";
        }

        public static string GetRole(string username)
        {
            if (IsReceptionistUsername(username))
            {
                return "LETAN";
            }
            else
            {
                if (IsAgencyUsername(username))
                {
                    return "DAILY";
                }
                else
                {
                    if (IsAdminUsername(username))
                    {
                        return "QLKS";
                    }
                }
            }
            return "ANONYMOUS";
        }
    }
}