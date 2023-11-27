
namespace MotocycleSales
{
    partial class ViewProducts
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
            this.flowLayoutHotBikes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutAllBikes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutHotBikes
            // 
            this.flowLayoutHotBikes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutHotBikes.AutoScroll = true;
            this.flowLayoutHotBikes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutHotBikes.Location = new System.Drawing.Point(12, 34);
            this.flowLayoutHotBikes.Name = "flowLayoutHotBikes";
            this.flowLayoutHotBikes.Size = new System.Drawing.Size(1279, 358);
            this.flowLayoutHotBikes.TabIndex = 0;
            this.flowLayoutHotBikes.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dòng xe đang bán chạy";
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Xe tay côn",
            "Xe mô tô",
            "Xe số",
            "Xe tay ga"});
            this.cbFilter.Location = new System.Drawing.Point(182, 400);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(152, 27);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn dòng xe";
            // 
            // flowLayoutAllBikes
            // 
            this.flowLayoutAllBikes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutAllBikes.AutoScroll = true;
            this.flowLayoutAllBikes.AutoScrollMinSize = new System.Drawing.Size(1279, 358);
            this.flowLayoutAllBikes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutAllBikes.Location = new System.Drawing.Point(12, 435);
            this.flowLayoutAllBikes.Name = "flowLayoutAllBikes";
            this.flowLayoutAllBikes.Size = new System.Drawing.Size(1279, 358);
            this.flowLayoutAllBikes.TabIndex = 5;
            this.flowLayoutAllBikes.WrapContents = false;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1292, 797);
            this.Controls.Add(this.flowLayoutAllBikes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutHotBikes);
            this.Name = "ViewProducts";
            this.Text = "ViewProducts";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutHotBikes;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbFilter;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutAllBikes;
    }
}