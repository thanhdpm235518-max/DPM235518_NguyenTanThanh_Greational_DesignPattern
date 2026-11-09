using System;

namespace DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Products
{
    public class WholesaleInvoice : IInvoice
    {
        private string _customerName;

        private decimal _productAmount;


        public WholesaleInvoice(
            string customerName,
            decimal productAmount)
        {
            _customerName = customerName;

            _productAmount = productAmount;
        }


        public string GetInvoiceType()
        {
            return "Hóa đơn bán sỉ";
        }


        public decimal GetProductAmount()
        {
            return _productAmount;
        }


        public string GetInvoiceInfo()
        {
            return
                $"Loại: {GetInvoiceType()}\n" +
                $"Khách hàng: {_customerName}\n" +
                $"Tiền hàng: {_productAmount:N0} VNĐ";
        }
    }
}
