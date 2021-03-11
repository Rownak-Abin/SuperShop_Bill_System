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

namespace SuperShop
    {
    public partial class DeleteCashier : Form
        {
        public DeleteCashier()
            {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();


            string queDU = "DELETE FROM C_pass WHERE Name = '" + DCtb1.Text + "' and Mobile = '" + DCtb2.Text + "'";
            SqlCommand cmdDU = new SqlCommand(queDU, con);

            SqlDataReader SdCu = cmdDU.ExecuteReader();
            con.Close();

            if (string.IsNullOrEmpty(DCtb2.Text))
              {
              DClb3.Visible = true;
                
              }

          else{
            MessageBox.Show("Succesfully Deleted");
             }

        

            }
        }
    }
