using System;
using DPM235518_NguyenTanThanh_Tuan01_Singleton_Real_NhanVien_DP.Singletons;

namespace DPM235518_NguyenTanThanh_Tuan01_Singleton_Real_NhanVien_DP.Modules
{
    public class InventoryModule
    {
        public void ShowInventoryConfiguration()
        {
            StoreConfiguration config =
                StoreConfiguration.GetInstance();

            Console.WriteLine("MODULE KHO:");

            Console.WriteLine(
                $"Đang sử dụng phương pháp xuất: " +
                $"{config.ExportMethod}"
            );
        }
    }
}
