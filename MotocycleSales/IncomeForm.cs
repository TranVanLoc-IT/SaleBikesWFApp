using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MotocycleSales
{
    public partial class IncomeForm : Form
    {
        DataFlow data = new DataFlow();
        QuanLy _manager { get; set; }
        public IncomeForm(QuanLy manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

            //foreach (var month in data.GetMonthStatisticBillInStore(_manager.MaQuanLy))
            //{
            //    cbStatisticTimeOptions.Items.Add("Tháng " + month);
            //}
            gbStatisticIncome.Enabled = true;
        }

        private void txtBikeIdOrTypeStatistic_TextChanged(object sender, EventArgs e)
        {
            statisticChart.Series.Clear();
            if (txtBikeIdOrTypeStatistic.Text.Length >= 4)
            {
                PerformDataOnChart(0);
            }
        }
        public void PerformDataOnChart(int option)
        {

            statisticChart.ChartAreas.Clear();
            statisticChart.Series.Clear();
            var getStatistic = data.GetStatisticInfomationByType(txtBikeIdOrTypeStatistic.Text);
            if (option != 0)
            {
                getStatistic.Where(item => item._thoigian.ToString().Contains(option.ToString() + '/'));
            }
            double totalIncome = 0;
            int totalQuantity = 0;
            statisticChart.Titles.Add(getStatistic[0]._tenxe);
            ChartArea area = new ChartArea();
            area.AxisY.Title = "Doanh thu";
            area.AxisX.Title = "Màu sắc";
            area.Position.Width = 100;
            area.Position.Height = 10;
            statisticChart.ChartAreas.Add(area);

            statisticChart.Series.Add("Doanh thu");
            statisticChart.Series.Add("Số lượng");
            foreach (var item in getStatistic)
            {
                statisticChart.Series["Doanh thu"].Points.AddXY(item._mausac, item._doanhthu);
                statisticChart.Series["Số lượng"].Points.AddXY(item._mausac, item._soluong);
                totalIncome += item._doanhthu;
                totalQuantity += item._soluong;
            }
            lbTotalIncome.Text = totalIncome.ToString();
            lbSumOfCarSold.Text = totalQuantity.ToString();
        }

        private void cbStatisticTimeOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int parse;
            if (int.TryParse(cbStatisticTimeOptions.GetItemText(cbStatisticTimeOptions.SelectedItem).Split(' ')[1], out parse))
            {
                PerformDataOnChart(parse);
            }
        }

        private void txtBikeIdOrTypeStatistic_TextChanged_1(object sender, EventArgs e)
        {
            string text = txtBikeIdOrTypeStatistic.Text;
            if (text != null && text.Length >= 4)
            {
                cbStatisticTimeOptions.Enabled = true;
            }
        }

    }
}
