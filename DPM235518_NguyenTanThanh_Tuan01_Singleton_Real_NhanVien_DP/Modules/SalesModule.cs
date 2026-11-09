using System;
using DPM235518_NguyenTanThanh_Tuan01_Singleton_Real_NhanVien_DP.Singletons;

namespace DPM235518_NguyenTanThanh_Tuan01_Singleton_Real_NhanVien_DP.Modules
{
    public class SalesModule
    {
        public void ShowSalesConfiguration()
        {
            StoreConfiguration config =
                StoreConfiguration.GetInstance();

            Console.WriteLine("MODULE BÁN HÀNG:");

            Console.WriteLine(
                $"Đang sử dụng phương pháp tính giá: " +
                $"{config.PriceMethod}"
            );
        }
    }
}
