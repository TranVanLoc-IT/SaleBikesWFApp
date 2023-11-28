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
        public string mach { get; set; }
        public ManageBill()
        {
            InitializeComponent();
        }

        private void ManageBill_Load(object sender, EventArgs e)
        {
            var agentOf = data.db.NhanViens.Where(i => i.MaCuaHang == mach).ToList();

            var getDatas = (from itm in data.GetAllBills()
                           join nv in agentOf
                           on itm.MaNV equals nv.MaNV
                           select new { valueMonth = itm.NgayLap.Value.Month, textMonth = "Tháng " + itm.NgayLap.Value.Month.ToString(),
                                        valueYear = itm.NgayLap.Value.Year, textYear = "Năm " + itm.NgayLap.Value.Year.ToString()
                           }).ToArray();

            cbMonths.Items.AddRange(getDatas);
            cbMonths.ValueMember = "valueMonth";
            cbMonths.DisplayMember = "textMonth";


            cbYears.Items.AddRange(getDatas);
            cbYears.ValueMember = "valueYear";
            cbYears.DisplayMember = "textYear";
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
                    txtHistoryAgent.Text = recieve.MaNV;
                    txtBillCode.Text = recieve.MaHD;
                    var bike = data.GetBillDetailsById(hd);
                    txtcarBought.Text = bike.SanPham.TenXe + " - " + bike.MauSac;
                }
                else
                {
                    MessageBox.Show("Không thấy hóa đơn này");
                }
            }
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = int.Parse(cbMonths.SelectedValue.ToString());
            int year = int.Parse(cbYears.SelectedValue.ToString());

            var bills = data.GetTimeStatisticBillInStore(mach, month, year);
            lbTotalValue.Text = bills.Count().ToString();
            dataGridView.DataSource = "";
            dataGridView.DataSource = bills;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
