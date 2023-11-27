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
    public partial class PersonalInfo : Form
    {
        object _user { get; set; }
        DataFlow db = new DataFlow();
        NhanVien _agent { get; set; }
        QuanLy _manager { get; set; }
        public PersonalInfo(object user)
        {
            InitializeComponent();
            _user = user;
            if(user is NhanVien)
            {
                this._agent = (user as NhanVien);
            }    
            else
            {
                this._manager = (user as QuanLy);
                label7.Text = "Mã quản lý: ";
            }    
        }

        private void txtAgentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbPassword.Enabled = true;
            gbInfo.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if(this._agent !=null)
            {
                if (!string.IsNullOrEmpty(txtOldPass.Text) && !string.IsNullOrEmpty(txtNewPass.Text))
                {

                        if (txtOldPass.Text == _agent.Password)
                        {
                            _agent.Password = txtNewPass.Text;
                            flag = true;
                        }
                    } 
                if (!string.IsNullOrEmpty(txtUserAddress.Text))
                {
                    _agent.DiaChi = txtUserAddress.Text;
                    flag = true;
                }
                if (!flag) return;
                if (db.UpdateInfo(_agent))
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                else
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                gbInfo.Enabled = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(txtOldPass.Text) && !string.IsNullOrEmpty(txtNewPass.Text))
                {

                    if (txtOldPass.Text == _agent.Password)
                    {
                        _manager.Password = txtNewPass.Text;
                        flag = true;
                    }
                }
                if (!string.IsNullOrEmpty(txtUserAddress.Text))
                {
                    _manager.DiaChi = txtUserAddress.Text;
                    flag = true;
                }
                if (!flag) return;
                if (db.UpdateInfo(_agent))
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                else
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                gbInfo.Enabled = false;
            }
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {

        }

        private void changeInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtUserAddress.Enabled = true;
            gbInfo.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtUserAddress.Enabled || gbPassword.Enabled)
            {
                DialogResult res = MessageBox.Show("Bạn có muốn thoát khi chưa lưu?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                if(res == DialogResult.Yes)
                {
                    this.Close();
                }    
            }    
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbPassword.Enabled = false;
            txtUserAddress.Enabled = false;
        }
    }
}
