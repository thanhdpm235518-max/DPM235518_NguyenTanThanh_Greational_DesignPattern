using DPM235518_NguyenTanThanh_Tuan01_Factory_Read_NhanVien_DP.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235518_NguyenTanThanh_Tuan01_Factory_Read_NhanVien_DP.Creators
{
    // Creator
    abstract class NhanVienBanHang
    {
        public abstract IHoaDon TaoHoaDon();

        public void LapHoaDonThanhToan(double tienHang, double phiVC, double giamGia)
        {
            var hoaDon = TaoHoaDon();
            hoaDon.NhapThongTin(tienHang, phiVC, giamGia);
            hoaDon.InHoaDon();
        }
    }
}
