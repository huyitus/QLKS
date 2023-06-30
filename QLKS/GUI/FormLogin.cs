using QLKS.BAL;

using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormLogin : Form
    {
        private const string LOGIN_FAILED_MESSAGE = "Đăng nhập thất bại!";
        private const string MESSAGE_CAPTION = "Thông báo";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, System.EventArgs e)
        {
            string username = txtUsername.Text.ToUpper();
            string password = txtPassword.Text;

            if (SessionBAL.Begin(username, password))
            {
                OpenFormFor(username);
            }
            else
            {
                MessageBox.Show(LOGIN_FAILED_MESSAGE, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenFormFor(string username)
        {
            if (SessionBAL.IsAgencyUsername(username))
            {
                Form form = new FormAgency(this);
                form.Show();
            }
        }

        public void ClearInput()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
