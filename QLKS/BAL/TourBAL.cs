using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class TourBAL
    {
        public static void LoadTourInto(DataGridView dtg_Tour)
        {
            List<TourDAL> tours = TourDAL.GetTour();
            dtg_Tour.DataSource = tours;
        }
    }
}
