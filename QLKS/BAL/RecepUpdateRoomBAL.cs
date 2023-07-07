using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class RecepUpdateRoomBAL
    {
        public static void LoadMaPhong(ComboBox cbMaPhong)
        {
            List<RecepUpdateRoomDAL> maphong = RecepUpdateRoomDAL.loadMaPhongConTrong();
            for(int i = 0;i<maphong.Count;++i)
            {
                cbMaPhong.Items.Add(maphong[i].MaPhong);
            }    
        }
        public static bool Update(string maPhong, string TTDonDep)
        {
            return RecepUpdateRoomDAL.update(maPhong,TTDonDep);
        }
    }
}
