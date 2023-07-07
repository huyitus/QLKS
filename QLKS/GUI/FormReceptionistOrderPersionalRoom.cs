using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormReceptionistOrderPersionalRoom : Form
    {
        private readonly Form parent;

        public FormReceptionistOrderPersionalRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormReceptionistOrderPersionalRoom_Load(object sender, EventArgs e)
        {
            ReceptionistOrderRoomBAL.LoadInfo(dgvPhong, cbLoaiPhong);
        }

        private void FormReceptionistOrderPersionalRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiphong = cbLoaiPhong.SelectedItem.ToString();
            ReceptionistOrderRoomBAL.UpdateInfo(dgvPhong, loaiphong);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string ten = tbTenKH.Text;
            string sdt = tbSDT.Text;
            string diachi = tbDiaChi.Text;
            string email = tbEmail.Text;
            string sofax = tbSoFax.Text;
            string maphong = dgvPhong.CurrentRow.Cells[0].Value.ToString();
            string ngayden = tbNgayDen.Text;
            string sodemluutru = tbSoDemLuuTru.Text;
            string loaiphong = cbLoaiPhong.SelectedItem.ToString();
            if (ReceptionistOrderRoomBAL.DatPhongCaNhan(ten, sdt, diachi, email, sofax, loaiphong, maphong, ngayden, sodemluutru))
            {
                MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đặt phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ReceptionistOrderRoomBAL.LoadInfo(dgvPhong, cbLoaiPhong);
        }
    }
}
