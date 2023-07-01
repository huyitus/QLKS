using QLKS.BAL;

using System;
using System.Data;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

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

        public static bool IsEmptyRoom(string roomId)
        {
            bool isEmpty = false;

            using (var command = SessionBAL.sConnection.CreateCommand())
            {
                command.CommandText = "BEGIN :result := QLKS.check_room_status(:roomId); END;";
                command.Parameters.Add("result", OracleDbType.Boolean, ParameterDirection.ReturnValue);
                command.Parameters.Add("roomId", OracleDbType.NVarchar2).Value = roomId;

                command.ExecuteNonQuery();

                OracleBoolean result = (OracleBoolean)command.Parameters["result"].Value;
                isEmpty = result.Value;
            }

            return isEmpty;
        }
    }
}
