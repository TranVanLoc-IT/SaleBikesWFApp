
namespace MotocycleSales
{
    partial class HRForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRForm));
            this.groupBoxInventory = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelAgent = new System.Windows.Forms.Panel();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.txtWorkStatus = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAgentAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbStatisticStaffTimes = new System.Windows.Forms.ComboBox();
            this.txtHRStatus = new System.Windows.Forms.TextBox();
            this.txtHRTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAgentId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddAgent = new System.Windows.Forms.Button();
            this.btnUpdateAgent = new System.Windows.Forms.Button();
            this.btnDelAgent = new System.Windows.Forms.Button();
            this.groupBoxInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelAgent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInventory
            // 
            this.groupBoxInventory.Controls.Add(this.btnAddAgent);
            this.groupBoxInventory.Controls.Add(this.btnUpdateAgent);
            this.groupBoxInventory.Controls.Add(this.btnDelAgent);
            this.groupBoxInventory.Controls.Add(this.chart1);
            this.groupBoxInventory.Controls.Add(this.panelAgent);
            this.groupBoxInventory.Controls.Add(this.cbStatisticStaffTimes);
            this.groupBoxInventory.Controls.Add(this.txtHRStatus);
            this.groupBoxInventory.Controls.Add(this.txtHRTotal);
            this.groupBoxInventory.Controls.Add(this.label8);
            this.groupBoxInventory.Controls.Add(this.button8);
            this.groupBoxInventory.Controls.Add(this.label12);
            this.groupBoxInventory.Controls.Add(this.txtAgentId);
            this.groupBoxInventory.Controls.Add(this.label7);
            this.groupBoxInventory.Enabled = false;
            this.groupBoxInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInventory.Location = new System.Drawing.Point(37, 47);
            this.groupBoxInventory.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInventory.Name = "groupBoxInventory";
            this.groupBoxInventory.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInventory.Size = new System.Drawing.Size(977, 445);
            this.groupBoxInventory.TabIndex = 53;
            this.groupBoxInventory.TabStop = false;
            this.groupBoxInventory.Text = "Nhân sự";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(479, 161);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(455, 279);
            this.chart1.TabIndex = 64;
            this.chart1.Text = "chart1";
            // 
            // panelAgent
            // 
            this.panelAgent.Controls.Add(this.dobPicker);
            this.panelAgent.Controls.Add(this.label31);
            this.panelAgent.Controls.Add(this.txtWorkStatus);
            this.panelAgent.Controls.Add(this.label15);
            this.panelAgent.Controls.Add(this.txtAgentAddress);
            this.panelAgent.Controls.Add(this.label16);
            this.panelAgent.Controls.Add(this.cbStore);
            this.panelAgent.Controls.Add(this.label17);
            this.panelAgent.Controls.Add(this.txtAgentName);
            this.panelAgent.Controls.Add(this.label18);
            this.panelAgent.Location = new System.Drawing.Point(10, 76);
            this.panelAgent.Name = "panelAgent";
            this.panelAgent.Size = new System.Drawing.Size(370, 243);
            this.panelAgent.TabIndex = 55;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(94, 114);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(272, 27);
            this.dobPicker.TabIndex = 34;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(11, 207);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(151, 20);
            this.label31.TabIndex = 32;
            this.label31.Text = "Tình trạng làm việc";
            // 
            // txtWorkStatus
            // 
            this.txtWorkStatus.Location = new System.Drawing.Point(176, 200);
            this.txtWorkStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkStatus.Name = "txtWorkStatus";
            this.txtWorkStatus.Size = new System.Drawing.Size(146, 27);
            this.txtWorkStatus.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 70);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Địa chỉ:";
            // 
            // txtAgentAddress
            // 
            this.txtAgentAddress.Location = new System.Drawing.Point(94, 54);
            this.txtAgentAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentAddress.Multiline = true;
            this.txtAgentAddress.Name = "txtAgentAddress";
            this.txtAgentAddress.Size = new System.Drawing.Size(272, 54);
            this.txtAgentAddress.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 162);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Chọn chi nhánh";
            // 
            // cbStore
            // 
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(156, 159);
            this.cbStore.Margin = new System.Windows.Forms.Padding(4);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(166, 28);
            this.cbStore.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 20);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Tên nhân viên";
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(133, 12);
            this.txtAgentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(196, 27);
            this.txtAgentName.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 120);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 20);
            this.label18.TabIndex = 30;
            this.label18.Text = "Ngày sinh";
            // 
            // cbStatisticStaffTimes
            // 
            this.cbStatisticStaffTimes.FormattingEnabled = true;
            this.cbStatisticStaffTimes.Location = new System.Drawing.Point(657, 23);
            this.cbStatisticStaffTimes.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatisticStaffTimes.Name = "cbStatisticStaffTimes";
            this.cbStatisticStaffTimes.Size = new System.Drawing.Size(119, 28);
            this.cbStatisticStaffTimes.TabIndex = 63;
            this.cbStatisticStaffTimes.Click += new System.EventHandler(this.cbStatisticStaffTimes_SelectedIndexChanged);
            // 
            // txtHRStatus
            // 
            this.txtHRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHRStatus.Location = new System.Drawing.Point(575, 118);
            this.txtHRStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtHRStatus.Name = "txtHRStatus";
            this.txtHRStatus.Size = new System.Drawing.Size(146, 27);
            this.txtHRStatus.TabIndex = 61;
            // 
            // txtHRTotal
            // 
            this.txtHRTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHRTotal.Location = new System.Drawing.Point(658, 65);
            this.txtHRTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtHRTotal.Name = "txtHRTotal";
            this.txtHRTotal.Size = new System.Drawing.Size(63, 27);
            this.txtHRTotal.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Trạng thái";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(479, 21);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 31);
            this.button8.TabIndex = 41;
            this.button8.Text = "Thống kê nhân sự";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(475, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Nhân sự hiện có";
            // 
            // txtAgentId
            // 
            this.txtAgentId.Location = new System.Drawing.Point(122, 23);
            this.txtAgentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgentId.Name = "txtAgentId";
            this.txtAgentId.Size = new System.Drawing.Size(100, 27);
            this.txtAgentId.TabIndex = 20;
            this.txtAgentId.Click += new System.EventHandler(this.txtAgentId_TextChanged);
            this.txtAgentId.TextChanged += new System.EventHandler(this.txtAgentId_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã nhân viên";
            // 
            // btnAddAgent
            // 
            this.btnAddAgent.AutoSize = true;
            this.btnAddAgent.BackColor = System.Drawing.Color.Silver;
            this.btnAddAgent.Enabled = false;
            this.btnAddAgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnAddAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAgent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAgent.Image")));
            this.btnAddAgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAgent.Location = new System.Drawing.Point(267, 354);
            this.btnAddAgent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAgent.Name = "btnAddAgent";
            this.btnAddAgent.Size = new System.Drawing.Size(113, 40);
            this.btnAddAgent.TabIndex = 67;
            this.btnAddAgent.Text = "Thêm";
            this.btnAddAgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAgent.UseVisualStyleBackColor = false;
            this.btnAddAgent.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUpdateAgent
            // 
            this.btnUpdateAgent.AutoSize = true;
            this.btnUpdateAgent.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateAgent.Enabled = false;
            this.btnUpdateAgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnUpdateAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAgent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateAgent.Image")));
            this.btnUpdateAgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAgent.Location = new System.Drawing.Point(122, 354);
            this.btnUpdateAgent.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAgent.Name = "btnUpdateAgent";
            this.btnUpdateAgent.Size = new System.Drawing.Size(133, 40);
            this.btnUpdateAgent.TabIndex = 66;
            this.btnUpdateAgent.Text = "Cập nhật";
            this.btnUpdateAgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAgent.UseVisualStyleBackColor = false;
            this.btnUpdateAgent.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDelAgent
            // 
            this.btnDelAgent.AutoSize = true;
            this.btnDelAgent.BackColor = System.Drawing.Color.Silver;
            this.btnDelAgent.Enabled = false;
            this.btnDelAgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDelAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAgent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAgent.Image")));
            this.btnDelAgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelAgent.Location = new System.Drawing.Point(8, 354);
            this.btnDelAgent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelAgent.Name = "btnDelAgent";
            this.btnDelAgent.Size = new System.Drawing.Size(102, 40);
            this.btnDelAgent.TabIndex = 65;
            this.btnDelAgent.Text = "Xóa";
            this.btnDelAgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelAgent.UseVisualStyleBackColor = false;
            this.btnDelAgent.Click += new System.EventHandler(this.button5_Click);
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 525);
            this.Controls.Add(this.groupBoxInventory);
            this.Name = "HRForm";
            this.Text = "HRForm";
            this.Load += new System.EventHandler(this.HRForm_Load);
            this.groupBoxInventory.ResumeLayout(false);
            this.groupBoxInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelAgent.ResumeLayout(false);
            this.panelAgent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInventory;
        private System.Windows.Forms.Panel panelAgent;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtWorkStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAgentAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbStatisticStaffTimes;
        private System.Windows.Forms.TextBox txtHRStatus;
        private System.Windows.Forms.TextBox txtHRTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAgentId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnAddAgent;
        private System.Windows.Forms.Button btnUpdateAgent;
        private System.Windows.Forms.Button btnDelAgent;
    }
}