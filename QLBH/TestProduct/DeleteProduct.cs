using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestProduct
{
    public class DeleteProduct
    {
        public static string CheckDetele(string masp)
        {
            Connection con = new Connection();
            con.TruyVan("delete from SANPHAM WHERE MaSp = '" + masp + "'");
            return "0";
        }
    }
}
