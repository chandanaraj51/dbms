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
    public partial class Admin_Appbody : Form

    {
        public const int WM_NCLBUTTON = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int
            SendMessage(IntPtr hwnd, int Msg, int wParam, int IParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Admin_Appbody()
        {
            InitializeComponent();
        }
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
       
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Appbody_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!ContentPanel2.Controls.Contains(Admin_Tenant_UserControl1.Instance))
            {
                ContentPanel2.Controls.Add(Admin_Tenant_UserControl1.Instance);
                Admin_Tenant_UserControl1.Instance.Dock = DockStyle.Fill;
                Admin_Tenant_UserControl1.Instance.BringToFront();
            }
            else
            {
                Admin_Tenant_UserControl1.Instance.BringToFront();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ContentPanel2.Controls.Contains(Admin_Vacant_UserControl1.Instance))
            {
                ContentPanel2.Controls.Add(Admin_Vacant_UserControl1.Instance);
                Admin_Vacant_UserControl1.Instance.Dock = DockStyle.Fill;
                Admin_Vacant_UserControl1.Instance.BringToFront();
            }
            else
            {
                Admin_Vacant_UserControl1.Instance.BringToFront();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!ContentPanel2.Controls.Contains(Admin_Parking_UserControl1.Instance))
            {
                ContentPanel2.Controls.Add(Admin_Parking_UserControl1.Instance);
                Admin_Parking_UserControl1.Instance.Dock = DockStyle.Fill;
                Admin_Parking_UserControl1.Instance.BringToFront();
            }
            else
            {
                Admin_Parking_UserControl1.Instance.BringToFront();
            }
        }

        private void ContentPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            MainAppBody obj = new MainAppBody();
            this.Hide();
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTON, HT_CAPTION, 0);
            }
        }
    }
}
