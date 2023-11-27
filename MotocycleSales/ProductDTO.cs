using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MotocycleSales
{
    class ProductDTO
    {
        [DisplayName("Mã loại xe")]
        public string _maLoaiXe { get; set; }
        [DisplayName("Mã xe")]
        public string _maXe { get; set; }

        [DisplayName("Tên xe")]
        public string _tenXe { get; set; }
        [DisplayName("Màu xe")]
        public string _mauXe { get; set; }
        [DisplayName("Số lượng còn lại")]
        public int _soLuongCon { get; set; }

        [DisplayName("Giá bán")]
        public double _giaban { get; set; }

    }
}
