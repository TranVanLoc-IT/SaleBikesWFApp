
namespace MotocycleSales
{
    partial class BikeInventory
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxInventory = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSendReport = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbInventory = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInventoryBikeCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.er = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInventory
            // 
            this.groupBoxInventory.Controls.Add(this.button1);
            this.groupBoxInventory.Controls.Add(this.btnSendReport);
            this.groupBoxInventory.Controls.Add(this.richTextBox1);
            this.groupBoxInventory.Controls.Add(this.cbInventory);
            this.groupBoxInventory.Controls.Add(this.label16);
            this.groupBoxInventory.Controls.Add(this.txtInventoryBikeCode);
            this.groupBoxInventory.Controls.Add(this.label5);
            this.groupBoxInventory.Controls.Add(this.dataGridViewInventory);
            this.groupBoxInventory.Enabled = false;
            this.groupBoxInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInventory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxInventory.Location = new System.Drawing.Point(72, 60);
            this.groupBoxInventory.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInventory.Name = "groupBoxInventory";
            this.groupBoxInventory.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInventory.Size = new System.Drawing.Size(854, 415);
            this.groupBoxInventory.TabIndex = 53;
            this.groupBoxInventory.TabStop = false;
            this.groupBoxInventory.Text = "Kiểm kê hàng hóa";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(584, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 31);
            this.button1.TabIndex = 34;
            this.button1.Text = "Nhập hàng gấp";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSendReport
            // 
            this.btnSendReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSendReport.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSendReport.Location = new System.Drawing.Point(584, 291);
            this.btnSendReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendReport.Name = "btnSendReport";
            this.btnSendReport.Size = new System.Drawing.Size(98, 31);
            this.btnSendReport.TabIndex = 33;
            this.btnSendReport.Text = "Báo cáo";
            this.btnSendReport.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(39, 293);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(528, 94);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // cbInventory
            // 
            this.cbInventory.FormattingEnabled = true;
            this.cbInventory.Location = new System.Drawing.Point(356, 245);
            this.cbInventory.Margin = new System.Windows.Forms.Padding(4);
            this.cbInventory.Name = "cbInventory";
            this.cbInventory.Size = new System.Drawing.Size(166, 30);
            this.cbInventory.TabIndex = 27;
            this.cbInventory.SelectedIndexChanged += new System.EventHandler(this.cbInventory_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label16.Location = new System.Drawing.Point(223, 253);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Số lượng theo: ";
            // 
            // txtInventoryBikeCode
            // 
            this.txtInventoryBikeCode.Location = new System.Drawing.Point(105, 249);
            this.txtInventoryBikeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtInventoryBikeCode.Name = "txtInventoryBikeCode";
            this.txtInventoryBikeCode.Size = new System.Drawing.Size(100, 28);
            this.txtInventoryBikeCode.TabIndex = 20;
            this.txtInventoryBikeCode.TextChanged += new System.EventHandler(this.txtInventoryBikeCode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(43, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mã xe";
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(8, 21);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(838, 186);
            this.dataGridViewInventory.TabIndex = 0;
            // 
            // er
            // 
            this.er.ContainerControl = this;
            // 
            // BikeInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 529);
            this.Controls.Add(this.groupBoxInventory);
            this.Name = "BikeInventory";
            this.Text = "BikeInventory";
            this.Load += new System.EventHandler(this.BikeInventory_Load);
            this.groupBoxInventory.ResumeLayout(false);
            this.groupBoxInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInventory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSendReport;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbInventory;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtInventoryBikeCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.ErrorProvider er;
    }
}