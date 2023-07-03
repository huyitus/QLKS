using QLKS.BAL;

using System;

using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

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

        public static List<RequestBookingDAL> GetAll()
        {
            string query = "SELECT * FROM QLKS.YEUCAUDP";

            List<RequestBookingDAL> requests = new List<RequestBookingDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var id = reader.GetString(0);
                    var phoneNumber = reader.GetString(1);
                    var typeName = reader.GetString(2);
                    var amount = reader.GetString(3);
                    var date = reader.GetString(4);

                    RequestBookingDAL request = new RequestBookingDAL(id, phoneNumber, typeName, amount, date);
                    requests.Add(request);
                }
            }

            return requests;
        }

        public static bool Delete(string id)
        {
            string query = "DELETE FROM QLKS.YEUCAUDP WHERE MAYC='" + id + "'";
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
