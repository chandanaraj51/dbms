using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbms_mini_pro
{
    public partial class Tenant_PayBillUser_Control1 : UserControl
    {
        private static Tenant_PayBillUser_Control1 _instance;

        public static Tenant_PayBillUser_Control1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tenant_PayBillUser_Control1();
                }
                return _instance;

            }
        }
        public Tenant_PayBillUser_Control1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

        public void refresh_DataGridView()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("CheckRentStatus_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@T_id", textBox1.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("     INVALID SQL OPERATION:\n" + ex);
                }
                con.Close();


                dataGridView1.DataSource = DS.Tables[0];



                
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }
}
