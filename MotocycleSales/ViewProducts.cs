using MotocycleSales.Class;
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
    public partial class ViewProducts : Form
    {
        DataFlow data = new DataFlow();
        NhanVien nv = new NhanVien();
        static string maxe { get; set; }
        static string mausac { get; set; }
        private static List<BikeCard> allBikes { get; set; } = new List<BikeCard>();
        public ViewProducts(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
        }
        private void LoadHotBikes()
        {
            var getHotSales = data.GetHotBikes();
            Console.WriteLine(getHotSales.Count);

            foreach (var itm in getHotSales)
            {
                BikeCard card = new BikeCard();
                ImagePath path = new ImagePath();
                path._folder = "../../Images/Sanpham/";
                foreach (var img in path.collectAllImagePath())
                {
                    if (img.Contains(itm.MauSac.VietnameseToEnglishChars().Capitalize()) && img.Contains(itm.TenXe.Substring(0, itm.TenXe.IndexOf(' '))))
                    {
                        if (img.Contains("Air") && !itm.TenXe.Contains("Air"))
                        {
                            continue;
                        }
                        using (FileStream stream = new FileStream("../../Images/Sanpham/" + img, FileMode.Open))
                        {
                            Image image = Image.FromStream(stream);
                            card.bikePicture.Image = image;
                            card.btnViewProduct.Name = "btn_" + itm.MaXe +'_' + itm.MauSac.VietnameseToEnglishChars().Capitalize();
                            break;
                        }
                    }

                }
                card.txtBikeName.Text = itm.TenXe + " - " + itm.MauSac;
                card.txtPrice.Text = itm.GiaBan.ToString();
                card.btnViewProduct.Click += ToDetails;
                flowLayoutHotBikes.Controls.Add(card);
            }
        }
        private void LoadAllBikes()
        {
            var getBikes = data.GetAllMotocycles();
            foreach (var itm in getBikes)
            {
                BikeCard card = new BikeCard();
                ImagePath path = new ImagePath();
                path._folder = "../../Images/Sanpham/";
                foreach (var img in path.collectAllImagePath())
                {
                    if (img.Contains(itm._mauXe.VietnameseToEnglishChars().Capitalize()) && img.Contains(itm._tenXe.Substring(0, itm._tenXe.IndexOf(' '))))
                    {
                        if (img.Contains("Air") && !itm._tenXe.Contains("Air"))
                        {
                            continue;
                        }
                        using (FileStream stream = new FileStream("../../Images/Sanpham/" + img, FileMode.Open))
                        {
                            Image image = Image.FromStream(stream);
                            card.bikePicture.Image = image;
                            break;
                        }
                    }

                }
                card.txtBikeName.Text = itm._tenXe + " - " + itm._mauXe;
                card.txtPrice.Text = itm._giaban.ToString();
                allBikes.Add(card);

                flowLayoutAllBikes.Controls.Add(card);
            }
        }
        private void ViewProducts_Load(object sender, EventArgs e)
        {
            LoadHotBikes();
            LoadAllBikes();
        }
        private void Button_Select_Product(object sender, EventArgs e)
        {

        }

        private void ToDetails(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] cpns = btn.Name.Split('_');
            BikeSpecifications specs = new BikeSpecifications(nv,cpns[1], cpns[2], 1);
            specs.ShowDialog();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFilter.SelectedIndex;
            List<BikeCard> newListCard = new List<BikeCard>();
            if(index == 0 )
            {
                // tay côn
                foreach(var control in allBikes)
                {
                    BikeCard card = control as BikeCard;
                    if(card.txtBikeName.Text.Contains("Winner") || card.txtBikeName.Text.Contains("CBR"))
                    {
                        newListCard.Add(card);
                    }    
                }    
            }    
            else if(index == 1)
            {
                // mô tô
                foreach (var control in allBikes)
                {
                    BikeCard card = control as BikeCard;
                    if (card.txtBikeName.Text.Contains("CBR"))
                    {
                        newListCard.Add(card);
                    }
                }
            }
            else if(index == 2)
            {
                // số
                foreach (var control in allBikes)
                {
                    BikeCard card = control as BikeCard;
                    if (card.txtBikeName.Text.Contains("Wave") || card.txtBikeName.Text.Contains("Blade"))
                    {
                        newListCard.Add(card);
                    }
                }
            }
            else
            {
                foreach (var control in allBikes)
                {
                    BikeCard card = control as BikeCard;
                    if (card.txtBikeName.Text.Contains("AirBlade") || card.txtBikeName.Text.Contains("Vision") || card.txtBikeName.Text.Contains("SH"))
                    {
                        newListCard.Add(card);
                    }
                }
            }
            flowLayoutAllBikes.Controls.Clear();
            flowLayoutAllBikes.Controls.AddRange(newListCard.ToArray());
        }
    }
}
