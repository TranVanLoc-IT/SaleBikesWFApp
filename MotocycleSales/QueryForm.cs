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

    public partial class QueryForm : Form
    {
        DataFlow data = new DataFlow();
        NhanVien nv { get; set; }
        QuanLy quanly { get; set; }
        private string[] filterSearch { get; set; }
        public QueryForm(object user)
        {
            InitializeComponent();
            if(user is NhanVien)
            {
                this.nv = (nv as NhanVien);
            }
            else
            {
                this.quanly = (user as QuanLy);
            }
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            dataGridQLBX.DataSource = data.GetAllMotocycles();
            dataGridQLBX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridQLBX.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridQLBX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //labelTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridQLBX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridQLBX.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            switch (cbTableOptions.SelectedIndex)
            {
                case 0:
                    dataGridQLBX.DataSource = data.GetAllMotocycles();
                    break;
                case 1:
                    dataGridQLBX.DataSource = data.GetAllCustomer();
                    break;
                case 2:
                    dataGridQLBX.DataSource = data.GetAllBills().Where(itm => itm.MaNV == nv.MaNV);
                    break;
            }    
        }




        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            int indexSltBar = cbTableOptions.SelectedIndex;
            if (indexSltBar == 1)
            {
                this.filterSearch = new string[6] { "Tăng theo giá bán", "Giảm theo giá bán", "Tăng theo số lượng", "Giảm theo số lượng", "Loại xe", "Mã xe" };
                cbFilter.Items.AddRange(this.filterSearch);
                cbFilter.SelectedIndex = 5;
                List<ProductDTO> productInView = dataGridQLBX.DataSource as List<ProductDTO>;
                var singleItemSearch = productInView.Where(item => item._maXe == txtSearch.Text);
                if (singleItemSearch == null)
                {
                    MessageBox.Show("Không có xe này");
                    txtSearch.Text = "";
                    return;
                }
                dataGridQLBX.Refresh();
                dataGridQLBX.DataSource = singleItemSearch.ToList();
                txtNumberResultSearch.Text = singleItemSearch.Count().ToString();
            }
            if (indexSltBar == 2)
            {
                this.filterSearch = new string[0];
                List<KhachHang> productInView = dataGridQLBX.DataSource as List<KhachHang>;
                var singleItemSearch = productInView.Where(item => item.MaKH == txtSearch.Text);
                if (singleItemSearch == null)
                {
                    MessageBox.Show("Không có khách hàng này");
                    txtSearch.Text = "";
                    return;
                }
                dataGridQLBX.Refresh();
                dataGridQLBX.DataSource = singleItemSearch.ToList();
                txtNumberResultSearch.Text = singleItemSearch.Count().ToString();
            }

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSltSort = cbFilter.SelectedIndex;
            switch (indexSltSort)
            {
                case 0:

                    dataGridQLBX.Sort(dataGridQLBX.Columns["_giaban"], ListSortDirection.Ascending);
                    break;
                case 1:

                    dataGridQLBX.Sort(dataGridQLBX.Columns["_giaban"], ListSortDirection.Descending);
                    break;
                case 2:

                    dataGridQLBX.Sort(dataGridQLBX.Columns["_soLuongCon"], ListSortDirection.Ascending);
                    break;
                case 3:

                    dataGridQLBX.Sort(dataGridQLBX.Columns["_soLuongCon"], ListSortDirection.Descending);
                    break;
                case 4:

                    List<ProductDTO> productInView = dataGridQLBX.DataSource as List<ProductDTO>;
                    var singleItemSearch = productInView.Where(item => item._maLoaiXe == txtSearch.Text.Substring(0, 4));
                    if (singleItemSearch != null)
                    {
                        dataGridQLBX.DataSource = singleItemSearch.ToList();
                    }
                    MessageBox.Show("Sai thông tin tìm kiếm", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtSearch.Text = "";
                    txtNumberResultSearch.Text = singleItemSearch.Count().ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
