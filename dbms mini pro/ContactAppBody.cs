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
    public partial class ContactAppBody : Form
    {
        public ContactAppBody()
        {
            InitializeComponent();
        }

        private void ContactAppBody_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainAppBody obj = new MainAppBody();
            this.Hide();
            obj.Show();
        }
    }
}
