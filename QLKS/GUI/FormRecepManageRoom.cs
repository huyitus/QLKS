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
        private readonly Form parent;
        public FormRecepManageRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormRecepManageRoom_Load(object sender, EventArgs e)
        {

        }

        private void FormRecepManageRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
