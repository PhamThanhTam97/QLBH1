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
            if (masp == string.Empty)
                return "1";
            Connection con = new Connection();
            DataGridView grid = new DataGridView();
            string lenh = "SELECT * FROM SANPHAM where MaSP = '" + masp + "'";
            con.TruyVan(lenh);
            if (masp != lenh)
                return "2";
            return "0";
        }

    }
}
