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
    public partial class Supplier : Form
        {
        public Supplier()
            {
            InitializeComponent();
            }

        private void label2_Click(object sender, EventArgs e)
            {

            }

        private void label4_Click(object sender, EventArgs e)
            {

            }

        private void label5_Click(object sender, EventArgs e)
            {

            }

        private void label6_Click(object sender, EventArgs e)
            {

            }

        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void label7_Click(object sender, EventArgs e)
            {

            }

        private void label8_Click(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
            {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();

            string query = "select * from Date_info where Id = '" + Stb1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);


            SqlDataReader Sdata = cmd.ExecuteReader();

            if (Sdata.Read())
                {
                string sup = (Sdata["Supplier"].ToString());
                string date = (Sdata["BuyDate"].ToString());
                string qn = (Sdata["BQuan"].ToString());

               Slb2.Text = sup.ToString();
               Slb3.Text = qn.ToString();
               Slb4.Text = date.ToString();

                }
            con.Close();
            }

        private void Supplier_Load(object sender, EventArgs e)
            {

            }
        }
    }
