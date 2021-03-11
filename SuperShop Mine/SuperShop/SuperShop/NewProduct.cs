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
    public partial class NewProduct : Form
        {
        public NewProduct()
            {
            InitializeComponent();
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
            {
            //creating a totally new product

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();


            string queNP = "INSERT INTO Product_info (ProductID, ProductName, Quantity, BuyingUnitPrice, SellingUnitPrice, PerUnitProfit) values ('" + NPtb1.Text + "' , '" + NPtb2.Text + "' , '" + NPtb3.Text + "' , '" + NPtb4.Text + "' , '" + NPtb5.Text + "' , '" + NPtb6.Text + "')";
            SqlCommand cmdNP = new SqlCommand(queNP, con);

            SqlDataReader SdCu = cmdNP.ExecuteReader();
            con.Close();

            MessageBox.Show("New Product Added");
            }
        }
    }
