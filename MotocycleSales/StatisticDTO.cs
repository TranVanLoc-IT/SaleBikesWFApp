using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace MotocycleSales
{
    class StatisticDTO
    {
        [DisplayName("Tên xe")]
        public string _tenxe { get; set; }
        [DisplayName("Mã xe")]
        public string _maxe { get; set; }
        [DisplayName("Doanh thu")]
        public double _doanhthu { get; set; }
        [DisplayName("Thời gian")]
        public DateTime? _thoigian { get; set; }

        [DisplayName("Màu sắc")]
        public string _mausac { get; set; }

        [DisplayName("Số lượng")]
        public int _soluong { get; set; }

    }
}
