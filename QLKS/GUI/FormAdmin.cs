using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormAdmin : Form
    {
        private readonly FormLogin loginForm;

        public FormAdmin(FormLogin parent1)
        {
            InitializeComponent();
            this.loginForm = parent1;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            loginForm.Hide();
        }
        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionBAL.Finish();
            loginForm.ClearInput();
            loginForm.Show();
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttQLNV_Click(object sender, EventArgs e)
        {
            FormAdmin_NV f = new FormAdmin_NV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {
            SessionBAL.Finish();
            loginForm.ClearInput();
            this.Hide();
            loginForm.Show();
        }

        private void buttTTKH_Click(object sender, EventArgs e)
        {
            FormAdmin_KH f1 = new FormAdmin_KH();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void buttDT_Click(object sender, EventArgs e)
        {
            FormAdmin_DT f2 = new FormAdmin_DT();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void buttTour_Click(object sender, EventArgs e)
        {
            FormAdmin_Tour f3 = new FormAdmin_Tour();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void buttHD_Click(object sender, EventArgs e)
        {
            FormAdmin_HD f4 = new FormAdmin_HD();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void buttQD_Click(object sender, EventArgs e)
        {
            FormAdmin_QD f5 = new FormAdmin_QD();
            this.Hide();
            f5.ShowDialog();
            this.Show();
        }

        private void buttDV_Click(object sender, EventArgs e)
        {
            FormAdmin_DV f6 = new FormAdmin_DV();
            this.Hide();
            f6.ShowDialog();
            this.Show();
        }
    }
}
