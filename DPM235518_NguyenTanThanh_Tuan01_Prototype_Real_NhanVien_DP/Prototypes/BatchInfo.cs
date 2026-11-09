using System;

namespace DPM235518_NguyenTanThanh_Tuan01_Prototype_Real_NhanVien_DP.Prototypes
{
    public class BatchInfo
    {
        public string BatchCode;

        public DateTime ExpiryDate;


        public BatchInfo(
            string batchCode,
            DateTime expiryDate)
        {
            BatchCode = batchCode;

            ExpiryDate = expiryDate;
        }
    }
}
