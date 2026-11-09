using System;

namespace DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Products
{
    public class WholesaleDiscountPolicy : IDiscountPolicy
    {
        public string GetPolicyName()
        {
            return "Chính sách chiết khấu bán sỉ";
        }

        public decimal CalculateDiscount(IInvoice invoice)
        {
            // 10% chỉ để minh họa
            return invoice.GetProductAmount() * 0.10m;
        }
    }
}
