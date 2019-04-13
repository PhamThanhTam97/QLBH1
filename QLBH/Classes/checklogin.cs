using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH
{
   public class checklogin
    {
       public static string ktdangnhap(string id, string pass)
       {
           if ((id == "") && (pass == "")) { return ("1"); }
           else
               if ((id == "")) { return ("2"); }
               else
                   if (pass == "") { return ("3"); }
                   else if (id == "admin" && pass != "123") { return "4"; }
                   else if (id != "admin") { return "5"; }
                   else return "0";
       }
    }
}
