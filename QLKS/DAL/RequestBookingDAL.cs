using QLKS.BAL;

using System;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class RequestBookingDAL
    {
        public string ID { get; set; }
        public string CustomerID { get; set; }
        public string TypeName { get; set; }
        public int Amount { get; set; }

        public RequestBookingDAL(string id, string customerId, string typeName, string amount)
        {
            ID = id;
            CustomerID = customerId;
            TypeName = typeName;
            Amount = amount == null ? 0 : int.Parse(amount);
        }

        public static bool Insert(RequestBookingDAL request)
        {
            string query = string.Format("INSERT INTO QLKS.YEUCAUDP(MAKH, TENLOAIPHONG, SOLUONG) VALUES('{0}', '{1}', {2})", request.CustomerID, request.TypeName, request.Amount);
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
