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
    public partial class FormAddDKTour : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Xác nhận gửi yêu cầu thêm đăng ký?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Gửi yêu cầu thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Gửi yêu cầu thất bại!";
        public FormAddDKTour()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String matour = textBox1.Text.ToString();
            String tenkh = textBox2.Text.ToString();
            String sdt = textBox3.Text.ToString();
            String hinhthuc = textBox5.Text.ToString();
            String nhucaudb = textBox7.Text.ToString();
            

            if (matour == "" || tenkh == ""|| sdt == "" || textBox4.Text == "" || hinhthuc == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                if(DKTourBAL.CheckMaTour(matour).ToString()=="0")
                {
                    MessageBox.Show("Mã tour này không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (nhucaudb == "")
                    {
                        nhucaudb = "No";
                    }
                    DateTime date = Convert.ToDateTime(dateTimePicker1.Value);
                    int songuoitg = Int32.Parse(textBox4.Text);

                    DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (DKTourBAL.SendRequestAddDKTour(matour, tenkh, sdt, songuoitg, hinhthuc, date, nhucaudb))
                        {
                            MessageBox.Show(MESSAGE_SEND_REQUEST_SUCCESS, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(MESSAGE_SEND_REQUEST_FAILED, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    this.Hide();
                }
            }
        }
    }
}
