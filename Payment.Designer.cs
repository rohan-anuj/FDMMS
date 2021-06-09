namespace WindowsFormsApplication10
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Invoiceno = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.SId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Print = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Search_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label12 = new System.Windows.Forms.Label();
            this.Balance = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.Paid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.sub_total = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewBalance = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fullpaid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1314, 701);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.bunifuThinButton21);
            this.bunifuCards2.Controls.Add(this.Invoiceno);
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.Controls.Add(this.SId);
            this.bunifuCards2.Controls.Add(this.label1);
            this.bunifuCards2.Controls.Add(this.Print);
            this.bunifuCards2.Controls.Add(this.Search_button);
            this.bunifuCards2.Controls.Add(this.label4);
            this.bunifuCards2.Controls.Add(this.NewBalance);
            this.bunifuCards2.Controls.Add(this.label5);
            this.bunifuCards2.Controls.Add(this.Fullpaid);
            this.bunifuCards2.Controls.Add(this.label12);
            this.bunifuCards2.Controls.Add(this.Balance);
            this.bunifuCards2.Controls.Add(this.label11);
            this.bunifuCards2.Controls.Add(this.Paid);
            this.bunifuCards2.Controls.Add(this.label9);
            this.bunifuCards2.Controls.Add(this.sub_total);
            this.bunifuCards2.Controls.Add(this.SName);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1314, 701);
            this.bunifuCards2.TabIndex = 1;
            this.bunifuCards2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards2_Paint);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Save";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.Location = new System.Drawing.Point(406, 543);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(142, 59);
            this.bunifuThinButton21.TabIndex = 41;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Invoiceno
            // 
            this.Invoiceno.BorderColor = System.Drawing.Color.SeaGreen;
            this.Invoiceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoiceno.ForeColor = System.Drawing.Color.Fuchsia;
            this.Invoiceno.Location = new System.Drawing.Point(160, 144);
            this.Invoiceno.Name = "Invoiceno";
            this.Invoiceno.Size = new System.Drawing.Size(170, 34);
            this.Invoiceno.TabIndex = 40;
            this.Invoiceno.TextChanged += new System.EventHandler(this.Invoiceno_TextChanged);
            this.Invoiceno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Invoiceno_Keypress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(15, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "EnterInvoice:";
            // 
            // SId
            // 
            this.SId.BorderColor = System.Drawing.Color.SeaGreen;
            this.SId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SId.ForeColor = System.Drawing.Color.Fuchsia;
            this.SId.Location = new System.Drawing.Point(161, 202);
            this.SId.Name = "SId";
            this.SId.Size = new System.Drawing.Size(96, 28);
            this.SId.TabIndex = 38;
            this.SId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SId_keypress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(72, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "SId:";
            // 
            // Print
            // 
            this.Print.ActiveBorderThickness = 1;
            this.Print.ActiveCornerRadius = 20;
            this.Print.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.Print.ActiveForecolor = System.Drawing.Color.White;
            this.Print.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.Print.BackColor = System.Drawing.Color.White;
            this.Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print.BackgroundImage")));
            this.Print.ButtonText = "Print";
            this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.Color.Fuchsia;
            this.Print.IdleBorderThickness = 1;
            this.Print.IdleCornerRadius = 20;
            this.Print.IdleFillColor = System.Drawing.Color.White;
            this.Print.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.Print.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.Print.Location = new System.Drawing.Point(586, 543);
            this.Print.Margin = new System.Windows.Forms.Padding(5);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(127, 59);
            this.Print.TabIndex = 36;
            this.Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Search_button
            // 
            this.Search_button.ActiveBorderThickness = 1;
            this.Search_button.ActiveCornerRadius = 20;
            this.Search_button.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.Search_button.ActiveForecolor = System.Drawing.Color.White;
            this.Search_button.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.Search_button.BackColor = System.Drawing.Color.White;
            this.Search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_button.BackgroundImage")));
            this.Search_button.ButtonText = "Search";
            this.Search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.Color.Fuchsia;
            this.Search_button.IdleBorderThickness = 1;
            this.Search_button.IdleCornerRadius = 20;
            this.Search_button.IdleFillColor = System.Drawing.Color.White;
            this.Search_button.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.Search_button.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.Search_button.Location = new System.Drawing.Point(207, 543);
            this.Search_button.Margin = new System.Windows.Forms.Padding(5);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(142, 59);
            this.Search_button.TabIndex = 35;
            this.Search_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Fuchsia;
            this.label12.Location = new System.Drawing.Point(338, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Balance:";
            // 
            // Balance
            // 
            this.Balance.BorderColor = System.Drawing.Color.SeaGreen;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.ForeColor = System.Drawing.Color.Fuchsia;
            this.Balance.Location = new System.Drawing.Point(449, 359);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(99, 28);
            this.Balance.TabIndex = 22;
            this.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Balance_Keypress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Fuchsia;
            this.label11.Location = new System.Drawing.Point(338, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Paid:";
            // 
            // Paid
            // 
            this.Paid.BorderColor = System.Drawing.Color.SeaGreen;
            this.Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paid.ForeColor = System.Drawing.Color.Fuchsia;
            this.Paid.Location = new System.Drawing.Point(449, 325);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(99, 28);
            this.Paid.TabIndex = 20;
            this.Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Paid_Keypress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Fuchsia;
            this.label9.Location = new System.Drawing.Point(338, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "SubTotal:";
            // 
            // sub_total
            // 
            this.sub_total.BorderColor = System.Drawing.Color.SeaGreen;
            this.sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_total.ForeColor = System.Drawing.Color.Fuchsia;
            this.sub_total.Location = new System.Drawing.Point(449, 291);
            this.sub_total.Name = "sub_total";
            this.sub_total.Size = new System.Drawing.Size(96, 28);
            this.sub_total.TabIndex = 12;
            this.sub_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sub_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sub_Total);
            // 
            // SName
            // 
            this.SName.BorderColor = System.Drawing.Color.SeaGreen;
            this.SName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName.ForeColor = System.Drawing.Color.Fuchsia;
            this.SName.Location = new System.Drawing.Point(446, 144);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(170, 34);
            this.SName.TabIndex = 4;
            this.SName.TextChanged += new System.EventHandler(this.SName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(357, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // NewBalance
            // 
            this.NewBalance.BorderColor = System.Drawing.Color.SeaGreen;
            this.NewBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBalance.ForeColor = System.Drawing.Color.Fuchsia;
            this.NewBalance.Location = new System.Drawing.Point(449, 435);
            this.NewBalance.Name = "NewBalance";
            this.NewBalance.Size = new System.Drawing.Size(99, 28);
            this.NewBalance.TabIndex = 22;
            this.NewBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewBalance.TextChanged += new System.EventHandler(this.NewBalance_TextChanged);
            this.NewBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewBalance_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(297, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "BalanceAmt:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Fullpaid
            // 
            this.Fullpaid.BorderColor = System.Drawing.Color.SeaGreen;
            this.Fullpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullpaid.ForeColor = System.Drawing.Color.Fuchsia;
            this.Fullpaid.Location = new System.Drawing.Point(449, 395);
            this.Fullpaid.Name = "Fullpaid";
            this.Fullpaid.Size = new System.Drawing.Size(99, 28);
            this.Fullpaid.TabIndex = 22;
            this.Fullpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fullpaid.TextChanged += new System.EventHandler(this.Fullpaid_TextChanged);
            this.Fullpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullPaid_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Fuchsia;
            this.label5.Location = new System.Drawing.Point(288, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Full Payment:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1314, 701);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.Text = "Payment";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Invoiceno;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SId;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 Print;
        private Bunifu.Framework.UI.BunifuThinButton2 Search_button;
        private System.Windows.Forms.Label label12;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Balance;
        private System.Windows.Forms.Label label11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Paid;
        private System.Windows.Forms.Label label9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox sub_total;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SName;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox NewBalance;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Fullpaid;
    }
}