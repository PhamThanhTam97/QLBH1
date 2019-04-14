using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestBill
{
    public class CheckDelete
    {
        public static string kt_delete(string mahd)
        {
            Connection con = new Connection();
            con.TruyVan("delete from HOADON WHERE MaHD = '" + mahd + "'");
            return "0";
        }
    }
}
