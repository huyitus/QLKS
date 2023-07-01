using QLKS.DAL;

namespace QLKS.BAL
{
    class CustomerBAL
    {
        public static string GetIdByPhoneNumber(string number)
        {
            CustomerDAL customer = CustomerDAL.GetByPhoneNumber(number);
            return customer == null ? null : customer.ID;
        }
    }
}
