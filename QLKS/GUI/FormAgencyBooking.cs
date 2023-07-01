using QLKS.BAL;

using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormAgencyBooking : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Xác nhận gửi yêu cầu đặt phòng?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Gửi yêu cầu thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Gửi yêu cầu thất bại!";

        private readonly Form parent;
        private readonly string typeName;

        public FormAgencyBooking(FormAgency parent, string typeName)
        {
            InitializeComponent();
            this.parent = parent;
            this.typeName = typeName;
        }

        private void FormAgencyBooking_Load(object sender, System.EventArgs e)
        {
            parent.Hide();
            txtTypeName.Text = typeName;
        }

        private void FormAgencyBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void ButtonBooking_Click(object sender, System.EventArgs e)
        {
            string phoneNumber = txtPhone.Text;
            string amount = txtAmount.Text;

            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                if (RequestBookingBAL.SendRequest(phoneNumber, typeName, amount))
                {
                    MessageBox.Show(MESSAGE_SEND_REQUEST_SUCCESS, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(MESSAGE_SEND_REQUEST_FAILED, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
