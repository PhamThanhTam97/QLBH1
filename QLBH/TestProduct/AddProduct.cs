using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.TestProduct
{
    public class AddProduct
    {
            public static string kt_themsp(string masp, string tensp, string dongia)
            {
                Connection con = new Connection();
                string kt = "0";
                if (masp == "") { kt = "1"; }
                else if (tensp == "") { kt = "2"; }
                else if (dongia == "") { kt = "3"; }
                else
                {
                    con.TruyVan("insert into SANPHAM(MaSP,TenSP,DonGia) values ('" + masp + "','" + tensp + "','" + dongia + "')");
                    return "0";
                }
                return kt;
            }
    }
}
