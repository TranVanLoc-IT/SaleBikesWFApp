
namespace MotocycleSales
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBoxSlogan = new System.Windows.Forms.PictureBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.choiceUserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlogan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.btnLogin);
            this.groupBoxLogin.Controls.Add(this.pictureBoxSlogan);
            this.groupBoxLogin.Controls.Add(this.labelPass);
            this.groupBoxLogin.Controls.Add(this.txtUserId);
            this.groupBoxLogin.Controls.Add(this.labelUser);
            this.groupBoxLogin.Controls.Add(this.txtPasswordLogin);
            this.groupBoxLogin.Controls.Add(this.choiceUserType);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.groupBoxLogin.Location = new System.Drawing.Point(251, 131);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(493, 188);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Đăng nhập";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(293, 125);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 52);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBoxSlogan
            // 
            this.pictureBoxSlogan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSlogan.BackgroundImage")));
            this.pictureBoxSlogan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSlogan.Location = new System.Drawing.Point(311, 26);
            this.pictureBoxSlogan.Name = "pictureBoxSlogan";
            this.pictureBoxSlogan.Size = new System.Drawing.Size(155, 32);
            this.pictureBoxSlogan.TabIndex = 1;
            this.pictureBoxSlogan.TabStop = false;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPass.Location = new System.Drawing.Point(50, 192);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(126, 22);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "Nhập mật khẩu";
            this.labelPass.Visible = false;
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtUserId.Location = new System.Drawing.Point(248, 125);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(193, 30);
            this.txtUserId.TabIndex = 6;
            this.txtUserId.Visible = false;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelUser.Location = new System.Drawing.Point(50, 133);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(171, 22);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "Nhập mã nhân viên: ";
            this.labelUser.Visible = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPasswordLogin.Location = new System.Drawing.Point(205, 184);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(193, 30);
            this.txtPasswordLogin.TabIndex = 4;
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            this.txtPasswordLogin.Visible = false;
            this.txtPasswordLogin.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // choiceUserType
            // 
            this.choiceUserType.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.choiceUserType.FormattingEnabled = true;
            this.choiceUserType.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.choiceUserType.Location = new System.Drawing.Point(248, 75);
            this.choiceUserType.Name = "choiceUserType";
            this.choiceUserType.Size = new System.Drawing.Size(157, 30);
            this.choiceUserType.TabIndex = 1;
            this.choiceUserType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn đối tượng: ";
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1056, 546);
            this.Controls.Add(this.groupBoxLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "MotoCycle Sales";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlogan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox choiceUserType;
        private System.Windows.Forms.PictureBox pictureBoxSlogan;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
    }
}

