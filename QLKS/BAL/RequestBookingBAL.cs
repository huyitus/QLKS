using QLKS.DAL;

namespace QLKS.BAL
{
    class RequestBookingBAL
    {
        public static bool SendRequest(string customerId, string roomId)
        {
            RequestBookingDAL request = new RequestBookingDAL(null, customerId, roomId);
            return RequestBookingDAL.Insert(request);
        }
    }
}
