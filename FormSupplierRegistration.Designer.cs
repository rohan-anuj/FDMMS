namespace WindowsFormsApplication10
{
    partial class FormSupplierRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplierRegistration));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Contactnumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Sid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.DataView = new Guna.UI.WinForms.GunaGradient2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            this.Contactnumber2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.Address2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonZ1 = new CustomWindowsForm.ButtonZ();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(124, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "SFullName:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(124, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // Contactnumber
            // 
            this.Contactnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Contactnumber.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contactnumber.ForeColor = System.Drawing.Color.Fuchsia;
            this.Contactnumber.HintForeColor = System.Drawing.Color.Empty;
            this.Contactnumber.HintText = "";
            this.Contactnumber.isPassword = false;
            this.Contactnumber.LineFocusedColor = System.Drawing.Color.Fuchsia;
            this.Contactnumber.LineIdleColor = System.Drawing.Color.Gray;
            this.Contactnumber.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.Contactnumber.LineThickness = 4;
            this.Contactnumber.Location = new System.Drawing.Point(766, 228);
            this.Contactnumber.Margin = new System.Windows.Forms.Padding(4);
            this.Contactnumber.Name = "Contactnumber";
            this.Contactnumber.Size = new System.Drawing.Size(231, 44);
            this.Contactnumber.TabIndex = 13;
            this.Contactnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Contactnumber.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            this.Contactnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bunifu_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Fuchsia;
            this.label6.Location = new System.Drawing.Point(778, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "ContactNo.:";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "SUBMIT";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton21.Location = new System.Drawing.Point(265, 558);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(167, 50);
            this.bunifuThinButton21.TabIndex = 16;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Fuchsia;
            this.label7.Location = new System.Drawing.Point(124, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "SupplierId:";
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "DELETE";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton22.Location = new System.Drawing.Point(654, 558);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(167, 50);
            this.bunifuThinButton22.TabIndex = 21;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1215, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 718);
            this.panel1.TabIndex = 22;
            // 
            // Sname
            // 
            this.Sname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname.ForeColor = System.Drawing.Color.Fuchsia;
            this.Sname.HintForeColor = System.Drawing.Color.Empty;
            this.Sname.HintText = "";
            this.Sname.isPassword = false;
            this.Sname.LineFocusedColor = System.Drawing.Color.Fuchsia;
            this.Sname.LineIdleColor = System.Drawing.Color.Gray;
            this.Sname.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.Sname.LineThickness = 4;
            this.Sname.Location = new System.Drawing.Point(112, 249);
            this.Sname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(499, 59);
            this.Sname.TabIndex = 27;
            this.Sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Sname.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // Address
            // 
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.Fuchsia;
            this.Address.HintForeColor = System.Drawing.Color.Empty;
            this.Address.HintText = "";
            this.Address.isPassword = false;
            this.Address.LineFocusedColor = System.Drawing.Color.Fuchsia;
            this.Address.LineIdleColor = System.Drawing.Color.Gray;
            this.Address.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.Address.LineThickness = 4;
            this.Address.Location = new System.Drawing.Point(112, 426);
            this.Address.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(514, 59);
            this.Address.TabIndex = 28;
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "UPDATE";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton23.Location = new System.Drawing.Point(459, 558);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(167, 50);
            this.bunifuThinButton23.TabIndex = 29;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // Sid
            // 
            this.Sid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sid.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sid.ForeColor = System.Drawing.Color.Fuchsia;
            this.Sid.HintForeColor = System.Drawing.Color.Empty;
            this.Sid.HintText = "";
            this.Sid.isPassword = false;
            this.Sid.LineFocusedColor = System.Drawing.Color.Fuchsia;
            this.Sid.LineIdleColor = System.Drawing.Color.Gray;
            this.Sid.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.Sid.LineThickness = 4;
            this.Sid.Location = new System.Drawing.Point(215, 95);
            this.Sid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(137, 59);
            this.Sid.TabIndex = 30;
            this.Sid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Sid.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.Sid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifukeypress);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox1.Location = new System.Drawing.Point(320, 113);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 31;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox2.Location = new System.Drawing.Point(579, 265);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 32;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox3.Location = new System.Drawing.Point(579, 438);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 33;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.White;
            this.iconPictureBox4.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox4.Location = new System.Drawing.Point(953, 228);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 34;
            this.iconPictureBox4.TabStop = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Fuchsia;
            this.bunifuCards1.Controls.Add(this.DataView);
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.Controls.Add(this.bunifuThinButton24);
            this.bunifuCards1.Controls.Add(this.iconPictureBox4);
            this.bunifuCards1.Controls.Add(this.iconPictureBox3);
            this.bunifuCards1.Controls.Add(this.iconPictureBox2);
            this.bunifuCards1.Controls.Add(this.iconPictureBox1);
            this.bunifuCards1.Controls.Add(this.Sid);
            this.bunifuCards1.Controls.Add(this.bunifuThinButton23);
            this.bunifuCards1.Controls.Add(this.Address);
            this.bunifuCards1.Controls.Add(this.Sname);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.bunifuThinButton22);
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.buttonZ1);
            this.bunifuCards1.Controls.Add(this.bunifuThinButton21);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.Contactnumber);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1215, 718);
            this.bunifuCards1.TabIndex = 2;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // DataView
            // 
            this.DataView.BackColor = System.Drawing.Color.Transparent;
            this.DataView.Dock = System.Windows.Forms.DockStyle.Right;
            this.DataView.GradientColor1 = System.Drawing.Color.White;
            this.DataView.GradientColor2 = System.Drawing.Color.White;
            this.DataView.Location = new System.Drawing.Point(1215, 0);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(0, 718);
            this.DataView.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuThinButton25);
            this.panel2.Controls.Add(this.iconPictureBox8);
            this.panel2.Controls.Add(this.Contactnumber2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.iconPictureBox7);
            this.panel2.Controls.Add(this.Address2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1215, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 718);
            this.panel2.TabIndex = 37;
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "UPDATEDATA";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton25.Location = new System.Drawing.Point(-101, 558);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(167, 50);
            this.bunifuThinButton25.TabIndex = 45;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // iconPictureBox8
            // 
            this.iconPictureBox8.BackColor = System.Drawing.Color.White;
            this.iconPictureBox8.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox8.ForeColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPictureBox8.IconColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox8.Location = new System.Drawing.Point(319, 366);
            this.iconPictureBox8.Name = "iconPictureBox8";
            this.iconPictureBox8.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox8.TabIndex = 42;
            this.iconPictureBox8.TabStop = false;
            // 
            // Contactnumber2
            // 
            this.Contactnumber2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Contactnumber2.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contactnumber2.ForeColor = System.Drawing.Color.Fuchsia;
            this.Contactnumber2.HintForeColor = System.Drawing.Color.Empty;
            this.Contactnumber2.HintText = "";
            this.Contactnumber2.isPassword = false;
            this.Contactnumber2.LineFocusedColor = System.Drawing.Color.Fuchsia;
            this.Contactnumber2.LineIdleColor = System.Drawing.Color.Gray;
            this.Contactnumber2.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.Contactnumber2.LineThickness = 4;
            this.Contactnumber2.Location = new System.Drawing.Point(128, 376);
            this.Contactnumber2.Margin = new System.Windows.Forms.Padding(4);
            this.Contactnumber2.Name = "Contactnumber2";
            this.Contactnumber2.Size = new System.Drawing.Size(231, 44);
            this.Contactnumber2.TabIndex = 41;
            this.Contactnumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Contactnumber2.OnValueChanged += new System.EventHandler(this.Contactnumber2_OnValueChanged);
            this.Contactnumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contactnumber2_Keyprss);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Fuchsia;
            this.label9.Location = new System.Drawing.Point(9, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "UpdateContactNo.:";
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.BackColor = System.Drawing.Color.White;
            this.iconPictureBox7.ForeColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBox7.IconColor = System.Drawing.Color.Fuchsia;
            this.iconPictureBox7.Location = new System.Drawing.Point(319, 274);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox7.TabIndex = 39;
            this.iconPictureBox7.TabStop = false;
            // 
            // Address2
            // 
            this.Address2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address2.ForeColor = System.Drawing.Color.Fuchsia;
            this.Address2.HintForeColor = System.Drawing.Color.Empty;
            this.Address2.HintText = "";
            this.Address2.isPassword = false;
            this.Address2.LineFocusedColor = System.Drawing.Color.Fuchsia;
            this.Address2.LineIdleColor = System.Drawing.Color.Gray;
            this.Address2.LineMouseHoverColor = System.Drawing.Color.Fuchsia;
            this.Address2.LineThickness = 4;
            this.Address2.Location = new System.Drawing.Point(128, 263);
            this.Address2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(223, 59);
            this.Address2.TabIndex = 38;
            this.Address2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Fuchsia;
            this.label8.Location = new System.Drawing.Point(13, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "UpdateAddress:";
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(1129, 14);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(72, 53);
            this.bunifuThinButton24.TabIndex = 36;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonZ1
            // 
            this.buttonZ1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZ1.BackColor = System.Drawing.Color.White;
            this.buttonZ1.BZBackColor = System.Drawing.Color.White;
            this.buttonZ1.DisplayText = "X";
            this.buttonZ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ1.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonZ1.Location = new System.Drawing.Point(2179, 3);
            this.buttonZ1.MouseClickColor1 = System.Drawing.Color.Purple;
            this.buttonZ1.MouseHoverColor = System.Drawing.Color.Violet;
            this.buttonZ1.Name = "buttonZ1";
            this.buttonZ1.Size = new System.Drawing.Size(55, 57);
            this.buttonZ1.TabIndex = 18;
            this.buttonZ1.Text = "X";
            this.buttonZ1.TextLocation_X = 10;
            this.buttonZ1.TextLocation_Y = 10;
            this.buttonZ1.UseVisualStyleBackColor = false;
            this.buttonZ1.Click += new System.EventHandler(this.buttonZ1_Click);
            // 
            // FormSupplierRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 718);
            this.Controls.Add(this.bunifuCards1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSupplierRegistration";
            this.Text = "FormSupplierRegistration";
            this.Load += new System.EventHandler(this.FormSupplierRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Contactnumber;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private CustomWindowsForm.ButtonZ buttonZ1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Sname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Address;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Sid;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Contactnumber2;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Address2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI.WinForms.GunaGradient2Panel DataView;
    }
}