namespace WindowsFormsApplication10
{
    partial class Invoice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.label2 = new System.Windows.Forms.Label();
            this.SName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.SId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cmb_fish = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Price = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Total = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.sub_total = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Quantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddItem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Paid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.Balance = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.Remove = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Save_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(227, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SName
            // 
            this.SName.BorderColor = System.Drawing.Color.SeaGreen;
            this.SName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName.ForeColor = System.Drawing.Color.Fuchsia;
            this.SName.Location = new System.Drawing.Point(298, 60);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(185, 34);
            this.SName.TabIndex = 4;
            this.SName.TextChanged += new System.EventHandler(this.SName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(37, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "SId:";
            // 
            // SId
            // 
            this.SId.BorderColor = System.Drawing.Color.SeaGreen;
            this.SId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SId.ForeColor = System.Drawing.Color.Fuchsia;
            this.SId.Location = new System.Drawing.Point(95, 60);
            this.SId.Name = "SId";
            this.SId.Size = new System.Drawing.Size(126, 34);
            this.SId.TabIndex = 7;
            this.SId.TextChanged += new System.EventHandler(this.SId_TextChanged);
            this.SId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SId_KeyPress);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Fuchsia;
            this.listView1.Location = new System.Drawing.Point(86, 209);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(718, 292);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fishes";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // Cmb_fish
            // 
            this.Cmb_fish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_fish.FormattingEnabled = true;
            this.Cmb_fish.Location = new System.Drawing.Point(296, 167);
            this.Cmb_fish.Name = "Cmb_fish";
            this.Cmb_fish.Size = new System.Drawing.Size(236, 37);
            this.Cmb_fish.TabIndex = 10;
            this.Cmb_fish.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Fuchsia;
            this.label10.Location = new System.Drawing.Point(158, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Select Fish:";
            // 
            // Price
            // 
            this.Price.BorderColor = System.Drawing.Color.SeaGreen;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.Fuchsia;
            this.Price.Location = new System.Drawing.Point(825, 271);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(126, 28);
            this.Price.TabIndex = 12;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // Total
            // 
            this.Total.BorderColor = System.Drawing.Color.SeaGreen;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.Fuchsia;
            this.Total.Location = new System.Drawing.Point(827, 433);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(131, 28);
            this.Total.TabIndex = 12;
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total.TextChanged += new System.EventHandler(this.bunifuCustomTextbox6_TextChanged);
            this.Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Total_KeyPress);
            // 
            // sub_total
            // 
            this.sub_total.BorderColor = System.Drawing.Color.SeaGreen;
            this.sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_total.ForeColor = System.Drawing.Color.Fuchsia;
            this.sub_total.Location = new System.Drawing.Point(769, 513);
            this.sub_total.Name = "sub_total";
            this.sub_total.Size = new System.Drawing.Size(96, 28);
            this.sub_total.TabIndex = 12;
            this.sub_total.Text = "0";
            this.sub_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sub_total.TextChanged += new System.EventHandler(this.bunifuCustomTextbox6_TextChanged);
            this.sub_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sub_Total_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Fuchsia;
            this.label6.Location = new System.Drawing.Point(822, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Fuchsia;
            this.label8.Location = new System.Drawing.Point(822, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "TotalPrice:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Fuchsia;
            this.label9.Location = new System.Drawing.Point(643, 516);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "SubTotal";
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // Quantity
            // 
            this.Quantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.Fuchsia;
            this.Quantity.Location = new System.Drawing.Point(827, 349);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(126, 28);
            this.Quantity.TabIndex = 14;
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Fuchsia;
            this.label7.Location = new System.Drawing.Point(822, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantity:";
            // 
            // AddItem
            // 
            this.AddItem.ActiveBorderThickness = 1;
            this.AddItem.ActiveCornerRadius = 20;
            this.AddItem.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.AddItem.ActiveForecolor = System.Drawing.Color.White;
            this.AddItem.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.AddItem.BackColor = System.Drawing.Color.White;
            this.AddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddItem.BackgroundImage")));
            this.AddItem.ButtonText = "AddItem";
            this.AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.ForeColor = System.Drawing.Color.Fuchsia;
            this.AddItem.IdleBorderThickness = 1;
            this.AddItem.IdleCornerRadius = 20;
            this.AddItem.IdleFillColor = System.Drawing.Color.White;
            this.AddItem.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.AddItem.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.AddItem.Location = new System.Drawing.Point(610, 66);
            this.AddItem.Margin = new System.Windows.Forms.Padding(5);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(130, 56);
            this.AddItem.TabIndex = 16;
            this.AddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.AddItem, "Add Items to listbox");
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Fuchsia;
            this.radioButton1.Location = new System.Drawing.Point(153, 120);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 24);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dry Fishes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Fuchsia;
            this.radioButton2.Location = new System.Drawing.Point(296, 120);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 24);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Wet Fishes";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // Paid
            // 
            this.Paid.BorderColor = System.Drawing.Color.SeaGreen;
            this.Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paid.ForeColor = System.Drawing.Color.Fuchsia;
            this.Paid.Location = new System.Drawing.Point(769, 547);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(99, 28);
            this.Paid.TabIndex = 20;
            this.Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Paid.TextChanged += new System.EventHandler(this.Paid_TextChanged);
            this.Paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Paid_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Fuchsia;
            this.label11.Location = new System.Drawing.Point(643, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Paid:";
            // 
            // Balance
            // 
            this.Balance.BorderColor = System.Drawing.Color.SeaGreen;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.ForeColor = System.Drawing.Color.Fuchsia;
            this.Balance.Location = new System.Drawing.Point(769, 581);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(99, 28);
            this.Balance.TabIndex = 22;
            this.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Balance.TextChanged += new System.EventHandler(this.Balance_TextChanged);
            this.Balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Balance_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Fuchsia;
            this.label12.Location = new System.Drawing.Point(643, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Balance:";
            // 
            // Remove
            // 
            this.Remove.ActiveBorderThickness = 1;
            this.Remove.ActiveCornerRadius = 20;
            this.Remove.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.Remove.ActiveForecolor = System.Drawing.Color.White;
            this.Remove.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.Remove.BackColor = System.Drawing.Color.White;
            this.Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Remove.BackgroundImage")));
            this.Remove.ButtonText = "Remove";
            this.Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.Fuchsia;
            this.Remove.IdleBorderThickness = 1;
            this.Remove.IdleCornerRadius = 20;
            this.Remove.IdleFillColor = System.Drawing.Color.White;
            this.Remove.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.Remove.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.Remove.Location = new System.Drawing.Point(613, 132);
            this.Remove.Margin = new System.Windows.Forms.Padding(5);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(130, 59);
            this.Remove.TabIndex = 34;
            this.Remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.Remove, "Remove Items From Listbox");
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Save_button
            // 
            this.Save_button.ActiveBorderThickness = 1;
            this.Save_button.ActiveCornerRadius = 20;
            this.Save_button.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.Save_button.ActiveForecolor = System.Drawing.Color.White;
            this.Save_button.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.Save_button.BackColor = System.Drawing.Color.White;
            this.Save_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_button.BackgroundImage")));
            this.Save_button.ButtonText = "Save";
            this.Save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_button.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.ForeColor = System.Drawing.Color.Fuchsia;
            this.Save_button.IdleBorderThickness = 1;
            this.Save_button.IdleCornerRadius = 20;
            this.Save_button.IdleFillColor = System.Drawing.Color.White;
            this.Save_button.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.Save_button.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.Save_button.Location = new System.Drawing.Point(91, 530);
            this.Save_button.Margin = new System.Windows.Forms.Padding(5);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 59);
            this.Save_button.TabIndex = 35;
            this.Save_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.Save_button, "Save Invoice data ");
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.bunifuThinButton24);
            this.bunifuCards1.Controls.Add(this.bunifuThinButton21);
            this.bunifuCards1.Controls.Add(this.Save_button);
            this.bunifuCards1.Controls.Add(this.Remove);
            this.bunifuCards1.Controls.Add(this.label12);
            this.bunifuCards1.Controls.Add(this.Balance);
            this.bunifuCards1.Controls.Add(this.label11);
            this.bunifuCards1.Controls.Add(this.Paid);
            this.bunifuCards1.Controls.Add(this.radioButton2);
            this.bunifuCards1.Controls.Add(this.radioButton1);
            this.bunifuCards1.Controls.Add(this.AddItem);
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.Quantity);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.sub_total);
            this.bunifuCards1.Controls.Add(this.Total);
            this.bunifuCards1.Controls.Add(this.Price);
            this.bunifuCards1.Controls.Add(this.label10);
            this.bunifuCards1.Controls.Add(this.Cmb_fish);
            this.bunifuCards1.Controls.Add(this.listView1);
            this.bunifuCards1.Controls.Add(this.SId);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.SName);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1160, 718);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.Empty;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton24.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "X";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton24.Location = new System.Drawing.Point(1083, 14);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(72, 53);
            this.bunifuThinButton24.TabIndex = 37;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.bunifuThinButton24, "Close");
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
            this.bunifuThinButton21.ButtonText = "Print";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.Location = new System.Drawing.Point(298, 530);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(142, 59);
            this.bunifuThinButton21.TabIndex = 36;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.bunifuThinButton21, "Print Voucher");
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 718);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SName;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SId;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox Cmb_fish;
        private System.Windows.Forms.Label label10;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Price;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Total;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox sub_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Quantity;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 AddItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Paid;
        private System.Windows.Forms.Label label11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Balance;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuThinButton2 Remove;
        private Bunifu.Framework.UI.BunifuThinButton2 Save_button;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
    }
}