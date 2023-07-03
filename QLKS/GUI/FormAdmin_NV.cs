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
using System.Xml.Linq;

namespace QLKS.GUI
{
    public partial class FormAdmin_NV : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Bạn có chắc chắn muốn xóa nhân viên này?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Xóa thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Xóa thất bại!";
        public FormAdmin_NV()
        {
            InitializeComponent();
        }

        private void FormAdmin_NV_Load(object sender, EventArgs e)
        {
            NvBAL.LoadNVInto(dgv_NV);
        }

        private void FormAdmin_NV_FormClosing(object sender, FormClosingEventArgs e) 
        {

        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            FormAdmin_AddNV f = new FormAdmin_AddNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void butt_Del_Click(object sender, EventArgs e)
        {
            string manv = dgv_NV.CurrentRow.Cells["MaNV"].Value.ToString();

            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (NvBAL.SendRequestDelNV(manv))
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
            string id = dgv_NV.CurrentRow.Cells["MaNV"].Value.ToString();
            if (id != null)
            {
                Form form = new FormAdminEditEmployee(this, id);
                form.Show();
            }
        }

        private void butt_Re_Click(object sender, EventArgs e)
        {
            NvBAL.LoadNVInto(dgv_NV);
        }
    }
}
