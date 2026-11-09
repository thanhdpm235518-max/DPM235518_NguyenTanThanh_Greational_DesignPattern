using System;
using System.Text;
using DPM235518_NguyenTanThanh_Tuan01_Builder_Read_NhanVien_DP.Builders;
using DPM235518_NguyenTanThanh_Tuan01_Builder_Read_NhanVien_DP.Directors;

namespace DPM235518_NguyenTanThanh_Tuan01_Builder_Read_NhanVien_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            InvoiceDirector director = new InvoiceDirector();
            SalesInvoiceBuilder builder = new SalesInvoiceBuilder();
            director.Builder = builder;

            Console.WriteLine("===== HÓA ĐƠN CƠ BẢN =====");
            director.BuildBasicInvoice();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("===== HÓA ĐƠN ĐẦY ĐỦ =====");
            director.BuildFullInvoice();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("===== HÓA ĐƠN TÙY CHỈNH =====");
            builder.BuildBasicInfo();
            builder.BuildDiscountPromotion();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}
