using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondtps02232
{
    class SQLConnection
    {
        public static string chuoiketnoi = "Data Source = Belief; database = ASS1; Integrated Security=True";

        public static int executeNonquery(string strQuery)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            SqlCommand command = new SqlCommand(strQuery, conn);
            int resuit = command.ExecuteNonQuery();
            conn.Close();
            return resuit;
        }
        public static DataTable executeQuery(string strQuery)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            SqlCommand command = new SqlCommand(strQuery, conn);
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(ds);
            conn.Close();
            return ds.Tables[0];
        }

        public static DataTable loadsp()
        {
            string strQuery = "Select * from SanPham";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static void themsp(string MaSP, string TenSP,  string Giaban, string Mota)
        {
            string strQuery = "set dateformat dmy insert into SanPham(ID_SP, Ten_SP, Gia_SP, Mo_ta) values('" + MaSP + "',N'" + TenSP + "','" + Giaban + "',N'" + Mota + "')";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void xoasp(string MaSP)
        {
            string strQuery = "delete from SanPham where ID_SP = '" + MaSP + "'";
            SQLConnection.executeNonquery(strQuery);
        }
        public static void suasp(string MaSP, string TenSP, string Giaban, string Mota)
        {
            string strQuery = "set dateformat dmy Update SanPham set ID_SP = '" + MaSP + "',Ten_SP = N'" + TenSP + "', Gia_SP = '" + Giaban + "', Mo_ta = '" + Mota + "' where ID_SP = '" + MaSP + "'";
            SQLConnection.executeNonquery(strQuery);

        }
        public static DataTable loadhd()
        {
            string strQuery = "Select * from HoaDon";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static void themhd(string ID_HD, string Ten_KH, DateTime NgaytaoHD)
        {
            string strQuery = "set dateformat dmy insert into HoaDon(ID_HD,  Ten_KH, Ngay_tao_HD) values('" + ID_HD + "','" + Ten_KH + "',N'" + NgaytaoHD + "')";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void xoahd(string ID_HD)
        {
            string strQuery = "delete from HoaDon where ID_HD = '" + ID_HD + "'";
            SQLConnection.executeNonquery(strQuery);
        }
        public static void suaHD(string ID_HD, string Ten_KH, DateTime NgaytaoHD)
        {
            string strQuery = "set dateformat dmy Update HoaDon set ID_HD = '" + ID_HD + "',Ten_KH = N'" + Ten_KH + "', Ngay_tao_HD = '" + NgaytaoHD + "' where ID_HD = '" + ID_HD + "'";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void themkhachhang(string makh, string tenkh, string diachi, string sdt,string gioitinh,DateTime ngaysinh)
        {
            string strQuery = "set dateformat dmy insert into KhachHang(ID_KH, Ten_KH, Dia_chi, So_dien_thoai,Gioi_tinh,Ngay_sinh) values('" + makh + "',N'" + tenkh + "',N'" + diachi + "','" + sdt + "','" + gioitinh + "','" + ngaysinh + "')";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void xoakhachhang(string makh)
        {
            string strQuery = "delete from KhachHang where ID_KH = '" + makh + "'";
            SQLConnection.executeNonquery(strQuery);
        }
        public static DataTable loadkhachhang()
        {
            string strQuery = "Select * from KhachHang";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static void suakh(string Makh, string Tenkh, string Diachi, string SDT,string Gioitinh, DateTime Ngaysinh)
        {
            string strQuery = "set dateformat dmy Update KhachHang set ID_KH = '" + Makh + "',Ten_KH = N'" + Tenkh + "', Dia_chi = N'" + Diachi + "', So_dien_thoai = '" + SDT + "', Gioi_tinh = '" + Gioitinh + "', Ngay_sinh = '" + Ngaysinh + "' where ID_KH = '" + Makh + "'";
            SQLConnection.executeNonquery(strQuery);

        }
        }
}
