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
    public partial class FormAdmin_QD : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Bạn có chắc chắn muốn xóa quy định này?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Xóa thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Xóa thất bại!";
        public FormAdmin_QD()
        {
            InitializeComponent();
            if (SessionBAL.getUserRole == "LETAN")
            {
                butt_Fix.Visible = false;
                butt_Del.Visible = false;
                butt_Add.Visible = false;
                butt_Re.Visible = false;
            }
        }

        private void dtg_QD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdmin_QD_Load(object sender, EventArgs e)
        {
            RuleBAL.LoadRuleInto(dtg_QD);
        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            FormAdmin_AddRule f = new FormAdmin_AddRule();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void butt_Del_Click(object sender, EventArgs e)
        {
            string maqd = dtg_QD.CurrentRow.Cells["MaQD"].Value.ToString();
            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RuleBAL.SendRequestDel(maqd))
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
            string id = dtg_QD.CurrentRow.Cells["MaQD"].Value.ToString();
            if (id != null)
            {
                Form form = new FormAdminEditRule(this, id);
                form.Show();
            }
        }

        private void butt_Re_Click(object sender, EventArgs e)
        {
            RuleBAL.LoadRuleInto(dtg_QD);
        }
    }
}
