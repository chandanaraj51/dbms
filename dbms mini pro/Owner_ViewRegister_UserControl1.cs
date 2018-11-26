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
    public partial class Owner_ViewRegister_UserControl1 : UserControl
    {
        private static Owner_ViewRegister_UserControl1 _instance;
        public static Owner_ViewRegister_UserControl1 Instance
        {


            get
            {
                if (_instance == null)
                {
                    _instance = new Owner_ViewRegister_UserControl1();
                }



                return _instance;

            }
        }
        public Owner_ViewRegister_UserControl1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");

        public void refresh_DataGridView()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("ShowRegisterInfo_SP", con);
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

        private void Owner_ViewRegister_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }

   
}
