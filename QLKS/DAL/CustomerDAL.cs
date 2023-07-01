using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class CustomerDAL
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Group { get; set; }
        public int Amount { get; set; }

        public CustomerDAL(string id, string name, string phone, string address, string email, string fax, string group, string amount)
        {
            ID = id;
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
            Fax = fax;
            Group = group;
            Amount = amount == null ? 0 : int.Parse(amount);
        }

        public static CustomerDAL GetByPhoneNumber(string number)
        {
            string query = string.Format("SELECT * FROM QLKS.KHACHHANG WHERE SDT = '{0}'", number);

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                if (reader != null && reader.Read())
                {
                    var id = reader.GetString(0);
                    var name = reader.GetString(1);
                    var phone = reader.GetString(2);
                    var address = reader.GetString(3);
                    var email = reader.GetString(4);
                    var fax = reader.IsDBNull(5) ? null : reader.GetString(5);
                    var group = reader.IsDBNull(6) ? null : reader.GetString(6);
                    var amount = reader.IsDBNull(7) ? null : reader.GetString(7);

                    return new CustomerDAL(id, name, phone, address, email, fax, group, amount);
                }
            }

            return null;
        }
    }
}
