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
    public partial class PayForm : Form
    {
        DataFlow data = new DataFlow();
        private NhanVien _agent { get; set; }
        private Payment _pay { get; set; }
        private static KhachHang kh { get; set; }
        private static SanPham sp{ get; set; }
        Button currentButton { get; set; }
        Form activeForm { get; set; }
        public PayForm(NhanVien agent, Payment pay)
        {
            this._agent = agent;
            this._pay = pay;
            InitializeComponent();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            Btn_Step_Click_Handle(verticalBar1.btnConfirmProduct,EventArgs.Empty); 
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
            this.panelPayStep.Controls.Add(childForm);
            this.Height += childForm.Height - this.panelPayStep.Height;
            this.panelPayStep.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ChildForm_FormClosingEvent(string buttonName)
        {
            // Xử lý khi form con đóng, kiểm tra tên của button
           if(buttonName.Contains("next"))
            {
                if(buttonName.Contains("confirmProduct"))
                {
                    Btn_Step_Click_Handle(verticalBar1.btnConfirmCus, EventArgs.Empty);
                }   
                else if (buttonName.Contains("confirmCustomer"))
                {
                    Btn_Step_Click_Handle(verticalBar1.btnBillInfo, EventArgs.Empty);
                }
                else if(buttonName.Contains("Next"))
                {
                    Btn_Step_Click_Handle(verticalBar1.btnStatus, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Lỗi");
                    Btn_Step_Click_Handle(verticalBar1.btnConfirmCus, EventArgs.Empty);
                }
            }    
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Lấy giá trị trả về từ thuộc tính ReturnValue của form con
            if(sender is BikeSpecifications)
            {
                sp = (sender as BikeSpecifications).xe;
            }   
            else if(sender is AddCustomer)
            {

                kh = (sender as AddCustomer).kh;
            }
            
        }
        private void Btn_Step_Click_Handle(object sender, EventArgs e)
        {
            Button getButton = sender as Button;
            string buttonText = getButton.Name;
            switch (buttonText)
            {
                case "btnBillInfo":
                    BillConfirm bConfirm = new BillConfirm(_pay, kh, _agent);
                    OpenChildForm(bConfirm, sender);
                    bConfirm.FormClosingEvent += ChildForm_FormClosingEvent;
                    bConfirm.FormClosed += ChildForm_FormClosed;
                    break;
                case "btnConfirmCus":
                    AddCustomer customer = new AddCustomer(0);
                    OpenChildForm(customer, sender);
                    customer.FormClosingEvent += ChildForm_FormClosingEvent;
                    customer.FormClosed += ChildForm_FormClosed;
                    break;

                case "btnStatus":
                    BillStatus status = new BillStatus();
                    OpenChildForm(status, sender);
                    break;
                case "btnConfirmProduct":

                    BikeSpecifications specs = new BikeSpecifications(_agent, _pay._maxe, _pay._mausac, 0);
                    OpenChildForm(specs, sender);

                    specs.FormClosingEvent += ChildForm_FormClosingEvent;
                    specs.FormClosed += ChildForm_FormClosed;
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
