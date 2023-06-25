using System.Windows.Forms;
using QLKS.BAL;

namespace QLKS.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            string username = txtUsername.Text.ToUpper();
            string password = txtPassword.Text;

            if (!SessionBAL.IsLoginSuccess(username, password))
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                SessionBAL.Write(username, password);

                Form form = new FormFeatures(this);
                form.Show();

                this.Hide();
            }
        }
    }
}
