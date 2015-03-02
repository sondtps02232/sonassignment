using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondtps02232
{
    class clshanghoa
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }

      
        public string GiaSP { get; set; }
        public string MoTa { get; set; }

  public clshanghoa()
        {

        }
  
        
        
        public clshanghoa(string masp, string tensp, string giasp,string mota)
        {
            MaSP = masp;
            TenSP = tensp;
            
            GiaSP = giasp;
           MoTa = mota;
        
    }
}
}
