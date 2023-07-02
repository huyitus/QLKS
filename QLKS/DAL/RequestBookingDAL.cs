using QLKS.BAL;

using System;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class RequestBookingDAL
    {
        public string ID { get; set; }
        public string PhoneNumber { get; set; }
        public string TypeName { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }

        public RequestBookingDAL(string id, string phoneNumber, string typeName, string amount, string date)
        {
            ID = id;
            PhoneNumber = phoneNumber;
            TypeName = typeName;
            Amount = amount == null ? 0 : int.Parse(amount);
            Date = date;
        }

        public static bool Insert(string phoneNumber, string typeName, string amount)
        {
            string query = string.Format("INSERT INTO QLKS.YEUCAUDP(SDT, TENLOAIPHONG, SOLUONG) VALUES('{0}', '{1}', {2})", phoneNumber, typeName, amount);
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
