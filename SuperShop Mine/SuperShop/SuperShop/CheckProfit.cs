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
    public partial class CheckProfit : Form
        {
        public CheckProfit()
            {
            InitializeComponent();
            }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
            {
            string queryProf = "select * from ProfitTable Where Date = GETDATE()";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            conn.Open();

            SqlCommand cmdProf = new SqlCommand(queryProf, conn);
            SqlDataReader drProf = cmdProf.ExecuteReader();
            if (drProf.Read())
                {
                string[] prof = new string[1];
                //prof[0] = Btb2.Text;
                //double quantity = Convert.ToDouble(prof[0]);
                double profit = Convert.ToDouble((drProf["Profit"].ToString()));
                //double ttProfit = profit * quantity;
                //prfitCount -= ttProfit;
                string tProfit = Convert.ToString(profit);
                //txtProf.Text = tProfit;
                MessageBox.Show("Todays Total Profit is" + tProfit);
                }
            }
        }
    }