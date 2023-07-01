using QLKS.DAL;

namespace QLKS.BAL
{
    class RequestBookingBAL
    {
        public static bool SendRequest(string customerId, string typeName, string amount)
        {
            RequestBookingDAL request = new RequestBookingDAL(null, customerId, typeName, amount);
            return RequestBookingDAL.Insert(request);
        }
    }
}
