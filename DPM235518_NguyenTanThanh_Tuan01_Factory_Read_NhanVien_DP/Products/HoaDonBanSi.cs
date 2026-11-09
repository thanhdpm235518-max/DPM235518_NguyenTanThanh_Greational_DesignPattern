using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235518_NguyenTanThanh_Tuan01_Factory_Read_NhanVien_DP.Products
{
    class HoaDonBanSi : IHoaDon
    {
        private double _tongTien;
        private double _phiVanChuyen;
        private double _chietKhau;
        private double _phiBocXep = 500000;

        public void NhapThongTin(double tongTienHang, double phiVanChuyen, double chietKhau)
        {
            _tongTien = tongTienHang;
            _phiVanChuyen = phiVanChuyen;
            _chietKhau = chietKhau + (_tongTien * 0.05); // Tự động giảm 5%
        }

        public void InHoaDon()
        {
            double thanhTien = _tongTien + _phiVanChuyen + _phiBocXep - _chietKhau;
            Console.WriteLine("+-----------------------------------------------+");
            Console.WriteLine("|          HÓA ĐƠN BÁN SỈ - NÔNG DƯỢC           |");
            Console.WriteLine("+---------------------------+-------------------+");
            Console.WriteLine("| Hạng mục                  | Số tiền           |");
            Console.WriteLine("+---------------------------+-------------------+");
            Console.WriteLine($"| {"Tiền hàng",-25} | {_tongTien,17:C0} |");
            Console.WriteLine($"| {"Phí vận chuyển (Xe tải)",-25} | {_phiVanChuyen,17:C0} |");
            Console.WriteLine($"| {"Phí bốc xếp",-25} | {_phiBocXep,17:C0} |");
            Console.WriteLine($"| {"Tổng chiết khấu",-25} | {_chietKhau,17:C0} |");
            Console.WriteLine("+---------------------------+-------------------+");
            Console.WriteLine($"| {"TỔNG THANH TOÁN",-25} | {thanhTien,17:C0} |");
            Console.WriteLine("+---------------------------+-------------------+\n");
        }
    }
}
