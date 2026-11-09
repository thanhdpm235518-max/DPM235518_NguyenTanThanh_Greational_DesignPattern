using System;
using DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Products;

namespace DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Factories
{
    public class WholesaleSalesFactory : ISalesFactory
    {
        public IInvoice CreateInvoice()
        {
            return new WholesaleInvoice(
                "Đại lý Nông nghiệp An Phú",
                20_000_000
            );
        }

        public IDiscountPolicy CreateDiscountPolicy()
        {
            return new WholesaleDiscountPolicy();
        }
    }
}
