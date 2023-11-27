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
    public partial class BikeInventory : Form
    {
        DataFlow data = new DataFlow();
        private string[] filterInventory { get; set; }

        public BikeInventory()
        {
            InitializeComponent();
        }

        private void BikeInventory_Load(object sender, EventArgs e)
        {
            this.filterInventory = new string[3] { "Loại", "Màu sắc", "Tất cả" };
            cbInventory.Items.AddRange(this.filterInventory);
        }
        private void txtInventoryBikeCode_TextChanged(object sender, EventArgs e)
        {
            // refresh for new product
            string slt = txtInventoryBikeCode.Text;
            var selectedProduct = new SanPham();
            if (slt.Length == 5)
            {
                selectedProduct = this.data.TakeProductSelect(slt);
            }
            if (selectedProduct == null && slt.Length == 5)
            {
                MessageBox.Show("Không có xe này");
                txtInventoryBikeCode.Text = "";
                return;
            }
            if (slt.Length == 5)
            {
                dataGridViewInventory.DataSource = this.data.GetInventoryInfomationByBike(selectedProduct.MaXe, selectedProduct.TenXe);
            }
            return;
        }

        private void cbInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kiểm kê theo mã cửa hàng
            string selectedInventoryOption = cbInventory.GetItemText(cbInventory.SelectedItem);
            if (selectedInventoryOption.CompareTo("Loại") == 0)
            {
                if (string.IsNullOrEmpty(txtInventoryBikeCode.Text))
                {
                    er.SetError(txtInventoryBikeCode, "Không được để trống");
                    return;
                }
                er.Clear();
                dataGridViewInventory.DataSource = this.data.GetInventoryInfomationByType(txtInventoryBikeCode.Text);
            }
            else if (selectedInventoryOption.CompareTo("Tất cả") == 0)
            {
                dataGridViewInventory.DataSource = this.data.GetInventoryAll();
            }
        }


    }
}
