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
    public partial class BillConfirm : Form
    {
        DataFlow data = new DataFlow();
        HoaDon hd = new HoaDon();
        public event Action<string> FormClosingEvent;
        ChiTietHoaDon cthd = new ChiTietHoaDon();
        public readonly string _loaikh;
        public double additional_fee { get; set; }
        public readonly double _total;
        public BillConfirm(Payment pay, KhachHang kh, NhanVien nv)
        {
            InitializeComponent();
            this._loaikh = kh.MaLoaiKhach;
            hd.NgayLap = DateTime.Now;
            hd.MaHD = data.GenerateBillCode();
            hd.MaKH = kh.MaKH;
            hd.MaNV = nv.MaNV;

            cthd.MaXe = pay._maxe;
            cthd.MauSac = pay._mausac;
            cthd.SoLuong = 1;
            cthd.MaHD = hd.MaHD;

        }

        private void BillConfirm_Load(object sender, EventArgs e)
        {
            txtTotalMoney.Text = _total.ToString("N2").Substring(0, 8);
            txtVoucher.Text = data.GetDiscountByType(this._loaikh).ToString();
            txtResCost.Text = this.additional_fee.ToString();
            txtCardCost.Text = "1000000";
            txtBillCode.Text = data.GenerateBillCode();

            hd.TongTien = (this.cthd.MaXe.Contains("HDTC") ? 2000000 : this.cthd.MaXe.Contains("HDTG") ? 1000000 : 500000) + 1000000;
            txtTotalMoney.Text = this.hd.TongTien.ToString();

            lbAgentName.Text = this.hd.MaNV;
        }

        private void btnAbate_Click(object sender, EventArgs e)
        {
            if(data.AddBill(hd, cthd))
            {
                CloseForm("Next");
            }
            else
            {
                CloseForm("return");
            }
        }

        private void CloseForm(string buttonName)
        {
            // Kiểm tra tên của button và gọi sự kiện tương ứng
            FormClosingEvent?.Invoke(buttonName);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseForm("return");
        }
    }
}
