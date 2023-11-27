
namespace MotocycleSales
{
    partial class IncomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.gbStatisticIncome = new System.Windows.Forms.GroupBox();
            this.txtBikeIdOrTypeStatistic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.lbTotalIncome = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbSumOfCarSold = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbStatisticTimeOptions = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.statisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbStatisticIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStatisticIncome
            // 
            this.gbStatisticIncome.AutoSize = true;
            this.gbStatisticIncome.Controls.Add(this.txtBikeIdOrTypeStatistic);
            this.gbStatisticIncome.Controls.Add(this.label11);
            this.gbStatisticIncome.Controls.Add(this.textBox2);
            this.gbStatisticIncome.Controls.Add(this.label25);
            this.gbStatisticIncome.Controls.Add(this.lbTotalIncome);
            this.gbStatisticIncome.Controls.Add(this.lb);
            this.gbStatisticIncome.Controls.Add(this.lbSumOfCarSold);
            this.gbStatisticIncome.Controls.Add(this.label26);
            this.gbStatisticIncome.Controls.Add(this.cbStatisticTimeOptions);
            this.gbStatisticIncome.Controls.Add(this.label27);
            this.gbStatisticIncome.Controls.Add(this.statisticChart);
            this.gbStatisticIncome.Enabled = false;
            this.gbStatisticIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatisticIncome.Location = new System.Drawing.Point(81, 69);
            this.gbStatisticIncome.Name = "gbStatisticIncome";
            this.gbStatisticIncome.Size = new System.Drawing.Size(887, 372);
            this.gbStatisticIncome.TabIndex = 93;
            this.gbStatisticIncome.TabStop = false;
            this.gbStatisticIncome.Text = "Thống kê doanh thu";
            // 
            // txtBikeIdOrTypeStatistic
            // 
            this.txtBikeIdOrTypeStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBikeIdOrTypeStatistic.Location = new System.Drawing.Point(617, 88);
            this.txtBikeIdOrTypeStatistic.Multiline = true;
            this.txtBikeIdOrTypeStatistic.Name = "txtBikeIdOrTypeStatistic";
            this.txtBikeIdOrTypeStatistic.Size = new System.Drawing.Size(108, 26);
            this.txtBikeIdOrTypeStatistic.TabIndex = 54;
            this.txtBikeIdOrTypeStatistic.TextChanged += new System.EventHandler(this.txtBikeIdOrTypeStatistic_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(499, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Mã xe/loại xe:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(613, 235);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 98);
            this.textBox2.TabIndex = 52;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(501, 238);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 20);
            this.label25.TabIndex = 51;
            this.label25.Text = "Đánh giá:";
            // 
            // lbTotalIncome
            // 
            this.lbTotalIncome.AutoSize = true;
            this.lbTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalIncome.Location = new System.Drawing.Point(632, 179);
            this.lbTotalIncome.Name = "lbTotalIncome";
            this.lbTotalIncome.Size = new System.Drawing.Size(14, 20);
            this.lbTotalIncome.TabIndex = 50;
            this.lbTotalIncome.Text = " ";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(498, 184);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(134, 20);
            this.lb.TabIndex = 49;
            this.lb.Text = "Tổng doanh thu: ";
            // 
            // lbSumOfCarSold
            // 
            this.lbSumOfCarSold.AutoSize = true;
            this.lbSumOfCarSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumOfCarSold.Location = new System.Drawing.Point(589, 135);
            this.lbSumOfCarSold.Name = "lbSumOfCarSold";
            this.lbSumOfCarSold.Size = new System.Drawing.Size(14, 20);
            this.lbSumOfCarSold.TabIndex = 48;
            this.lbSumOfCarSold.Text = " ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(499, 140);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 20);
            this.label26.TabIndex = 47;
            this.label26.Text = "Số xe bán: ";
            // 
            // cbStatisticTimeOptions
            // 
            this.cbStatisticTimeOptions.Enabled = false;
            this.cbStatisticTimeOptions.FormattingEnabled = true;
            this.cbStatisticTimeOptions.Items.AddRange(new object[] {
            "Tháng",
            "Ngày"});
            this.cbStatisticTimeOptions.Location = new System.Drawing.Point(639, 37);
            this.cbStatisticTimeOptions.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatisticTimeOptions.Name = "cbStatisticTimeOptions";
            this.cbStatisticTimeOptions.Size = new System.Drawing.Size(132, 28);
            this.cbStatisticTimeOptions.TabIndex = 45;
            this.cbStatisticTimeOptions.SelectedIndexChanged += new System.EventHandler(this.cbStatisticTimeOptions_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(498, 45);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(133, 20);
            this.label27.TabIndex = 44;
            this.label27.Text = "Doanh thu theo: ";
            // 
            // statisticChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statisticChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statisticChart.Legends.Add(legend1);
            this.statisticChart.Location = new System.Drawing.Point(0, 31);
            this.statisticChart.Margin = new System.Windows.Forms.Padding(4);
            this.statisticChart.Name = "statisticChart";
            this.statisticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.statisticChart.Size = new System.Drawing.Size(464, 306);
            this.statisticChart.TabIndex = 43;
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 525);
            this.Controls.Add(this.gbStatisticIncome);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            this.gbStatisticIncome.ResumeLayout(false);
            this.gbStatisticIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStatisticIncome;
        private System.Windows.Forms.TextBox txtBikeIdOrTypeStatistic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbTotalIncome;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbSumOfCarSold;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbStatisticTimeOptions;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticChart;
    }
}