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

namespace QLKS.GUI
{
    public partial class FormAdmin_Tour : Form
    {
        public FormAdmin_Tour()
        {
            InitializeComponent();
        }

        private void FormAdmin_Tour_Load(object sender, EventArgs e)
        {
            TourBAL.LoadTourInto(dtg_Tour);
        }
    }
}
