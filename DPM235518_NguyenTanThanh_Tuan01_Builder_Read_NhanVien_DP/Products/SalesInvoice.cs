using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235518_NguyenTanThanh_Tuan01_Builder_Read_NhanVien_DP.Products
{
    // Lớp SalesInvoice đại diện cho hóa đơn bán hàng
    // Được tạo ra theo từng bước thông qua Builder
    public class SalesInvoice
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string result = "";

            foreach (string part in _parts)
            {
                result += part + "\n";
            }

            return result;
        }
    }
}
