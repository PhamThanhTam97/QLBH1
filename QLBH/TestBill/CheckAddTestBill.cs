using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestBill
{
    public class TestBill
    {
        public static string kt_themhd(string mahd, string manv, string makh, string ngaylap,string ngaynhan)
        {
            Connection con = new Connection();
            string Lenh = "SELECT * FROM HOADON where MaHD = '" + mahd + "'";
            con.TruyVan(Lenh);
            string kt = "0";
            if (mahd == "") { kt = "1"; }
            else if (manv == "") { kt = "2"; }
            else if (makh == "") { kt = "3"; }
            else if (ngaylap == "") { kt = "4"; }
            else if (ngaynhan == "") { kt = "5"; }
            else
            {
                con.TruyVan("insert into HOADON(MaHD, MaNV, MaKH, NgayLapHD, NgayNhanHang) values ('" + mahd + "','" + manv + "','" + makh + "','" + ngaylap + "','" + ngaynhan + "')");
                return "0";
            }
            return kt;
        }
    }
}
