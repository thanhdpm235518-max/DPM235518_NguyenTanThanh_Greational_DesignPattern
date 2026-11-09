using DPM235518_NguyenTanThanh_Tuan01_Factory_Read_NhanVien_DP.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235518_NguyenTanThanh_Tuan01_Factory_Read_NhanVien_DP.Creators
{
    class GiaoDichBanSi : NhanVienBanHang
    {
        public override IHoaDon TaoHoaDon() => new HoaDonBanSi();
    }
}
