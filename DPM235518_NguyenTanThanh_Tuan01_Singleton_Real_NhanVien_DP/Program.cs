using System;
using System.Text;
using DPM235518_NguyenTanThanh_Tuan01_Singleton_Real_NhanVien_DP.Modules;
using DPM235518_NguyenTanThanh_Tuan01_Singleton_Real_NhanVien_DP.Singletons;

namespace DPM235518_NguyenTanThanh_Tuan01_Singleton_Real_NhanVien_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.InputEncoding = Encoding.UTF8;

            StoreConfiguration config1 =
                StoreConfiguration.GetInstance();

            Console.WriteLine("CẤU HÌNH BAN ĐẦU:");
            config1.ShowConfiguration();

            Console.WriteLine();
            Console.WriteLine("THAY ĐỔI CẤU HÌNH...");

            config1.ExportMethod = "Xuất hàng theo lô chỉ định";

            config1.PriceMethod = "Nhập trước xuất trước (FIFO)";

            StoreConfiguration config2 =
                StoreConfiguration.GetInstance();

            Console.WriteLine();
            Console.WriteLine("CẤU HÌNH ĐỌC TỪ config2:");
            config2.ShowConfiguration();

            Console.WriteLine();

            if (config1 == config2)
            {
                Console.WriteLine("Singleton hoạt động:");
                Console.WriteLine(
                    "config1 và config2 là cùng một instance."
                );
            }
            else
            {
                Console.WriteLine("Singleton thất bại:");
                Console.WriteLine(
                    "config1 và config2 là hai instance khác nhau."
                );
            }

            Console.WriteLine();

            InventoryModule inventory = new InventoryModule();
            SalesModule sales = new SalesModule();

            inventory.ShowInventoryConfiguration();

            Console.WriteLine();

            sales.ShowSalesConfiguration();
        }
    }
}
