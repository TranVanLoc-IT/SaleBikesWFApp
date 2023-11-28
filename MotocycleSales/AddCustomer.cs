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
    public partial class AddCustomer : Form
    {
        DataFlow data = new DataFlow();
        public event Action<string> FormClosingEvent;
        public KhachHang kh = new KhachHang();

        public AddCustomer(int f)
        {
            InitializeComponent();
            if(f==1)
            {
                confirmCustomer_NextStep.Visible = false;
            }    
            else
            {
                btnAddCus.Visible = false;
                btnEditCus.Visible = false;
                btnDelCus.Visible = false;
            }    
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
        private bool ValidationCustomerInfo()
        {
            er.Clear();
            string text = txtCusId.Text;
            if (text.StartsWith("KH") && text.Length == 6)
            {
                KhachHang kh = data.FindKHById(text);
                txtCusName.Text = kh.TenKH;
                txtCusAddress.Text = kh.DiaChi;
                txtCustomerType.Text = kh.MaLoaiKhach;
                txtCusSDT.Text = kh.SoDienThoai;
            }
            else
            {
                er.SetError(txtCusId, "Sai mã khách hàng");
                return false;
            }
            foreach (var c in txtCusName.Text)
            {
                if (char.IsDigit(c) || char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    er.SetError(txtCusName, "Sai định dạng tên");
                    return false;
                }
            }
            if (txtCusSDT.Text.Length < 10)
            {
                er.SetError(txtCusSDT, "Sai định dạng số điện thoại");
                return false;
            }
            // số nhàđường,xã/phường, quận/huyện,thành phố 
            if (txtCusAddress.Text.Where(i => i == ',').Count() < 3)
            {
                er.SetError(txtCusAddress, "Thiếu thông tin địa chỉ");
                return false;
            }
            return true;
        }

        private void txtCusId_TextChanged(object sender, EventArgs e)
        {    
            string t = txtCusId.Text;
            if (t.Length < 6)
            {
                panelCusinfo.Enabled = false;
                foreach (Control control in panelCusinfo.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Text = string.Empty; // hoặc textBox.Text = "";
                    }
                }
                panelCusinfo.ResetText();
            }
            if (t.StartsWith("KH") && t.Length == 6)
            {
                var recieve = data.FindKHById(t);
                btnAddCus.Enabled = true;
                btnDelCus.Enabled = true;
                btnEditCus.Enabled = true;
                if (recieve != null)
                {
                    panelCusinfo.Enabled = false;
                    txtCusName.Text = recieve.TenKH;
                    txtCustomerType.Text = recieve.LoaiKhachHang.TenLoaiKhach;
                    txtCusSDT.Text = recieve.SoDienThoai;
                    txtCusAddress.Text = recieve.DiaChi;
                }
            }
            else
            {
                panelCusinfo.Enabled = true;
            }
        }
        private void btnAddCus_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            Button btn = sender as Button;
            string btnOption = btn.Text;
            if (btnOption == "Xóa")
            {

                if (ValidationCustomerInfo())
                {
                    kh.MaKH = txtCusId.Text;
                    kh.TenKH = txtCusName.Text;
                    kh.DiaChi = txtCusAddress.Text;
                    kh.SoDienThoai = txtCusSDT.Text;
                    kh.MaLoaiKhach = "BD";
                    bool success = data.EditCustomer(kh, "Delete");
                    if (success == true)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thât bại", "Lồi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

            }
            else if (btnOption == "Cập nhật")
            {
                if (ValidationCustomerInfo())
                {
                    kh.MaKH = txtCusId.Text;
                    kh.TenKH = txtCusName.Text;
                    kh.DiaChi = txtCusAddress.Text;
                    kh.SoDienThoai = txtCusSDT.Text;
                    kh.MaLoaiKhach = "BD";
                    bool success = data.EditCustomer(kh, "Update");
                    if (success == true)
                    {
                        MessageBox.Show("Sứa thông tin thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thât bại", "Lồi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (ValidationCustomerInfo())
                {
                    kh.MaKH = txtCusId.Text;
                    kh.TenKH = txtCusName.Text;
                    kh.DiaChi = txtCusAddress.Text;
                    kh.SoDienThoai = txtCusSDT.Text;
                    kh.MaLoaiKhach = "BD";
                    bool success = data.EditCustomer(kh, "Add");
                    if (success == true)
                    {
                        MessageBox.Show("Thành công thêm khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thât bại", "Lồi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Gọi phương thức để đóng form, truyền tên của button
            CloseForm(confirmCustomer_NextStep.Name);
        }

        private void CloseForm(string buttonName)
        {
            // Kiểm tra tên của button và gọi sự kiện tương ứng
            kh.MaKH = txtCusId.Text;
            kh.TenKH = txtCusName.Text;
            kh.DiaChi = txtCusAddress.Text;
            kh.MaLoaiKhach = txtCustomerType.Text;
            kh.SoDienThoai = txtCusSDT.Text;
            FormClosingEvent?.Invoke(buttonName);
            Close();
        }
    }
}
