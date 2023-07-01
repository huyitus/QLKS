using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class RoomDAL
    {
        public string ID { get; set; }
        public string TypeName { get; set; }
        public int Status { get; set; }
        public string Cleaning { get; set; }

        public RoomDAL(string id, string typeName, string status, string cleaning)
        {
            ID = id;
            TypeName = typeName;
            Status = int.Parse(status);
            Cleaning = cleaning;
        }

        public static List<RoomDAL> GetAll(bool isEmpty, bool isClean)
        {
            string cond1 = isEmpty ? "TINHTRANG = 0" : "1 = 1";
            string cond2 = isClean ? "TTDONDEP = 'Da don'" : "1 = 1";
            string query = string.Format("SELECT * FROM QLKS.PHONG WHERE {0} AND {1}", cond1, cond2);

            List<RoomDAL> rooms = new List<RoomDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var id = reader.GetString(0);
                    var typeName = reader.GetString(1);
                    var status = reader.GetString(2);
                    var cleaning = reader.GetString(3);

                    var room = new RoomDAL(id, typeName, status, cleaning);
                    rooms.Add(room);
                }
            }

            return rooms;
        }

        public static RoomDAL GetByID(string roomId)
        {
            string query = string.Format("SELECT * FROM QLKS.PHONG WHERE MAPHONG = '{0}'", roomId);

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var id = reader.GetString(0);
                    var typeName = reader.GetString(1);
                    var status = reader.GetString(2);
                    var cleaning = reader.GetString(3);

                    return new RoomDAL(id, typeName, status, cleaning);
                }
            }

            return null;
        }
    }
}
