namespace SuperShop
    {
    partial class DeleteCashier
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
            this.button1 = new System.Windows.Forms.Button();
            this.DCtb1 = new System.Windows.Forms.TextBox();
            this.DCtb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DClb3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(199, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DCtb1
            // 
            this.DCtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCtb1.Location = new System.Drawing.Point(258, 104);
            this.DCtb1.Multiline = true;
            this.DCtb1.Name = "DCtb1";
            this.DCtb1.Size = new System.Drawing.Size(181, 31);
            this.DCtb1.TabIndex = 17;
            // 
            // DCtb2
            // 
            this.DCtb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCtb2.Location = new System.Drawing.Point(258, 205);
            this.DCtb2.Multiline = true;
            this.DCtb2.Name = "DCtb2";
            this.DCtb2.Size = new System.Drawing.Size(181, 31);
            this.DCtb2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(89, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mobile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(98, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // DClb3
            // 
            this.DClb3.AutoSize = true;
            this.DClb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DClb3.ForeColor = System.Drawing.Color.Yellow;
            this.DClb3.Location = new System.Drawing.Point(149, 372);
            this.DClb3.Name = "DClb3";
            this.DClb3.Size = new System.Drawing.Size(224, 25);
            this.DClb3.TabIndex = 20;
            this.DClb3.Text = "Mobile can not be empty";
            this.DClb3.Visible = false;
            // 
            // DeleteCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(541, 443);
            this.Controls.Add(this.DClb3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DCtb1);
            this.Controls.Add(this.DCtb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "DeleteCashier";
            this.Text = "DeleteCashier";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DCtb1;
        private System.Windows.Forms.TextBox DCtb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DClb3;
        }
    }