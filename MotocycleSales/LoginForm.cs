using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotocycleSales
{
    public partial class LoginForm : Form
    {
        private DataFlow data = new DataFlow();
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Enabled = false;
            btnLogin.Location = new Point(312, 133);
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (choiceUserType.SelectedItem == null)
            {
                return;
            }
            switch (choiceUserType.SelectedItem.ToString())
            {
                case "Khách Hàng":
                    labelUser.Text = "Nhập mã Khách Hàng";
                    break;
                case "Nhân Viên":
                    labelUser.Text = "Nhập mã Nhân Viên";
                    break;
                case "Quản Lý":
                    labelUser.Text = "Nhập mã Quản Lý";
                    break;
            }
            groupBoxLogin.Size = new Size(577, 306);
            pictureBoxSlogan.Location = new Point(406, 25);
            btnLogin.Location = new Point(391, 234);
            labelUser.Visible = true;
            txtUserId.Visible = true;
            labelPass.Visible = true;
            txtPasswordLogin.Visible = true;
        }
        private bool detectError()
        {
            if (txtPasswordLogin.Text.Length < 8)
            {
                errorProviderLogin.SetError(txtPasswordLogin, "Mật khẩu quá ngắn");
                btnLogin.Enabled = false;
                return true;
            }
            errorProviderLogin.Clear();
            return false;
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

            if (txtPasswordLogin.Text == null || txtUserId.Text == null || detectError())
            {
                btnLogin.Enabled = false;
                return;
            }
            btnLogin.Enabled = true;
            return;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();
            if(choiceUserType.SelectedIndex == 0)
            {
                NhanVien agentAccessing = data.VaLidCompanyAgent(txtUserId.Text, txtPasswordLogin.Text);
                if (agentAccessing != null)
                {
                    AgentForm aForm = new AgentForm(agentAccessing);
                    errorProviderLogin.Clear();
                    this.Visible = false;
                    aForm.Show();
                }
                else
                {
                    errorProviderLogin.SetError(txtUserId, "Sai mã nhân viên, vui lòng nhập đúng!!");
                }
            }    
            else if(choiceUserType.SelectedIndex == 1)
            {
                QuanLy managerAccessing = data.VaLidCompanyManager(txtUserId.Text, txtPasswordLogin.Text);
                if (managerAccessing != null)
                {
                    ManagerForm aForm = new ManagerForm(managerAccessing);
                    errorProviderLogin.Clear();
                    this.Visible = false;
                    aForm.Show();
                }
                {
                    errorProviderLogin.SetError(txtUserId, "Sai mã quản lý, vui lòng nhập đúng!!");
                }
            }
            else
            {

                errorProviderLogin.SetError(btnLogin, "Sai thông tin, vui lòng nhập đúng!!");
            }    
        }
    }
}
