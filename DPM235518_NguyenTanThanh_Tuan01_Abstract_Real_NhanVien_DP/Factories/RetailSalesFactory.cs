using System;
using DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Products;

namespace DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Factories
{
    public class RetailSalesFactory : ISalesFactory
    {
        public IInvoice CreateInvoice()
        {
            return new RetailInvoice(
                "Nguyễn Văn An",
                2_000_000
            );
        }

        public IDiscountPolicy CreateDiscountPolicy()
        {
            return new RetailDiscountPolicy();
        }
    }
}
