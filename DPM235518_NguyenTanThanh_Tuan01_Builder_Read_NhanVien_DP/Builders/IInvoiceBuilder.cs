using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235518_NguyenTanThanh_Tuan01_Builder_Read_NhanVien_DP.Builders
{
    // Interface định nghĩa các bước xây dựng hóa đơn bán hàng
    public interface IInvoiceBuilder
    {
        void BuildBasicInfo();

        void BuildAdditionalCosts();

        void BuildDiscountPromotion();
    }
}
