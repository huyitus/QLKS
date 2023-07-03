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
    public partial class FormAdmin_DT : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Bạn có chắc chắn muốn xóa đối tác này?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Xóa thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Xóa thất bại!";
        public FormAdmin_DT()
        {
            InitializeComponent();
        }

        private void FormAdmin_DT_Load(object sender, EventArgs e)
        {
            PnBAL.LoadPartnerInto(dgv_DT);
        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            FormAdmin_AddPartner f = new FormAdmin_AddPartner();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void butt_Del_Click(object sender, EventArgs e)
        {
            string madt = dgv_DT.CurrentRow.Cells["MaDT"].Value.ToString();
            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (PnBAL.SendRequestDel(madt))
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
            string id = dgv_DT.CurrentRow.Cells["MaDT"].Value.ToString();
            if (id != null)
            {
                Form form = new FormAdminEditDT(this, id);
                form.Show();
            }
        }

        private void butt_Re_Click(object sender, EventArgs e)
        {
            PnBAL.LoadPartnerInto(dgv_DT);
        }
    }
}
