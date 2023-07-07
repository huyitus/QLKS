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
    public partial class FormAdmin_AddPartner : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Xác nhận gửi yêu cầu thêm đối tác?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Gửi yêu cầu thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Gửi yêu cầu thất bại!";
        public FormAdmin_AddPartner()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butt_confirm_Click(object sender, EventArgs e)
        {
            string name = txtTenDT.Text;
            string mt = txtMatour.Text;
            string dc = txtDc.Text;
            string sdt = txtSDT.Text;
            string mail = txtMail.Text;
            if (name == "" || dc == "" || sdt == "" || mt == "" || mail == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (PnBAL.SendRequestAddPartner(name, mt, dc, sdt, mail))
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
        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void FormAdmin_AddPartner_Load(object sender, EventArgs e)
        {

        }
    }
}
