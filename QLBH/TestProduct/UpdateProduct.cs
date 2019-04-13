using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestProduct
{
    public class UpdateProduct
    {
        public static string CheckUpdate(string masp, string tenspthaydoi, string dongiathaydoi)
        {

            Connection con = new Connection();
            string kt = "0";
            if (tenspthaydoi == "") { kt = "1"; }

            else if (dongiathaydoi == "") { kt = "2"; }
            else
            {
                con.TruyVan("UPDATE SANPHAM SET TenSP = '" + tenspthaydoi + "', DonGia = '" + dongiathaydoi + "' WHERE MaSP ='" + masp + "'");
                kt = "0";
            }
            return kt;

        }

    }
}
