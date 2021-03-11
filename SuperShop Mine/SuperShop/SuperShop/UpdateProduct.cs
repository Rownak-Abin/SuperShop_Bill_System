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
    public partial class UpdateProduct : Form
        {
        public UpdateProduct()
            {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
            {  
            //updating Date_info table
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con2.Open();


            string que2 = "UPDATE Date_info SET Supplier = '"+ UPtb6.Text +"' , BuyDate = '" + dtp1.Text + "', ExpairyDate = '"+ dtp2.Text +"' , BQuan = '"+ UPtb7.Text +"' WHERE Id = '"+ UPtb1.Text +"' ";
            SqlCommand cmd3 = new SqlCommand(que2, con2);

            SqlDataReader gh = cmd3.ExecuteReader();
            con2.Close();
            MessageBox.Show("Successfully Updated");



            }


        private void button2_Click(object sender, EventArgs e)
            {
            //updating product quantity

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();


            string que = "UPDATE Product_info SET Quantity = Quantity+'" + UPtb2.Text + "' WHERE ProductID = '" + UPtb1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(que, con);

            SqlDataReader ghj = cmd2.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully Updated");
            }


        private void button3_Click(object sender, EventArgs e)
            {
            //updating Product_info table

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();


            string que = "UPDATE Product_info SET  BuyingUnitPrice= '" + UPtb3.Text + "', SellingUnitPrice" +
                "= '" + UPtb4.Text + "', PerUnitProfit = '" + UPtb5.Text + "' WHERE ProductID = '" + UPtb1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(que, con);

            SqlDataReader ghj = cmd2.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully Updated");

            }
        }
    }
