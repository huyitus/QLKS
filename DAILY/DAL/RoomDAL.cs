using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using QLKS.BAL;
using System;

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

        public static string CreateQuery(bool isEmpty, bool isClean)
        {
            string cond1 = isEmpty ? "TINHTRANG = 0" : "1 = 1";
            string cond2 = isClean ? "TTDONDEP = 'Da don'" : "1 = 1";
            return string.Format("SELECT * FROM QLKS.PHONG WHERE {0} AND {1}", cond1, cond2);
        }

        public static List<RoomDAL> GetRooms(bool isEmpty, bool isClean)
        {
            string username = SessionBAL.sUsername;
            string password = SessionBAL.sPassword;

            string query = CreateQuery(isEmpty, isClean);

            using (OracleConnection connection = SessionBAL.CreateConnection(username, password))
            {
                try
                {
                    connection.Open();

                    List<RoomDAL> rooms = new List<RoomDAL>();

                    var command = new OracleCommand(query, connection);
                    var reader = command.ExecuteReader();

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
    }
}
