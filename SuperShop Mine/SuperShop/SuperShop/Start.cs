﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop
    {
    public partial class Start : Form
        {
        public Start()
            {
            InitializeComponent();
            }

        private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
            { 
            CashierPass cp = new CashierPass();
            cp.Show();
      
            }

        private void Start_Load(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
            {
            OwnerPass op = new OwnerPass();
            op.Show();
            }
        }
    }
