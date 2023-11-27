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
    public partial class HRForm : Form
    {
        DataFlow data = new DataFlow();
        QuanLy quanly { get; set; }
        public HRForm(QuanLy ql)
        {
            InitializeComponent();
            quanly = ql;
        }

        private void HRForm_Load(object sender, EventArgs e)
        {

            groupBoxInventory.Enabled = true;
            cbStore.Items.AddRange(data.GetAllStores());

            cbStore.ValueMember = "_mach";
            cbStore.DisplayMember = "_tench";
        }

        private void txtAgentId_TextChanged(object sender, EventArgs e)
        {
            string text = txtAgentId.Text;
            if (text.StartsWith("NV") && text.Length == 6)
            {
                NhanVien nv = data.FindNVById(text);
                if (nv != null)
                {
                    panelAgent.Enabled = false;
                    txtAgentName.Text = nv.TenNV;
                    txtWorkStatus.Text = nv.TinhTrang == true ? "Đang làm việc" : "Nghỉ làm";
                    txtAgentAddress.Text = nv.DiaChi;
                    dobPicker.Value = nv.NgaySinh ?? DateTime.Now;
                    foreach (var item in cbStore.Items)
                    {
                        // Kiểm tra giá trị của ValueMember và so sánh với điều kiện
                        if (cbStore.ValueMember != null)
                        {
                            var propertyInfo = item.GetType().GetProperty(cbStore.ValueMember);
                            if (propertyInfo != null)
                            {
                                var value = propertyInfo.GetValue(item)?.ToString();
                                if (value == nv.MaCuaHang)
                                {
                                    // Đặt SelectedIndex nếu tìm thấy giá trị phù hợp
                                    cbStore.SelectedItem = item;
                                    return;
                                }
                            }
                        }
                    }
                }
                else
                {
                    panelAgent.Enabled = true;
                }
            }
        }

        private bool ValidateAgentInfo()
        {

            return true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string text = btn.Text;
            bool isSuccess = true;
            NhanVien nv = new NhanVien();
            if (ValidateAgentInfo())
            {
                nv.TenNV = txtAgentName.Text;
                nv.MaNV = txtAgentName.Text;
                nv.MaCuaHang = cbStore.GetItemText(cbStore.SelectedItem);
                nv.Password = "nhanvien1234";
                nv.NgaySinh = dobPicker.Value;
            }
            else
            {
                return;
            }
            switch (text)
            {
                case "Thêm":
                    isSuccess = data.EditAgent(nv, "Add");
                    break;
                case "Xóa":
                    isSuccess = data.EditAgent(nv, "Add");

                    break;
                case "Sửa":
                    isSuccess = data.EditAgent(nv, "Add");

                    break;
            }
            if (isSuccess)
            {
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo");
            }
            else
                MessageBox.Show("Chỉnh sửa thất bại", "Thông báo");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // thêm vào option thống kê theo năm
            var options = (from itm in data.GetAllStaff()
                           select new { _value = itm.NamVL, _text = "Năm " + itm.NamVL.ToString() }).Distinct();

            cbStatisticStaffTimes.Items.AddRange(options.ToArray());
            cbStatisticStaffTimes.DisplayMember = "_text";
            cbStatisticStaffTimes.ValueMember = "_value";

            var getAllStaff = data.GetAllStaff();
            txtHRTotal.Text = getAllStaff.Where(itm => itm.TinhTrang == true).Count().ToString();
            txtHRStatus.Text = getAllStaff.Where(itm => itm.TinhTrang == true).Count() < 5 ? "Bổ sung nhân sự" : "Ổn định";
        }

        private void cbStatisticStaffTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int changes = data.GetAllStaff().Where(itm => itm.NamVL == int.Parse(cbStatisticStaffTimes.SelectedValue.ToString()) && itm.TinhTrang == true).Count();
            txtHRTotal.Text = changes.ToString();
            txtHRStatus.Text = changes < 5 ? "Bổ sung nhân sự" : "Ổn định";
        }

    }
}
