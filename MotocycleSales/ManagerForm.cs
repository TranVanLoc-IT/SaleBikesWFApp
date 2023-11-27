using AngleSharp.Html.Dom;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace MotocycleSales
{
    public partial class ManagerForm : Form
    {
        private readonly QuanLy _manager;
        DataFlow data = new DataFlow();
        private DateTime _start { get; set; }
        private DateTime _end { get; set; }
        Button currentButton { get; set; }
        Form activeForm { get; set; }
        public ManagerForm(QuanLy manager)
        {
            this._manager = manager;
            InitializeComponent();

        }
        public ManagerForm()
        {
            InitializeComponent();

        }
        private void loadImageListAbout(string folderName)
        {
            string fullPath = "./Images/" + folderName + "/";
            string[] imagePaths = Directory.GetFiles(fullPath);

            imageList.ImageSize = new Size(100, 100); // Kích thước hình ảnh trong ImageList

            foreach (string imagePath in imagePaths)
            {
                using (FileStream stream = new FileStream(imagePath, FileMode.Open))
                {
                    Image image = Image.FromStream(stream);
                    imageList.Images.Add(image);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private bool ValidateBikeInfo()
        {

            return true;
        }

        private void workTimer_Tick(object sender, EventArgs e)
        {
            this._end = DateTime.Now;
            headerForm.lbTime.Text = this._end.ToString("HH:mm:ss");
        }
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            this._start = DateTime.Now;
            workTimer.Start();
            headerForm.btnCustomerServices.Text = "Nhân sự";
            headerForm.btnCustomerServices.Name = "btnHR";


            headerForm.btnBillHandle.Text = "Doanh thu";
            headerForm.btnBillHandle.Name = "btnIncome";


            headerForm.btnShowProduct.Text = "Mục Xe máy";
            headerForm.btnShowProduct.Name = "btnEditProduct";


            headerForm.btnQueryInfo.Text = "Nhập xuất hàng";
            headerForm.btnQueryInfo.Name = "btnImport";
            foreach (var control in headerForm.Controls)
            {
                if(control is Button)
                {
                    Button btn = control as Button;
                    btn.Click += Button_Click_Handler;
                }    
            }    
        }
        private void ActiveButton(object sender)
        {
            if (currentButton != null)
                currentButton.BackColor = Color.Red;
            Button btn = sender as Button;
            currentButton = btn;
            btn.BackColor = Color.Maroon;
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(childForm);
            this.Height += childForm.Height - this.mainPanel.Height;
            this.mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Button_Click_Handler(object sender, EventArgs e)
        {
            Button getButton = sender as Button;
            string buttonText = getButton.Name;
            switch (buttonText)
            {
                case "btnImport":
                    ImportProduct import = new ImportProduct(_manager);
                    OpenChildForm(import, sender);
                    break;
                case "btnPersonalInfo":
                    PersonalInfo personal = new PersonalInfo(_manager);
                    OpenChildForm(personal, sender);
                    break;
                case "btnIncome":
                    IncomeForm income = new IncomeForm(manager: _manager);
                    OpenChildForm(income, sender);
                    break;
                case "btnHR":
                    HRForm hr = new HRForm(_manager);
                    OpenChildForm(hr, sender);
                    break;
                case "btnLogout":
                    DialogResult res = MessageBox.Show("Xác nhận đăng xuất/kết ca", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.OK)
                    {
                        if ((this._end - this._start).Minutes >= 1)
                        {
                            //_manager.SoNgayLV++;
                            //data.UpdateWorkDay(_manager);
                        }
                        this.Close();
                        LoginForm login = new LoginForm();
                        login.ShowDialog();
                    }
                    break;
                case "btnEditProduct":
                    BikeSpecifications specs = new BikeSpecifications(_manager);
                    OpenChildForm(specs, sender);
                    break;

            }
        }
    }
}
