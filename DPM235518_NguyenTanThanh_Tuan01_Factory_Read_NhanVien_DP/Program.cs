using DPM235518_NguyenTanThanh_Tuan01_Factory_Read_NhanVien_DP.Creators;

namespace DPM235518_NguyenTanThanh_Tuan01_Factory_Read_NhanVien_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- HỆ THỐNG LẬP HÓA ĐƠN ---\n");

            Console.WriteLine("[Hệ thống] Nhân viên chọn chức năng: Lập hóa đơn Bán lẻ.");
            NhanVienBanHang giaoDich1 = new GiaoDichBanLe();
            giaoDich1.LapHoaDonThanhToan(500000, 20000, 0);

            Console.WriteLine("[Hệ thống] Nhân viên chọn chức năng: Lập hóa đơn Bán sỉ.");
            NhanVienBanHang giaoDich2 = new GiaoDichBanSi();
            giaoDich2.LapHoaDonThanhToan(50000000, 1000000, 500000);
        }
    }
}
