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
    public partial class Admin_Parking_UserControl1 : UserControl
    {
        private static Admin_Parking_UserControl1 _instance;
        public static Admin_Parking_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Admin_Parking_UserControl1();
                }



                return _instance;
            }
        }
        public Admin_Parking_UserControl1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");


        public void refresh_DataGridView()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("ShowParkingInfo_SP", con);
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

        private void Admin_Parking_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddVehicle_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            refresh_DataGridView();

            cmd.Parameters.AddWithValue("@T_id", T_idtextBox.Text);

            cmd.Parameters.AddWithValue("@No_of_2wheelers", No_of_2wheelers_textBox.Text);


            cmd.Parameters.AddWithValue("@No_of_cars", No_of_carstextBox.Text);

          


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
            refresh_DataGridView();
           
        }

        private void DeleteVehicleButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteParking_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@T_id", T_idtextBox.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<<INVALID SQL OPERATION:" + ex);
                }
                con.Close();
                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

       

        private void SearchTuppleButton_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SearchParking_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@T_id", T_idSearch_textBox.Text);

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
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            T_idtextBox.Text = "";
            No_of_2wheelers_textBox.Text = "";
            No_of_carstextBox.Text = "";
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
    

}
