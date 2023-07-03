using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace QLKS.DAL
{
    class DvDAL
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public int Gia { get; set; }
        public DvDAL(string madv, string name, int gia) 
        {
            MaDV = madv;    
            TenDV = name;  
            Gia = gia;
        }
        public static List<DvDAL> GetDV()
        {
            string query = "SELECT * FROM QLKS.DICHVU";

            List<DvDAL> dvs = new List<DvDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var madv = reader.GetString(0);
                    var name = reader.GetString(1);
                    var gia = reader.GetInt32(2);

                    var dv = new DvDAL(madv, name, gia);
                    dvs.Add(dv);
                }
            }

            return dvs;
        }
        public static bool Insert(string name, string gia)
        {
            string query = string.Format("INSERT INTO QLKS.DICHVU VALUES(' ','{0}', '{1}')", name, gia);
            using (var command = new OracleCommand(query, SessionBAL.sConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static bool Del(string madv)
        {
            string query = string.Format("DELETE FROM QLKS.DICHVU WHERE MADV='{0}'", madv);
            using (var command = new OracleCommand(query, SessionBAL.sConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
