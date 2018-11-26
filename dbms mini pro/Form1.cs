using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbms_mini_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private String getusername()
        {
            //fetch data from database
            con.Open();
            String syntax = "SELECT value FROM Admin where Property='username'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
            
        }
        private String getpassword()
        {
            //fetch data from database
            con.Open();
            String syntax = "SELECT value FROM Admin where Property='password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            String uname=getusername(), upass=getpassword(), name, pwd;
            name = textBox1.Text;
            pwd = textBox2.Text;
            if(name.Equals(uname)&&pwd.Equals(upass))
            {
                //login


                Admin_Appbody obj = new Admin_Appbody();
                this.Hide();
                obj.Show();
            }
            else
            {
                //dont login
                MessageBox.Show("LOGIN FAILED");

                
            }

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
           Register_AppBody obj = new Register_AppBody();
            this.Hide();
            obj.Show();
        }
    }
}
