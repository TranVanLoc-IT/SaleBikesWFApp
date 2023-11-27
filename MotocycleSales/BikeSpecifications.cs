using MotocycleSales.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotocycleSales
{
    public partial class BikeSpecifications : Form
    {
        NhanVien _agent { get; set; }
        DataFlow data = new DataFlow();
        public SanPham xe = new SanPham();
        public event Action<string> FormClosingEvent;
        public BikeSpecifications(QuanLy quanly)
        {
            InitializeComponent();
            // manager
            cbEditProduct.Visible = true;
            label2.Visible = true;
            btnSelectImg.Visible = true;
            btnFr.Visible = true;
        }
        public BikeSpecifications(NhanVien agent, string mx, string color, int f)
        {
            InitializeComponent();

            if(f == 1)
            {
                confirmProduct_NextStep.Visible = true;
            }
            else
            {
                btnPay.Visible = true;
                btnBack.Visible = true;
            }
            this._agent = agent;
            var gets = data.db.SanPhams.Where(itm => itm.MaXe == mx).ToList();
            var getColors = data.db.SanPhams.Where(itm => itm.MaXe == mx).Select(itm => itm.MauSac).ToList();
            for(int i=0;i<gets.Count;i++)
            {
                if(getColors[i].VietnameseToEnglishChars().Capitalize() == color)
                {
                    xe = gets[i];
                    break;
                }    
            }
            comboBoxColors.Items.AddRange(getColors.ToArray());
        }

        private void BikeSpecifications_Load(object sender, EventArgs e)
        {
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;

            flowLayoutPanelBike.AutoScroll = true;
            flowLayoutPanelBike.WrapContents = false;
            flowLayoutPanelBike.Dock = DockStyle.Fill; // Đặt Fill để FlowLayoutPanel lấp đầy toàn bộ kích thước của parent container
            confirmProduct_NextStep.Click += NextButton_Click;

            txtMaxe.Text = xe.MaXe;
            txtTenXe.Text = xe.TenXe;
            txtTypeName.Text = xe.LoaiSP.TenLoai;
            txtQuantity.Text = "1";
            string priceStr = ((double)xe.GiaBan).ToString("N2");
            txtPrice.Text = priceStr.Substring(0, priceStr.Length - 2);

        }
        private void txtMaxe_change(object sender, EventArgs e)
        {
            btnPay.Enabled = true;

            if (imageList.Images != null)
            {
                imageList.Images.Clear();
                comboBoxColors.Items.Clear();
                flowLayoutPanelBike.Controls.Clear();
            }
            ImagePath path = new ImagePath();
            path._folder = "../../Images/Sanpham/";
            imageList.ImageSize = new Size(210, 150);
            foreach (var img in path.collectAllImagePath())
            {
                if (img.Contains(xe.TenXe.Substring(0, xe.TenXe.IndexOf(' '))))
                {
                    if (img.Contains("Air") && !txtTenXe.Text.Contains("Air"))
                    {
                        continue;
                    }
                    using (FileStream stream = new FileStream("../../Images/Sanpham/" + img, FileMode.Open))
                    {
                        Image image = Image.FromStream(stream);
                        imageList.Images.Add(image);
                    }
                }

            }

            flowLayoutPanelBike.Controls.AddRange(imageList.Images.OfType<Image>().Select(image =>
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.CenterImage, // Để hình ảnh lấp đầy PictureBox
                    Size = new Size(280, 230), // Kích thước hiển thị của PictureBox
                };
                return pictureBox;
            }).ToArray());

            // specifications info
            var read = File.ReadAllText("../../ProductDataHD.json");
            List<BikeSpecification> specs = JsonConvert.DeserializeObject<List<BikeSpecification>>(read);
            var ofBike = specs.Where(itm => itm._maloai == txtMaxe.Text.Substring(0, 4)).FirstOrDefault();
            if (ofBike != null)
            {
                txtPower.Text = ofBike._congsuat;
                txtSaddleHeight.Text = ofBike._chieucaoyen;
                txtSize.Text = ofBike._kichthuoc;
                txtTire.Text = ofBike._kichthuoclop;
                txtEngine.Text = ofBike._dongco;
                txtWeight.Text = ofBike._khoiluong;
                txtFuelCapacity.Text = ofBike._dungtichxang;
            }
            MessageBox.Show(xe.MauSac.VietnameseToEnglishChars().Capitalize() + "vaicalon");
            UpdateShowImageBike(xe.MauSac.VietnameseToEnglishChars().Capitalize());
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay._maxe = txtMaxe.Text;
            pay._mausac = comboBoxColors.GetItemText(comboBoxColors.SelectedItem);
            pay._sl = 1;
            pay._giaban = double.Parse(txtPrice.Text);
            pay._tenxe = txtTenXe.Text;
            PayForm pf = new PayForm(_agent, pay);
            pf.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }


        private void UpdateShowImageBike(string selectedColor)
        {
            char[] collectCapitalChars = selectedColor.Where(c => c < 97 && c >= 65).ToArray();
            flowLayoutPanelBike.Controls.Clear();
            imageList.Images.Clear();

            ImagePath path = new ImagePath();
            path._folder = "../../Images/Sanpham/";
            imageList.ImageSize = new Size(210, 150);
            string collectImage = "";
            foreach (var img in path.collectAllImagePath())
            {
                // vì Blade trùng AirBalde nên cho điều kiện riêng 
                // lấy chuỗi đầu của db so sánh chuỗi img có chứa tên xe và màu đã xử lý chuỗi
                MessageBox.Show(xe.TenXe);
                if (img.Contains(selectedColor) && img.Contains(xe.TenXe.Substring(0, xe.TenXe.IndexOf(' '))))
                {
                    if (img.Contains("Air") && !txtTenXe.Text.Contains("Air"))
                    {
                        continue;
                    }
                    collectImage = img;
                    break;
                }

            }
            using (FileStream stream = new FileStream("../../Images/Sanpham/" + collectImage, FileMode.Open))
            {
                Image image = Image.FromStream(stream);
                imageList.Images.Add(image);
            }
            flowLayoutPanelBike.Controls.AddRange(imageList.Images.OfType<Image>().Select(image =>
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.StretchImage, // Để hình ảnh lấp đầy PictureBox
                    Size = new Size(285, 230), // Kích thước hiển thị của PictureBox
                };
                return pictureBox;
            }).ToArray());



        }

        private void cbStore2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int options = comboBoxColors.SelectedIndex;
            SanPham sp = new SanPham();
            if (ValidateBikeInfo())
            {
                sp.TenXe = txtTenXe.Text;
                sp.MaXe = txtMaxe.Text;
                sp.GiaBan = decimal.Parse(txtPrice.Text);
                sp.MauSac = txtMauSac.Text;
                sp.MaLX = txtTypeName.Text.ToLower().Contains("tay ga") ? "HDTG" : txtTypeName.Text.ToLower().Contains("tay côn") ? "HDTC" : "HDXS";
            }
            switch (options)
            {
                case 0:
                    if (data.EditProduct(sp, "Add"))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo");
                    }
                    break;
                case 1:
                    if (data.EditProduct(sp, "Update"))
                    {
                        MessageBox.Show("Sửa sản phẩm thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm thất bại", "Thông báo");
                    }
                    break;
                case 2:
                    if (data.EditProduct(sp, "Delete"))
                    {
                        MessageBox.Show("Xóa sản phẩm thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo");
                    }
                    break;
                default:

                    break;
            }

        }

        private bool ValidateBikeInfo()
        {
            throw new NotImplementedException();
        }

        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateShowImageBike(comboBoxColors.GetItemText(comboBoxColors.SelectedItem).VietnameseToEnglishChars().Capitalize());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Gọi phương thức để đóng form, truyền tên của button
            CloseForm(confirmProduct_NextStep.Name);
        }

        private void CloseForm(string buttonName)
        {
            // Kiểm tra tên của button và gọi sự kiện tương ứng
            FormClosingEvent?.Invoke(buttonName);
            Close();
        }

        private void btnFr_Click(object sender, EventArgs e)
        {

        }
    }
}
