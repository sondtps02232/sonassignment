using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondtps02232
{
    class clskhachhang
    {
         public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string Gioitinh { get; set; }
        public DateTime Ngaysinh { get; set; }
       

  public clskhachhang()
        {

        }
  
        
        
        public clskhachhang(string makh, string tenkh, string diachi, string sdt, string gioitinh, DateTime ngaysinh)
        {
            MaKH = makh;
            TenKH = tenkh;
            Diachi = diachi;
            SDT = sdt;
            Gioitinh = gioitinh;
            Ngaysinh = ngaysinh;
           
        
    }
}
}
    