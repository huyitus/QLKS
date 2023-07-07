using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormRecepOrderGroupRoom : Form
    {
        private readonly Form parent;
        public FormRecepOrderGroupRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormRecepOrderGroupRoom_Load(object sender, EventArgs e)
        {
            //parent.Hide();
            ReceptionistOrderRoomBAL.LoadInfo(dgvPhong,cbLoaiPhong);
        }

        private void FormRecepOrderGroupRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiphong = cbLoaiPhong.SelectedItem.ToString();
            ReceptionistOrderRoomBAL.UpdateInfo(dgvPhong, loaiphong);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = tbTenKH.Text;
            string sdt = tbSDT.Text;
            string diachi = tbDiaChi.Text;
            string email = tbEmail.Text;
            string sofax = tbSoFax.Text;
            string tendoan = tbTenDoan.Text;
            string soluongnguoi = tbSoLuongNguoi.Text;
            string maphong = dgvPhong.CurrentRow.Cells[0].Value.ToString();
            string ngayden = tbNgayDen.Text;
            string sodemluutru = tbSoDemLuuTru.Text;
            string loaiphong = cbLoaiPhong.SelectedItem.ToString();

            /*string data = ten + sdt + diachi + email + sofax + tendoan + soluongnguoi + maphong + ngayden + sodemluutru + loaiphong;
            MessageBox.Show(data);*/

            if (ReceptionistOrderRoomBAL.DatPhongNhom(ten, sdt, diachi, email, sofax, tendoan, soluongnguoi, loaiphong, maphong, ngayden, sodemluutru))
            {
                MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đặt phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ReceptionistOrderRoomBAL.LoadInfo(dgvPhong, cbLoaiPhong);

            //MessageBox.Show(ReceptionistOrderRoomBAL.DatPhongNhom(ten, sdt, diachi, email, sofax, tendoan, soluongnguoi, loaiphong, maphong, ngayden, sodemluutru));
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tbNgayDen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbSoDemLuuTru_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
