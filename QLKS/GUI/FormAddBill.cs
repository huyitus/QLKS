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
    public partial class FormAddBill : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Xác nhận gửi yêu cầu thêm hóa đơn?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Thêm thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Thêm thất bại!";
        public FormAddBill()
        {
            InitializeComponent();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (BillBAL.CheckMaPhong(textBox1.Text).ToString() == "1")
                {
                    dateTimePicker1.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox4.Text = BillBAL.TinhTienHoaDon(textBox1.Text);
                    textBox3.Text = BillBAL.TimMaDatPhong(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Mã phòng này không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userRoom = textBox1.Text.ToString();
            String manhanvien = textBox2.Text.ToString();


            if (userRoom == "" || manhanvien == "" )
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {  
                if (BillBAL.CheckMaNhanVien(manhanvien).ToString()=="0")
                {
                    MessageBox.Show("Mã nhân viên này không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DateTime tglaphd = Convert.ToDateTime(dateTimePicker1.Value);
                    int tongtien = Int32.Parse(textBox4.Text);
                    string madatphong = textBox3.Text.ToString();

                    DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (BillBAL.SendRequestAddBill(manhanvien, madatphong, tglaphd, tongtien))
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
