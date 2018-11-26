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
    public partial class InfoRegister_AppBody : Form
    {
        public InfoRegister_AppBody()
        {
            InitializeComponent();
        }

        private void InfoRegister_AppBody_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("RegisterInfo_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FullName",NametextBox .Text);

           
            cmd.Parameters.AddWithValue("@Phone",PhonetextBox .Text);

            cmd.Parameters.AddWithValue("@Email_id",Email_id_textBox.Text);

            cmd.Parameters.AddWithValue("@City",CitytextBox.Text);

            cmd.Parameters.AddWithValue("@No_of_BHK", No_of_BHKtextBox.Text);

            cmd.Parameters.AddWithValue("@No_of_vehicles", No_of_vehiclestextBox.Text);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("       <<< INVALID SQL OPERATION:\n" + ex);
            }

            con.Close();

            ContactAppBody obj = new ContactAppBody();
            this.Hide();
            obj.Show();

            
            
        }
    }
}
