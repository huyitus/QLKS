using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class NvDAL
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string ChucVu { get; set; }
        public NvDAL(string manv, string name, string sdt, string mail, string cv)
        {
            MaNV = manv;
            TenNV = name;
            DiaChi = diaChi;
            SDT = sdt;
            Email = mail;
            ChucVu = cv;
        }

        public static List<NvDAL> GetNV()
        {
            string query = "SELECT * FROM QLKS.NHANVIEN";

            List<NvDAL> nvv = new List<NvDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var manv = reader.GetString(0);
                    var name = reader.GetString(1);
                    var sdt = reader.GetString(2);
                    var mail = reader.GetString(3);
                    var cv = reader.GetString(4);

                    var nv = new NvDAL(manv, name, sdt, mail, cv);
                    nvv.Add(nv);
                }
            }

            return nvv;
        }
    }
}
