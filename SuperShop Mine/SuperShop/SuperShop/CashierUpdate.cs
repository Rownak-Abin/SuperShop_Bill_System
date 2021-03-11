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
    public partial class CashierUpdate : Form
        {
        public CashierUpdate()
            {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();


            string queCU = "INSERT INTO C_pass (Name, Mobile, Password) values ('"+ CUtb1.Text +"' , '"+ CUtb2.Text +"' , '"+ CUtb3.Text +"')";
            SqlCommand cmdCU = new SqlCommand(queCU, con);

            SqlDataReader SdCu = cmdCU.ExecuteReader();
            con.Close();

            MessageBox.Show("Succesfull");

           
            }
        }
    }
