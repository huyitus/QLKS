using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class RoomAgencyDAL
    {
        public string TypeName { get; set; }
        public int Amount { get; set; }

        public RoomAgencyDAL(string typeName, string amount)
        {
            TypeName = typeName;
            Amount = amount == null ? 0 : int.Parse(amount);
        }

        public static List<RoomAgencyDAL> Get(bool isEmpty, bool isClean)
        {
            string cond1 = isEmpty ? "TINHTRANG = 0" : "1 = 1";
            string cond2 = isClean ? "TTDONDEP = 'Da don'" : "1 = 1";
            string query = string.Format("SELECT TENLOAIPHONG, COUNT(*) FROM QLKS.PHONG WHERE {0} AND {1} GROUP BY TENLOAIPHONG", cond1, cond2);

            List<RoomAgencyDAL> rooms = new List<RoomAgencyDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var typeName = reader.GetString(0);
                    var amount = reader.GetString(1);

                    RoomAgencyDAL room = new RoomAgencyDAL(typeName, amount);
                    rooms.Add(room);
                }
            }

            return rooms;
        }
    }
}
