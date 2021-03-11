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
    public partial class DeleteProduct : Form
        {
        public DeleteProduct()
            {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();


            string queDP = "DELETE FROM Product_info WHERE ProductID = '" + DPtb1.Text + "' and ProductName = '" + DPtb2.Text + "'";
            SqlCommand cmdDP = new SqlCommand(queDP, con);

            SqlDataReader DP = cmdDP.ExecuteReader();
            con.Close();



            if (string.IsNullOrEmpty(DPtb2.Text))
                {
                DPlb3.Visible = true;

                }

            else
                {
                MessageBox.Show("Succesfully Deleted");
                }

            }
        }
    }
