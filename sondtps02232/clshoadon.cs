using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondtps02232
{
    class clshoadon
    {
        public string ID_HD { get; set; }
      

        public string Ten_KH { get; set; }
        public DateTime ngaytaoHD { get; set; }

    
    public clshoadon ()
    {

    }
    public clshoadon (string id_hd, string ten_kh, DateTime ngaytaohd)
    {
          ID_HD = id_hd;
           
            
            Ten_KH = ten_kh;
           ngaytaoHD = ngaytaoHD;
    }
    }
}