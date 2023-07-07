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
    public partial class FormRecepManageRoom : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Bạn có chắc chắn muốn xóa dịch vụ này khỏi phòng?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Xóa thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Xóa thất bại!";

        private readonly Form parent;
        public static string phong;
        public FormRecepManageRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormRecepManageRoom_Load(object sender, EventArgs e)
        {
            ReceptionistManageRoomBAL.LoadInfo(dgv_phong, dgvDVPhg);
            DvBAL.LoadDVInto(dgvDichVu);
        }

        private void FormRecepManageRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            phong = txtmaphong.Text;
            ReceptionistManageRoomBAL.SearchInfo(dgv_phong, dgvDVPhg, phong);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dgvDVPhg.CurrentRow.Cells["MaDV"].Value.ToString();

            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ReceptionistManageRoomBAL.SendRequestDelDV(id))
                {
                    MessageBox.Show(MESSAGE_SEND_REQUEST_SUCCESS, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(MESSAGE_SEND_REQUEST_FAILED, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string madv = dgvDichVu.CurrentRow.Cells["MaDV"].Value.ToString();
            string maphong = dgv_phong.CurrentRow.Cells["MaPhong"].Value.ToString();
            FormAddServiceToRoom f = new FormAddServiceToRoom(this, maphong, madv);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
