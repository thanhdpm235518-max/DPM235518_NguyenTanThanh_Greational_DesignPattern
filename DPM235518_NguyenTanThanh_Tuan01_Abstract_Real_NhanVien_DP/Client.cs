using System;
using DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Factories;
using DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Products;

namespace DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine(
                "===== HỆ THỐNG BÁN LẺ ====="
            );

            ClientMethod(new RetailSalesFactory());


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(
                "===== HỆ THỐNG BÁN SỈ ====="
            );

            ClientMethod(new WholesaleSalesFactory());
        }

        public void ClientMethod(ISalesFactory factory)
        {
            IInvoice invoice =
                factory.CreateInvoice();

            IDiscountPolicy discountPolicy =
                factory.CreateDiscountPolicy();

            Console.WriteLine(
                invoice.GetInvoiceInfo()
            );

            Console.WriteLine(
                $"Chính sách: " +
                $"{discountPolicy.GetPolicyName()}"
            );

            decimal discount =
                discountPolicy.CalculateDiscount(invoice);

            decimal total =
                invoice.GetProductAmount() - discount;

            Console.WriteLine(
                $"Giảm giá / Chiết khấu: " +
                $"{discount:N0} VNĐ"
            );

            Console.WriteLine(
                $"Tổng thanh toán: " +
                $"{total:N0} VNĐ"
            );
        }
    }
}
