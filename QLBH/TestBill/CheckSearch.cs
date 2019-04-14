using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestBill
{
    public class CheckSearch
    {
        public static string kt_searchBill(string mahd)
        {
            if (mahd == string.Empty)
                return "1";
            Connection con = new Connection();
            string lenh = "SELECT * FROM HOADON where MAHD = '" + mahd + "'";
            con.TruyVan(lenh);
            return "0";
        }
    }
}
