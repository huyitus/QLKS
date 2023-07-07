using QLKS.BAL;

using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormDevideRoom : Form
    {
        private FormReceptionistViewRoom parent;
        public FormDevideRoom(FormReceptionistViewRoom parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnPhanPhong_Click(object sender, System.EventArgs e)
        {
            string maDP = tbMaDP.Text;
            string maPhong = tbMaPhong.Text;
            if (ReceptionistDividedRoomBAL.Thuchienphanphong(maDP, maPhong))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parent.UpdateTinhTrangPhong();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //MessageBox.Show(ReceptionistDividedRoomBAL.Thuchienphanphong(maDP, maPhong), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
