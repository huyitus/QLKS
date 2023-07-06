using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormRecepUpdateRoom : Form
    {
        private readonly Form parent;

        public FormRecepUpdateRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormRecepUpdateRoom_Load(object sender, EventArgs e)
        {
            RecepUpdateRoomBAL.LoadMaPhong(cbMaPhong);
            cbTTDonDep.Items.Add("Chưa dọn");
            cbTTDonDep.Items.Add("Đã dọn");
        }

        private void FormRecepUpdateRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
