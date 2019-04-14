using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestBill
{
    public class CheckUpdateBill
    {
        public static string CheckUpdate(string mahd, string manv, string makh, string ngaylap,string ngaynhan)
        {
            Connection con = new Connection();
            string kt = "0";
            if (manv == "") { kt = "1"; }
            else if (makh == "") { kt = "2"; }
            else if (ngaylap == "") { kt = "3"; }
            else if (ngaynhan == "") { kt = "4"; }
            else
            {
                con.TruyVan("UPDATE HOADON SET MaNV = '" + manv + "', MaKH = '" + makh + "', NgayLapHD = '" + ngaylap + "', NgayNhanHang = '" + ngaynhan + "' WHERE MaHD ='" + mahd + "'");
                kt = "0";
            }
            return kt;
        }

    }
}
