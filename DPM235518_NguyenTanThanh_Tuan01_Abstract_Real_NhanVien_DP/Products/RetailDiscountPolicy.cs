using System;

namespace DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Products
{
    public class RetailDiscountPolicy : IDiscountPolicy
    {
        public string GetPolicyName()
        {
            return "Chính sách giảm giá bán lẻ";
        }

        public decimal CalculateDiscount(IInvoice invoice)
        {
            // 5% chỉ để minh họa
            return invoice.GetProductAmount() * 0.05m;
        }
    }
}
