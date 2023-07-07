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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLKS.GUI
{
    public partial class FormLT_Customer : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Bạn có chắc chắn muốn xóa khách hàng này?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Xóa thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Xóa thất bại!";

        private readonly Form parent;
        public FormLT_Customer(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddCustomer f = new FormAddCustomer(this);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FormLT_Customer_Form_Closed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void FormLT_Customer_Load(object sender, EventArgs e)
        {
            CusBAL.LoadCusInto(dataKH);
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string makh = dataKH.CurrentRow.Cells["MaKH"].Value.ToString();

            if (makh != null)
            {
                Form form = new FormLT_editCus(this, makh);
                form.Show();
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string makh = dataKH.CurrentRow.Cells["MaKH"].Value.ToString();

            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (CusBAL.SendRequestDelKH(makh))
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            CusBAL.LoadCusInto(dataKH);
        }
    }
}
