using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MotocycleSales
{
    class InventoryDTO
    {
        [DisplayName("Mã xe")]
        public string _maxe { get; set; }
        [DisplayName("Tên xe")]
        public string _tenxe { get; set; }
        [DisplayName("Số lượng đã bán")]
        public int? _soluongban { get; set; }
        [DisplayName("Số lượng còn lại")]
        public int? _soluongcon { get; set; }
        [DisplayName("Tình trạng")]
        public string _tinhtrang { get; set; }
        [DisplayName("Màu sắc")]
        public string _mausac { get; set; }


    }
}
