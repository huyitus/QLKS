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
    public partial class FormRecepSelectedOrder : Form
    {
        private readonly Form parent;
        public FormRecepSelectedOrder(Form parent)
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
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {

        }

        private void btnDoanKhach_Click(object sender, EventArgs e)
        {
            Form RecepOderGroup = new FormRecepOrderGroupRoom(this);
            this.Hide();
            RecepOderGroup.ShowDialog();
        }
    }
}
