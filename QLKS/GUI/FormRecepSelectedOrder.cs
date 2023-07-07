using QLKS.BAL;

using System;
using System.Windows.Forms;
namespace QLKS.GUI
{
    public partial class FormRecepSelectedOrder : Form
    {
        private FormReceptionistViewRoom parent;
        public FormRecepSelectedOrder(FormReceptionistViewRoom parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormRecepSelectedOrder_Load(object sender, EventArgs e)
        {

        }

        private void FormRecepSelectedOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
            parent.UpdateTinhTrangPhong();
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            Form RecepOrderPersional = new FormReceptionistOrderPersionalRoom(this);
            this.Hide();
            RecepOrderPersional.ShowDialog();
        }

        private void btnDoanKhach_Click(object sender, EventArgs e)
        {
            Form RecepOderGroup = new FormRecepOrderGroupRoom(this);
            this.Hide();
            RecepOderGroup.ShowDialog();
        }
    }
}
