using System;
using DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Products;

namespace DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Factories
{
    public interface ISalesFactory
    {
        IInvoice CreateInvoice();

        IDiscountPolicy CreateDiscountPolicy();
    }
}
