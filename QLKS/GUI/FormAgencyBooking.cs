using QLKS.BAL;
using QLKS.DAL;

using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormAgencyBooking : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CUSTOMER_NO_EXIST = "Khách hàng không tồn tại, hãy thêm mới ở bước tiếp theo.";
        private const string MESSAGE_CONFIRM = "Xác nhận gửi yêu cầu đặt phòng?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Gửi yêu cầu thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Gửi yêu cầu thất bại!";

        private readonly FormAgency agencyFrom;
        private readonly string roomId;

        public FormAgencyBooking(FormAgency parent, string roomId)
        {
            InitializeComponent();
            this.agencyFrom = parent;
            this.roomId = roomId;
        }

        private void FormAgencyBooking_Load(object sender, System.EventArgs e)
        {
            agencyFrom.Hide();
            txtRoomID.Text = roomId;
        }

        private void FormAgencyBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            agencyFrom.Show();
        }

        private void ButtonBooking_Click(object sender, System.EventArgs e)
        {
            string phoneNumber = txtPhone.Text;
            string customerId = CustomerBAL.GetIdByPhoneNumber(phoneNumber);

            if (customerId == null)
            {
                MessageBox.Show(MESSAGE_CUSTOMER_NO_EXIST, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form addCustomerForm = new FormAddCustomer();
                addCustomerForm.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (RequestBookingBAL.SendRequest(customerId, roomId))
                    {
                        MessageBox.Show(MESSAGE_SEND_REQUEST_SUCCESS, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(MESSAGE_SEND_REQUEST_FAILED, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
