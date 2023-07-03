using QLKS.DAL;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class RequestBookingBAL
    {
        public static bool SendRequest(string phoneNumber, string typeName, string amount)
        {
            return RequestBookingDAL.Insert(phoneNumber, typeName, amount);
        }

        public static void LoadInto(DataGridView dgvRequests)
        {
            List<RequestBookingDAL> requests = RequestBookingDAL.GetAll();
            dgvRequests.DataSource = requests;
        }

        public static bool Delete(string id)
        {
            return RequestBookingDAL.Delete(id);
        }
    }
}
