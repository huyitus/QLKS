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
            SessionBAL.getUserRole = SessionBAL.GetRole(username);
            if (SessionBAL.IsAgencyUsername(username))
            {
                Form agencyForm = new FormAgency(this);
                agencyForm.Show();
            }
            else if (SessionBAL.IsReceptionistUsername(username))
            {
                Form receptionistForm = new FormReceptionist(this);
                this.Hide();
                receptionistForm.ShowDialog();
            }
            else if (SessionBAL.IsAdminUsername(username))
            {
                Form form = new FormAdmin(this);
                form.Show();
            }    
        }

        public void ClearInput()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void FormLogin_VisibleChanged(object sender, System.EventArgs e)
        {
            ClearInput();
        }
    }
}