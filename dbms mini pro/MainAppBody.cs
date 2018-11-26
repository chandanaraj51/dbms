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
    public partial class MainAppBody : Form
    {
        public MainAppBody()
        {
            InitializeComponent();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void TenantButton_Click(object sender, EventArgs e)
        {
            Tenant_AppBody obj = new Tenant_AppBody();
            this.Hide();
            obj.Show();
        }

        private void OthersButton_Click(object sender, EventArgs e)
        {
            Register_AppBody obj = new Register_AppBody();
            this.Hide();
            obj.Show();

        }

        private void MainAppBody_Load(object sender, EventArgs e)
        {

        }

        private void OwnerLoginButton_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.Show();
        }
    }
}
