using MotocycleSales.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace MotocycleSales
{
    public partial class AgentForm : Form
    {
        private readonly NhanVien _agent;
        private DataFlow data = new DataFlow();
        private DateTime _start { get; set; }
        private DateTime _end { get; set; }
        private Button currentButton { get; set; }
        private Form activeForm { get; set; }
        static string maxe { get; set; }
        static string mausac { get; set; }
        public AgentForm(NhanVien agent)
        {
            _agent = agent;
            InitializeComponent();  
        }
        public AgentForm()
        {
            InitializeComponent();
        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            headerForm.btnLogout.Click += Button_Click_Handler;
            headerForm.btnShowProduct.Click += Button_Click_Handler;
            headerForm.btnPersonalInfo.Click += Button_Click_Handler;
            headerForm.btnBillHandle.Click += Button_Click_Handler;
            headerForm.btnQueryInfo.Click += Button_Click_Handler;
            headerForm.btnCustomerServices.Click += Button_Click_Handler;

            //headerForm.lbStore.Text += _agent.CuaHang.TenCuaHang;
            //headerForm.btnPersonalInfo.Text = _agent.TenNV;

            this._start = DateTime.Now;
            workTimer.Start();
            //
            // Khởi tạo BackgroundWorker
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Giả định công việc mất thời gian
           //btnSelect.Click += BtnSelect_Click;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Cập nhật giá trị của ProgressBar khi tiến độ thay đổi
            progressBar1.Value = e.ProgressPercentage;
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
            if(activeForm != null)
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

        private void ToDetails(object sender, EventArgs e)
        {
            BikeSpecifications specs = new BikeSpecifications(_agent, maxe, mausac, 1);
            specs.ShowDialog();
        }
        private void Button_Click_Handler(object sender, EventArgs e)
        {
            Button getButton = sender as Button;
            string buttonText = getButton.Name;
            switch (buttonText)
            {
                case "btnQueryInfo":
                    QueryForm qf = new QueryForm(_agent);
                    OpenChildForm(qf, sender);
                    break;
                case "btnPersonalInfo":
                    PersonalInfo personal = new PersonalInfo(_agent);
                    OpenChildForm(personal, sender);
                    break;
                case "btnCustomerServices":
                    AddCustomer customer = new AddCustomer(1);
                    OpenChildForm(customer, sender);
                    break;
                case "btnBillHandle":
                    ManageBill bill = new ManageBill();
                    OpenChildForm(bill, sender);
                    break;
                case "btnLogout":
                    DialogResult res = MessageBox.Show("Xác nhận đăng xuất/kết ca", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if(res == DialogResult.OK)
                    {
                        if((this._end - this._start).Minutes >= 1)
                        {
                            //_agent.SoNgayLam++;
                            //data.UpdateWorkDay(_agent.MaNV);
                        }    
                        this.Close();
                        LoginForm login = new LoginForm();
                        login.ShowDialog();
                    }    
                    break;
                case "btnShowProduct":
                    ViewProducts views = new ViewProducts(_agent);
                    OpenChildForm(views, sender);
                    break;

            }
        }

        private void workTimer_Tick(object sender, EventArgs e)
        {
            this._end = DateTime.Now;
            headerForm.lbTime.Text = this._end.ToString("HH:mm:ss");
        }
    }
}
public static class ExpandStringmethod
{
    public static string Capitalize(this string input)
    {
        string replace = "";
        replace += input[0] > 97 ? (char)(input[0] - 32) : input[0];
        for (int i = 1; i < input.Length - 1; i++)
        {

            if (input[i] == ' ' && input[i + 1] > 97)
            {
                replace += (char)(input[++i] - 32);
                continue;
            }
            if (input[i] == ' ')
            {
                continue;
            }
            replace += input[i];
        }
        return replace;
    }
    public static string VietnameseToEnglishChars(this string input)
    {
        Dictionary<char, string> convert = new Dictionary<char, string>
        {
            {'đ',"d" },
            {'á',"a" },
            {'ê',"ee" },
            {'à',"a" },
            {'ẫ',"a" },
            {'ắ',"a" },
            {'â',"a" },
            {'ỏ',"o" },
            {'ô',"o" },
            {'ẹ',"e" },
            {'í',"i" },
            {'ọ',"o" },
            {'ụ',"u" },
            {'ẻ',"e" },
            {'ế',"e" },
            {'ạ',"a" },
             {'Đ',"D" },
            {'Á',"A" },
            {'Ê',"E" },
            {'À',"A" },
            {'Ỏ',"o" },
            {'Ô',"O" },
            {'Ẹ',"E" },
            {'Í',"I" },
            {'Ọ',"O" },
            {'Ụ',"U" },
            {'Ẻ',"E" },
            {'Ế',"E" },
            {'Ạ',"A" }
            // only convert for color string
        };
        string result = "";
        foreach (char c in input)
        {
            if (convert.ContainsKey(c))
                result += convert[c];
            else
                result += c;
        }

        return result;
    }
}
