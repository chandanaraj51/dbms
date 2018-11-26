using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms_mini_pro
{
    public partial class Owner_AppBody : Form
    {
        public Owner_AppBody()
        {
            InitializeComponent();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            MainAppBody obj = new MainAppBody();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Owner_ProblemsInfo_UserControl1.Instance))
            {
                ContentPanel.Controls.Add(Owner_ProblemsInfo_UserControl1.Instance);
                Owner_ProblemsInfo_UserControl1.Instance.Dock = DockStyle.Fill;
                Owner_ProblemsInfo_UserControl1.Instance.BringToFront();
            }
            else
            {
                Owner_ProblemsInfo_UserControl1.Instance.BringToFront();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Owner_ViewVacantFlats_UserControl1.Instance))
            {
                ContentPanel.Controls.Add(Owner_ViewVacantFlats_UserControl1.Instance);
                Owner_ViewVacantFlats_UserControl1.Instance.Dock = DockStyle.Fill;
                Owner_ViewVacantFlats_UserControl1.Instance.BringToFront();
            }
            else
            {
                Owner_ViewVacantFlats_UserControl1.Instance.BringToFront();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Owner_RentDue_UserControl1.Instance))
            {
                ContentPanel.Controls.Add(Owner_RentDue_UserControl1.Instance);
                Owner_RentDue_UserControl1.Instance.Dock = DockStyle.Fill;
                Owner_RentDue_UserControl1.Instance.BringToFront();
            }
            else
            {
                Owner_RentDue_UserControl1.Instance.BringToFront();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Owner_ViewRegister_UserControl1.Instance))
            {
                ContentPanel.Controls.Add(Owner_ViewRegister_UserControl1.Instance);
                Owner_ViewRegister_UserControl1.Instance.Dock = DockStyle.Fill;
                Owner_ViewRegister_UserControl1.Instance.BringToFront();
            }
            else
            {
                Owner_ViewRegister_UserControl1.Instance.BringToFront();

            }
        }
    }
}
