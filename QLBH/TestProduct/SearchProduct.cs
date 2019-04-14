using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.TestProduct
{
    public class SearchProduct
    {
        public static string CheckSearchProduct(string masp)
        {

            Connection con = new Connection();
            string kt = "0";
            string lenh = "SELECT * FROM SANPHAM where MaSP = '" + masp + "'";
            con.TruyVan(lenh);
            if (masp == "") { kt = "1"; }
            else if (masp !=  lenh) { kt = "2"; }
            else
            {
                con.TruyVan("SELECT * FROM SANPHAM where MaSP = '" + masp + "'");
                kt = "0";
            }
            return kt;

        }
    }
}
