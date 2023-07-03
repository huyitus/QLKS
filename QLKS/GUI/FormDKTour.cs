using QLKS.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormDKTour : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Bạn có chắc chắn muốn xóa dòng đăng ký này?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Xóa thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Xóa thất bại!";
        public FormDKTour()
        {
            InitializeComponent();
        }
        private void FormDKTour_Load(object sender, EventArgs e)
        {
            DKTourBAL.LoadDKTourInto(dtg_DKTour);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddDKTour adddktour = new FormAddDKTour();
            this.Hide();
            adddktour.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DKTourBAL.LoadDKTourInto(dtg_DKTour);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string madktour = dtg_DKTour.CurrentRow.Cells["MaDKTour"].Value.ToString();
            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DKTourBAL.SendRequestDelDKTour(madktour))
                {
                    MessageBox.Show(MESSAGE_SEND_REQUEST_SUCCESS, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                }
                else
                {
                    MessageBox.Show(MESSAGE_SEND_REQUEST_FAILED, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dtg_DKTour.CurrentRow.Cells["MaDKTour"].Value.ToString();
            if (id != null)
            {
                Form form = new FormEditDKTour(this, id);
                form.Show();
            }
        }
    }
}
