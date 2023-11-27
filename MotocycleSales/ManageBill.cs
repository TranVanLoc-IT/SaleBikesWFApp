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
    public partial class ManageBill : Form
    {
        DataFlow data = new DataFlow();
        public ManageBill()
        {
            InitializeComponent();
        }

        private void ManageBill_Load(object sender, EventArgs e)
        {

        }

        private void txtBillSearch_TextChanged(object sender, EventArgs e)
        {
            string hd = txtBillSearch.Text;
            if (hd.StartsWith("HD") && hd.Length == 7)
            {
                var recieve = data.FindHDById(hd);
                if (recieve != null)
                {
                    txtCustomerInBill.Text = recieve.KhachHang.TenKH;
                    dateSet.Text = recieve.NgayLap?.ToString("0:dd/mm/yyyy");
                    txtBillMoney.Text = recieve.TongTien?.ToString("N2");
                    var bike = data.GetBillDetailsById(hd);
                    txtcarBought.Text = bike.SanPham.TenXe + bike.MauSac;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txtBillSearch.Text.Length == 4)
            {
                ManageBillDTO billInfo = data.GetBillInfo(txtBillSearch.Text);

                if (billInfo != null)
                {

                    txtCustomerInBill.Text = billInfo._tenkh;
                    txtBillMoney.Text = billInfo._thanhtoan.ToString();
                    txtcarBought.Text = billInfo._xemua + " - " + billInfo._mausac;
                    dateSet.Text = billInfo._ngaylap.ToString("g");
                }
                else
                {
                    MessageBox.Show("Không thấy hóa đơn này");
                }
            }
        }



    }
}
