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
using Tulpep.NotificationWindow;




namespace SuperShop
    {
    public partial class Bill : Form
        {
        public Bill()
            {
            InitializeComponent();
            }
        int TBill = 0;
        public int count = 0;
        public double prfitCount = 0;
        // double ttProfit = 0;
         

        private void button1_Click(object sender, EventArgs e)
            {
          //add button substracting quantity from DB and passing data to listview...

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            con.Open();


            string que = "UPDATE Product_info SET Quantity = Quantity-'" + Btb2.Text + "' WHERE ProductID = '" + Btb1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(que, con);

            SqlDataReader ghj = cmd2.ExecuteReader();
            con.Close();

            con.Open();
            string query = "select * from Product_info where ProductID = '" + Btb1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);


            SqlDataReader br2 = cmd.ExecuteReader();

            if (br2.Read())
                {
                string[] arr = new string[5];
                arr[0] = Btb1.Text;
                arr[1] = (br2["ProductName"].ToString());
                arr[2] = Btb2.Text;
                arr[3] = (br2["SellingUnitPrice"].ToString());

               

                int x = Int32.Parse(arr[3]);
                int y = Int32.Parse(arr[2]);
                int z = x * y;

                string str = Convert.ToString(z);
                arr[4] = str;
                int p = Int32.Parse(arr[4]);



                ListViewItem lvi = new ListViewItem(arr);

                listView1.Items.Add(lvi);

                TBill = TBill + p;

                Btb3.Text = "       " + TBill.ToString();

                BlbPN.Text = "     " + (br2["ProductName"].ToString());

                
                
                string npq = (br2["Quantity"].ToString());
                int npquan = Int32.Parse(npq);

                if (npquan < 10) {

                    //notification pop up box Code
                PopupNotifier pop = new PopupNotifier();
                pop.TitleText = "Storage Empty";
                pop.ContentText = BlbPN.Text + " is remaining under 10";
                pop.Popup();

         
                    }



                }
            Btb1.Text = "";
           Btb2.Text = "";
                    

            con.Close();
            

            }

        private void Bill_Load(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
            {
            //removing item from Listview also adding the substracted amount to db

            if (listView1.SelectedItems.Count > 0)
                {
                for (int i = 0; i < listView1.Items.Count; i++)
                    {
                    if (listView1.Items[i].Selected)
                        {
                        Btb3.Text = "        " + (Convert.ToInt16(Btb3.Text) - Convert.ToInt16(listView1.Items[i].SubItems[4].Text)).ToString();

                        string a = Convert.ToInt16(listView1.Items[i].SubItems[2].Text).ToString();
                        string b = Convert.ToInt16(listView1.Items[i].SubItems[0].Text).ToString();


                        // tb3.Text = a.ToString();

                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
                        con.Open();
                        string que2 = "UPDATE Product_info SET Quantity = Quantity+'" + a + "' WHERE ProductID = '" + b + "'";
                        SqlCommand cmd3 = new SqlCommand(que2, con);

                        SqlDataReader sdf = cmd3.ExecuteReader();
                        con.Close();

                        listView1.Items[i].Remove();
                        TBill = Int32.Parse(Btb3.Text);


                        }


                    }
                }


            }

        private void button4_Click(object sender, EventArgs e)
            {// getting changed amount, also showing profit....


            for (int i = 0; i < listView1.Items.Count; i++)
                { 


                string pro = Convert.ToInt16(listView1.Items[i].SubItems[0].Text).ToString();


                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
                conn.Open();
                string queryProf = "select PerUnitProfit  from Product_info where ProductID = '" + pro + "'";
                SqlCommand cmdProf = new SqlCommand(queryProf, conn);
                SqlDataReader drProf = cmdProf.ExecuteReader();
                if (drProf.Read())
                    {
                    string Lq = Convert.ToInt16(listView1.Items[i].SubItems[2].Text).ToString();
                    int quan = Int32.Parse(Lq);
                    double profit = Convert.ToDouble((drProf["PerUnitProfit"].ToString()));
                    double ttProfit = profit * quan;
                    prfitCount += ttProfit;
                    string tProfit = Convert.ToString(prfitCount);
                    txtProf.Text = tProfit.ToString();



                    conn.Close();

                    }

                }

            int a = Int32.Parse(Btb4.Text);
            int b = Int32.Parse(Btb3.Text);

            Btb5.Text = (a - b).ToString();

            string date = dtp1.Value.ToString();

           // Dtb.Text = dtp1.Value.ToString();

           // string db = DateTime.Now.ToString();

          /*  SqlConnection conn2 = new SqlConnection(@"Data Source=DESKTOP-69AVR5I\SQLEXPRESS;Initial Catalog=Super;Integrated Security=True");
            conn2.Open();
            int cProcount = Convert.ToInt16(prfitCount);
            string querystr = "UPDATE ProTab SET pro= pro+'" + cProcount + "' WHERE date= '" + date + "'";
            SqlCommand cmdstr = new SqlCommand(querystr, conn2);
            SqlDataReader drstr = cmdstr.ExecuteReader();

            conn2.Close();
            */

           

            }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
            {
            this.Close();
            
            }

        private void button3_Click(object sender, EventArgs e)
            {
            
           
         
            }

        }

    }
    
