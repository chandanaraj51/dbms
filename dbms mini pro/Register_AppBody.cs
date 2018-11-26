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
    public partial class Register_AppBody : Form
    {
        public Register_AppBody()
        {
            InitializeComponent();
        }

     

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public void refresh_DataGridView()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("ShowVacantFlat_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

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
        private void button2_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

       

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            InfoRegister_AppBody obj = new InfoRegister_AppBody();
            this.Hide();
            obj.Show();
        }
    }
}
