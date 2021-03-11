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
    public partial class Stock : Form
        {
        public Stock()
            {
            InitializeComponent();
            }

        private void UpdateCashier_Click(object sender, EventArgs e)
            {
            CashierUpdate cu = new CashierUpdate();
            cu.Show();
            }

        private void CashierDelete_Click(object sender, EventArgs e)
            {
            DeleteCashier dc = new DeleteCashier();
            dc.Show();
            }

        private void ProductNew_Click(object sender, EventArgs e)
            {
            NewProduct np = new NewProduct();
            np.Show();
            }

        private void ProductUpdate_Click(object sender, EventArgs e)
            {
            UpdateProduct up = new UpdateProduct();
            up.Show();
            }

        private void ProductDelete_Click(object sender, EventArgs e)
            {
            DeleteProduct DP = new DeleteProduct();
            DP.Show();
            }

        private void ProfitCheck_Click(object sender, EventArgs e)
            {
            CheckProfit cp = new CheckProfit();
            cp.Show();
            }

        private void Supply_Click(object sender, EventArgs e)
            {
            Supplier sp = new Supplier();
            sp.Show();
            }

        private void button8_Click(object sender, EventArgs e)
            {
            QuickProduct qp = new QuickProduct();
            qp.Show();
            }
        }
    }
