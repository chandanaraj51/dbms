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

    public partial class Tenant_ReportProblem_UserControl1 : UserControl
    {
        private static Tenant_ReportProblem_UserControl1 _instance;

        public static Tenant_ReportProblem_UserControl1 Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new Tenant_ReportProblem_UserControl1();
                }
                return _instance;

            }
        }
        public Tenant_ReportProblem_UserControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ReportProblem_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@T_id", T_idtextBox.Text);
            cmd.Parameters.AddWithValue("@Complaint", textBox1.Text);

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
           



        }
    }
}
