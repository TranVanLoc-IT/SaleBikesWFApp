using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotocycleSales
{
    public partial class SaleProgram : Form
    {
        DataFlow data = new DataFlow();
        public SaleProgram()
        {
            InitializeComponent();
        }

        private void SaleProgram_Load(object sender, EventArgs e)
        {

        }

        private bool CheckKm()
        {
            return true;
        }
        private void btnAddKm_Click(object sender, EventArgs e)
        {
            if (CheckKm())
            {
                ChuongTrinhKM km = new ChuongTrinhKM();
                km.MaChuongTrinh = data.GenerateKMCode();
                km.VoucherGiamGia = double.Parse(txtKmValue.Text);
                km.DanhSachQuaTang = txtKmName.Text;
                km.MaLoaiKhach = txtKmObject.Text;
                km.NgayBD = dateStartkm.Value;
                km.NgayHH = dateEndKm.Value;
                if (data.AddCTKM(km))
                {
                    MessageBox.Show("Thêm chương trình km thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm chương trình km thất bại", "Thông báo");
                }
            }
        }

        private void btnDeleteKm_Click(object sender, EventArgs e)
        {
            string text = txtKmName.Text;
            if (!string.IsNullOrEmpty(text) && text.Length < 10)
            {
                if (data.RemoveCTKM(text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
            }
        }

    }
}
