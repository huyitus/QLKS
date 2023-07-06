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
            
        }

        private void FormReceptionistOrderPersionalRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
