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
    public partial class QuickProduct : Form
        {
        public QuickProduct()
            {
            InitializeComponent();
            }

        private void QPlb2_Click(object sender, EventArgs e)
            {

            }

        private void QuickProduct_Load(object sender, EventArgs e)
            {

            }

        private void button5_Click(object sender, EventArgs e)
            {
            //showing product details

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();

            string query = "select * from Product_info where ProductID = '" + QPtb1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);


            SqlDataReader br2 = cmd.ExecuteReader();

            if (br2.Read())
                {
                string pn = (br2["ProductName"].ToString());
                string cqn = (br2["Quantity"].ToString());
                string bup = (br2["BuyingUnitPrice"].ToString());
                string sup = (br2["SellingUnitPrice"].ToString());
                string pup = (br2["PerUnitProfit"].ToString());

                QPlb1.Text = "    " + pn.ToString();
                QPlb10.Text = cqn.ToString();
                QPlb13.Text = bup.ToString();
                QPlb14.Text = sup.ToString();
                QPlb17.Text = pup.ToString();
                }
            con.Close();


            con.Open();

            string query2 = "select * from Date_info where Id= '" + QPtb1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);


            SqlDataReader ip = cmd2.ExecuteReader();

            if (ip.Read())
                {


                string lbd = (ip["BuyDate"].ToString());
                string lbq = (ip["BQuan"].ToString());
                string ed = (ip["ExpairyDate"].ToString());
                string spl = (ip["Supplier"].ToString());

              

                QPlb11.Text = lbd.ToString();
                QPlb12.Text = lbq.ToString();
                QPlb15.Text = ed.ToString();
                QPlb16.Text = spl.ToString();

                }

            con.Close();
            }
        }
    }
