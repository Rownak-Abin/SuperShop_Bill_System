namespace SuperShop
    {
    partial class DeleteProduct
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DPtb1 = new System.Windows.Forms.TextBox();
            this.DPtb2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DPlb3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(104, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(62, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Product Name";
            // 
            // DPtb1
            // 
            this.DPtb1.Location = new System.Drawing.Point(285, 104);
            this.DPtb1.Multiline = true;
            this.DPtb1.Name = "DPtb1";
            this.DPtb1.Size = new System.Drawing.Size(181, 31);
            this.DPtb1.TabIndex = 35;
            // 
            // DPtb2
            // 
            this.DPtb2.Location = new System.Drawing.Point(285, 187);
            this.DPtb2.Multiline = true;
            this.DPtb2.Name = "DPtb2";
            this.DPtb2.Size = new System.Drawing.Size(181, 31);
            this.DPtb2.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(219, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 37;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DPlb3
            // 
            this.DPlb3.AutoSize = true;
            this.DPlb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPlb3.ForeColor = System.Drawing.Color.Yellow;
            this.DPlb3.Location = new System.Drawing.Point(176, 361);
            this.DPlb3.Name = "DPlb3";
            this.DPlb3.Size = new System.Drawing.Size(218, 25);
            this.DPlb3.TabIndex = 38;
            this.DPlb3.Text = "Name can not be empty";
            this.DPlb3.Visible = false;
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(605, 434);
            this.Controls.Add(this.DPlb3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DPtb2);
            this.Controls.Add(this.DPtb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "DeleteProduct";
            this.Text = "DeleteProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DPtb1;
        private System.Windows.Forms.TextBox DPtb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DPlb3;
        }
    }