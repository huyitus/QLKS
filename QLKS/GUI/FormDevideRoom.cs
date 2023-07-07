using QLKS.BAL;

using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormDevideRoom : Form
    {
        private readonly Form parent;
        public FormDevideRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnPhanPhong_Click(object sender, System.EventArgs e)
        {
            string maDP = tbMaDP.Text;
            string maPhong = tbMaPhong.Text;
            //ReceptionistDividedRoomBAL.Insert(maDP, maPhong);
            if (ReceptionistDividedRoomBAL.Insert(maDP, maPhong))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
