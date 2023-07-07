using QLKS.BAL;
using QLKS.DAL;
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
    public partial class FormAddServiceToRoom : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_CONFIRM = "Xác nhận thêm dịch vụ vào phòng?";
        private const string MESSAGE_SEND_REQUEST_SUCCESS = "Thêm thành công!";
        private const string MESSAGE_SEND_REQUEST_FAILED = "Thêm thất bại!";

        private readonly Form parent;
        private readonly string DVId;
        private readonly string PhgId;
        public FormAddServiceToRoom(Form parent, string maphong, string madv)
        {
            InitializeComponent();
            this.parent = parent;
            this.PhgId = maphong;
            this.DVId = madv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maphong = txtmaphong.Text;
            string madv = txtmadv.Text;
            string sl = txtsl.Text;

            DialogResult result = MessageBox.Show(MESSAGE_CONFIRM, MESSAGE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ReceptionistManageRoomBAL.AddServiceToRoom(maphong, madv, sl))
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

        private void FormAddServiceToRoom_Load(object sender, EventArgs e)
        {
            DvDAL dv = DvBAL.GetDV(DVId);
            if (dv != null)
            {
                txtmadv.Text = DVId;
            }
            txtmaphong.Text = PhgId;
        }
    }
}
