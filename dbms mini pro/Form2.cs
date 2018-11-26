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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = "2", upass = "2", name, pwd;
            name = textBox1.Text;
            pwd = textBox2.Text;
            if (name.Equals(uname) && pwd.Equals(upass))
            {
                //login


                Owner_AppBody obj = new Owner_AppBody();
                this.Hide();
                obj.Show();
            }
            else
            {
                //dont login
                MessageBox.Show("LOGIN FAILED");


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
