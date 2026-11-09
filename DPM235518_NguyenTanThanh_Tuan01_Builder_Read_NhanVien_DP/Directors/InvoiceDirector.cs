using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235518_NguyenTanThanh_Tuan01_Builder_Read_NhanVien_DP.Directors
{
    // Director: Điều phối thứ tự các bước xây dựng hóa đơn
    public class InvoiceDirector
    {
        private Builders.IInvoiceBuilder? _builder;

        public Builders.IInvoiceBuilder Builder
        {
            set { _builder = value; }
        }

        // Xây dựng hóa đơn cơ bản (chỉ thông tin cơ bản)
        public void BuildBasicInvoice()
        {
            _builder!.BuildBasicInfo();
        }

        // Xây dựng hóa đơn đầy đủ (thông tin + chi phí + chiết khấu)
        public void BuildFullInvoice()
        {
            _builder!.BuildBasicInfo();
            _builder!.BuildAdditionalCosts();
            _builder!.BuildDiscountPromotion();
        }
    }
}
