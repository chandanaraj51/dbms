using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace dbms_mini_pro
{
    public partial class Tenant_AppBody : Form
    {
        public Tenant_AppBody()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainAppBody obj = new MainAppBody();
            this.Hide();
            obj.Show();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

      

      

        private void Tenant_AppBody_Load(object sender, EventArgs e)
        {

        }

       

       

        private void ReportProblemButton_Click_1(object sender, EventArgs e)
        {
            if(!ContentPanel.Controls.Contains(Tenant_ReportProblem_UserControl1.Instance))
            {
                ContentPanel.Controls.Add(Tenant_ReportProblem_UserControl1.Instance);
                Tenant_ReportProblem_UserControl1.Instance.Dock = DockStyle.Fill;
                Tenant_ReportProblem_UserControl1.Instance.BringToFront();
            }
            else
            {
                Tenant_ReportProblem_UserControl1.Instance.BringToFront();
            }
        }

        private void PayBillButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Tenant_PayBillUser_Control1.Instance))
            {
                ContentPanel.Controls.Add(Tenant_PayBillUser_Control1.Instance);
                Tenant_PayBillUser_Control1.Instance.Dock = DockStyle.Fill;
                Tenant_PayBillUser_Control1.Instance.BringToFront();
            }
            else
            {
                Tenant_PayBillUser_Control1.Instance.BringToFront();
            }
        }
    }
}
