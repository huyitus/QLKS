using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class CusDAL
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public CusDAL(string makh, string name, string sdt, string dc)
        { 
            MaKH = makh;
            TenKH = name;
            SDT = sdt;
            DiaChi = dc;
        }

        public static List<CusDAL> GetCus()
        {
            string query = "SELECT * FROM QLKS.KHACHHANG";

            List<CusDAL> cuss = new List<CusDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var makh = reader.GetString(0);
                    var name = reader.GetString(1);
                    var sdt = reader.GetString(2);
                    var dc = reader.GetString(3);

                    var cus = new CusDAL(makh, name, sdt, dc);
                    cuss.Add(cus);
                }
            }

            return cuss;
        }

    }
}
