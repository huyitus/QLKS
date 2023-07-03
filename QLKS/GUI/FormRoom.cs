using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormRoom : Form
    {
        private readonly Form parent;

        public static string khachhang;
        public FormRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void FormRoom_Load(object sender, EventArgs e)
        {
            parent.Hide();
            ReceptionistRoomBAL.LoadInfo(dGV_DSdatphong, dGV_DSPhong,false,false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            khachhang = tbTenKH.Text;
            ReceptionistRoomBAL.SearchInfo(dGV_DSdatphong, khachhang);
        }

        private void FormRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            bool isEmpty = cBPhongTrong.Checked;
            bool isClean = cBPhongCDD.Checked;
            ReceptionistRoomBAL.LoadInfo(dGV_DSdatphong, dGV_DSPhong, isEmpty, isClean);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReceptionistRoomBAL.ReLoadInfo(dGV_DSdatphong);
        }
    }
    
}
