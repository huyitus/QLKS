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
    public partial class FormAdmin_DV : Form
    {
        public FormAdmin_DV()
        {
            InitializeComponent();
        }

        private void lab_QD_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_DV_Load(object sender, EventArgs e)
        {
            DvBAL.LoadDVInto(dtg_DV);
        }
    }
}
