using System;

namespace DPM235518_NguyenTanThanh_Tuan01_Abstract_Real_NhanVien_DP.Products
{
    public class RetailInvoice : IInvoice
    {
        private string _customerName;

        private decimal _productAmount;


        public RetailInvoice(
            string customerName,
            decimal productAmount)
        {
            _customerName = customerName;

            _productAmount = productAmount;
        }


        public string GetInvoiceType()
        {
            return "Hóa đơn bán lẻ";
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
