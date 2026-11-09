using System;

namespace DPM235518_NguyenTanThanh_Tuan01_Prototype_Real_NhanVien_DP.Prototypes
{
    public class GoodsReceipt
    {
        public string? ReceiptCode;

        public string? ProductName;

        public int Quantity;

        public DateTime ImportDate;

        public BatchInfo? BatchInfo;


        public GoodsReceipt ShallowCopy()
        {
            return (GoodsReceipt)this.MemberwiseClone();
        }

        public GoodsReceipt DeepCopy()
        {
            GoodsReceipt clone =
                (GoodsReceipt)this.MemberwiseClone();

            clone.BatchInfo =
                new BatchInfo(
                    BatchInfo!.BatchCode,
                    BatchInfo!.ExpiryDate
                );

            return clone;
        }
    }
}
