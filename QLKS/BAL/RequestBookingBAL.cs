using QLKS.DAL;

namespace QLKS.BAL
{
    class RequestBookingBAL
    {
        public static bool SendRequest(string phoneNumber, string typeName, string amount)
        {
            return RequestBookingDAL.Insert(phoneNumber, typeName, amount);
        }
    }
}
