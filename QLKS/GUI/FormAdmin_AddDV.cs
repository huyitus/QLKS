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
    public partial class FormAdmin_AddDV : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Xác nhận gửi yêu cầu thêm dịch vụ?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Gửi yêu cầu thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Gửi yêu cầu thất bại!";
        public FormAdmin_AddDV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butt_confirm_Click(object sender, EventArgs e)
        {
            string name = txtTenDV.Text;
            string gia = txtGiaDV.Text;
            if (name == "" || gia == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DvBAL.SendRequestAddDV(name, gia))
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
}
