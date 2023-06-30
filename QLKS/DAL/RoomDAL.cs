using QLKS.BAL;

using System;
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

        public RoomDAL(string id, string typeName, int status, string cleaning)
        {
            ID = id;
            TypeName = typeName;
            Status = status;
            Cleaning = cleaning;
        }

        public static List<RoomDAL> GetRooms()
        {
            string query = "SELECT * FROM QLKS.PHONG";

            using (OracleConnection connection = SessionBAL.sConnection)
            {
                try
                {
                    connection.Open();

                    var command = new OracleCommand(query, connection);
                    var reader = command.ExecuteReader();

                    List<RoomDAL> rooms = new List<RoomDAL>();

                    while (reader.Read())
                    {
                        var id = reader.GetString(0);
                        var typeName = reader.GetString(1);
                        var status = reader.GetInt32(2);
                        var cleaning = reader.GetString(3);

                        var room = new RoomDAL(id, typeName, status, cleaning);
                        rooms.Add(room);
                    }

                    reader.Close();

                    return rooms;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static List<RoomDAL> GetRooms(bool isEmpty, bool isClean)
        {
            string cond1 = isEmpty ? "TINHTRANG = 0" : "1 = 1";
            string cond2 = isClean ? "TTDONDEP = 'Da don'" : "1 = 1";
            string query = "SELECT * FROM QLKS.PHONG WHERE " + cond1 + " AND " + cond2;

            List<RoomDAL> rooms = new List<RoomDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var id = reader.GetString(0);
                    var typeName = reader.GetString(1);
                    var status = reader.GetInt32(2);
                    var cleaning = reader.GetString(3);

                    var room = new RoomDAL(id, typeName, status, cleaning);
                    rooms.Add(room);
                }
            }

            return rooms;
        }
    }
}
