using System;
using System.Text;
using DPM235518_NguyenTanThanh_Tuan01_Prototype_Real_NhanVien_DP.Prototypes;

namespace DPM235518_NguyenTanThanh_Tuan01_Prototype_Real_NhanVien_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.InputEncoding = Encoding.UTF8;

            GoodsReceipt receipt1 = new GoodsReceipt();

            receipt1.ReceiptCode = "PN001";

            receipt1.ProductName = "Thuốc trừ sâu A";

            receipt1.Quantity = 100;

            receipt1.ImportDate = new DateTime(2026, 9, 3);

            receipt1.BatchInfo = new BatchInfo(
                "LOT-A001",
                new DateTime(2028, 9, 3)
            );

            GoodsReceipt receipt2 = receipt1.ShallowCopy();

            GoodsReceipt receipt3 = receipt1.DeepCopy();

            Console.WriteLine("===== GIÁ TRỊ BAN ĐẦU =====");

            Console.WriteLine("\nPhiếu nhập gốc - receipt1:");
            DisplayValues(receipt1);

            Console.WriteLine("\nShallow Copy - receipt2:");
            DisplayValues(receipt2);

            Console.WriteLine("\nDeep Copy - receipt3:");
            DisplayValues(receipt3);

            receipt1.ReceiptCode = "PN001-EDIT";

            receipt1.ProductName = "Thuốc trừ sâu A - Đã chỉnh sửa";

            receipt1.Quantity = 200;

            receipt1.ImportDate = new DateTime(2026, 9, 10);

            receipt1.BatchInfo!.BatchCode = "LOT-CHANGED";

            receipt1.BatchInfo!.ExpiryDate = new DateTime(2030, 1, 1);

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("SAU KHI THAY ĐỔI receipt1");
            Console.WriteLine("==================================");

            Console.WriteLine("\nPhiếu nhập gốc - receipt1:");
            DisplayValues(receipt1);

            Console.WriteLine("\nShallow Copy - receipt2:");
            DisplayValues(receipt2);

            Console.WriteLine("\nDeep Copy - receipt3:");
            DisplayValues(receipt3);
        }

        public static void DisplayValues(GoodsReceipt receipt)
        {
            Console.WriteLine(
                $"Mã phiếu nhập: {receipt.ReceiptCode}"
            );

            Console.WriteLine(
                $"Sản phẩm: {receipt.ProductName}"
            );

            Console.WriteLine(
                $"Số lượng: {receipt.Quantity}"
            );

            Console.WriteLine(
                $"Ngày nhập: {receipt.ImportDate:dd/MM/yyyy}"
            );

            Console.WriteLine(
                $"Mã lô: {receipt.BatchInfo!.BatchCode}"
            );

            Console.WriteLine(
                $"Hạn sử dụng: {receipt.BatchInfo!.ExpiryDate:dd/MM/yyyy}"
            );
        }
    }
}
