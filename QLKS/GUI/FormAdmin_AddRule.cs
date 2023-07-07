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
    public partial class FormAdmin_AddRule : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Xác nhận gửi yêu cầu thêm quy định?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Gửi yêu cầu thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Gửi yêu cầu thất bại!";
        public FormAdmin_AddRule()
        {
            InitializeComponent();
        }

        private void txtMaDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt_confirm_Click(object sender, EventArgs e)
        {
            string nd = txtND.Text;
            if (nd == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (RuleBAL.SendRequestAddRule(nd))
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
