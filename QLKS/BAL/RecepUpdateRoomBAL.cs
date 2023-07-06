using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class RecepUpdateRoomBAL
    {
        public static void LoadMaPhong(ComboBox cbMaPhong)
        {
            List<RecepUpdateRoomDAL> maphong = RecepUpdateRoomDAL.loadMaPhong();
            for(int i = 0;i<maphong.Count;++i)
            {
                cbMaPhong.Items.Add(maphong[i].MaPhong);
            }    
        }
    }
}
