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
    public partial class FormAdmin_KH : Form
    {
        public FormAdmin_KH()
        {
            InitializeComponent();
        }

        private void FormAdmin_KH_Load(object sender, EventArgs e)
        {
            CusBAL.LoadCusInto(dvgCus);
        }
    }
}
