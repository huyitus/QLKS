using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class PnDAL
    {
        public string MaDT { get; set; }
        public string TenDT { get; set; }
        public string MaTour { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public PnDAL(string madt, string name, string mt, string dc, string sdt, string mail)
        {
            MaDT = madt;
            TenDT = name;
            MaTour = mt;
            DiaChi = dc;
            SDT = sdt;
            Email = mail;
        }
        public static List<PnDAL> GetPartner()
        {
            string query = "SELECT * FROM QLKS.DOITAC ";

            List<PnDAL> partners = new List<PnDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var madt = reader.GetString(0);
                    var name = reader.GetString(1);
                    var mt = reader.GetString(2);
                    var dc = reader.GetString(3);
                    var sdt = reader.GetString(4);
                    var mail = reader.GetString(5);

                    var partner = new PnDAL(madt, name, mt, dc, sdt, mail);
                    partners.Add(partner);
                }
            }

            return partners;
        }

    }
}
