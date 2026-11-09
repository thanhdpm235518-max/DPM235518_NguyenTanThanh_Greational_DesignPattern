using System;

namespace DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Products
{
    public interface IDiscountPolicy
    {
        string GetPolicyName();

        decimal CalculateDiscount(IInvoice invoice);
    }
}
