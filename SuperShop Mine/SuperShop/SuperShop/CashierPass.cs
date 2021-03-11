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
    public partial class CashierPass : Form
        {
        public CashierPass()
            {
            InitializeComponent();
            }

        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
            {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            string query = "select * from C_pass where Name = '" + Ctb1.Text.Trim() + "' and Password = '" + Ctb2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dbt1 = new DataTable();
            sda.Fill(dbt1);
            if (dbt1.Rows.Count == 1)
            { 
                Bill b= new Bill();
                b.Show();
                 this.Close();
                
                }

            else{
            label4.Visible = true;
                }

        
            
                }
           

            }
        }
    
