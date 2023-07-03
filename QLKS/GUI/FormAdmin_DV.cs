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
    public partial class FormAdmin_DV : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Bạn có chắc chắn muốn xóa dịch vụ này?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Xóa thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Xóa thất bại!";
        public FormAdmin_DV()
        {
            InitializeComponent();
            if (SessionBAL.getUserRole == "LETAN")
            {
                butt_Fix.Visible = false;
                butt_Del.Visible = false;
                butt_Add.Visible = false;
            }
        }

        private void lab_QD_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_DV_Load(object sender, EventArgs e)
        {
            DvBAL.LoadDVInto(dtg_DV);
        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            FormAdmin_AddDV f = new FormAdmin_AddDV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void butt_Del_Click(object sender, EventArgs e)
        {
            string madv = dtg_DV.CurrentRow.Cells["MaDV"].Value.ToString();
            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DvBAL.SendRequestDel(madv))
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

        private void butt_Fix_Click(object sender, EventArgs e)
        {
            string id = dtg_DV.CurrentRow.Cells["MaDV"].Value.ToString();
            if (id != null)
            {
                Form form = new FormAdminEditDV(this, id);
                form.Show();
            }
        }

        private void butt_Re_Click(object sender, EventArgs e)
        {
            DvBAL.LoadDVInto(dtg_DV);
        }
    }
}
