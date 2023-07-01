using QLKS.BAL;

using System;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class RequestBookingDAL
    {
        public string ID { get; set; }
        public string CustomerID { get; set; }
        public string RoomID { get; set; }

        public RequestBookingDAL(string id, string customerId, string roomId)
        {
            ID = id;
            CustomerID = customerId;
            RoomID = roomId;
        }

        public static bool Insert(RequestBookingDAL request)
        {
            string query = string.Format("INSERT INTO QLKS.YEUCAUDP (MAKH, MAPHONG) VALUES ('{0}', '{1}')", request.CustomerID, request.RoomID);
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
