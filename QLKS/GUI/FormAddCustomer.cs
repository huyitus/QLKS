using QLKS.BAL;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLKS.GUI
{
    public partial class FormAddCustomer : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Xác nhận thêm khách hàng?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Thêm thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Thêm thất bại!";

        private readonly Form parent;
        public FormAddCustomer(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormAddCustomer_Form_Closed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string name = txtName.Text;
            string sdt = txtPhone.Text;
            string dc = txtAddress.Text;
            string email = txtEmail.Text;
            string fax = txtFax.Text;
            string group = txtGroup.Text;
            string amount = txtAmount.Text;

            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (CusBAL.SendRequestAddCus(name, sdt, dc, email, fax, group, amount))
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
