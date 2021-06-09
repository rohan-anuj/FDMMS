namespace WindowsFormsApplication10
{
    partial class EditUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUsers));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.DUsername = new System.Windows.Forms.TextBox();
            this.newDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.newusername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.newADD = new Bunifu.Framework.UI.BunifuThinButton2();
            this.newClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuCards1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Fuchsia;
            this.bunifuCards1.Controls.Add(this.tableLayoutPanel2);
            this.bunifuCards1.Controls.Add(this.tableLayoutPanel3);
            this.bunifuCards1.Controls.Add(this.tableLayoutPanel1);
            this.bunifuCards1.Controls.Add(this.newClose);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1233, 703);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DUsername, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.newDelete, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(489, 329);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 185);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "USERNAME:";
            // 
            // DUsername
            // 
            this.DUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DUsername.Location = new System.Drawing.Point(3, 64);
            this.DUsername.Name = "DUsername";
            this.DUsername.Size = new System.Drawing.Size(169, 30);
            this.DUsername.TabIndex = 36;
            this.toolTip1.SetToolTip(this.DUsername, "Enter Existing Username");
            // 
            // newDelete
            // 
            this.newDelete.ActiveBorderThickness = 1;
            this.newDelete.ActiveCornerRadius = 20;
            this.newDelete.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.newDelete.ActiveForecolor = System.Drawing.Color.White;
            this.newDelete.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.newDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newDelete.BackColor = System.Drawing.Color.White;
            this.newDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newDelete.BackgroundImage")));
            this.newDelete.ButtonText = "DELETE";
            this.newDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDelete.ForeColor = System.Drawing.Color.Fuchsia;
            this.newDelete.IdleBorderThickness = 1;
            this.newDelete.IdleCornerRadius = 20;
            this.newDelete.IdleFillColor = System.Drawing.Color.White;
            this.newDelete.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.newDelete.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.newDelete.Location = new System.Drawing.Point(5, 127);
            this.newDelete.Margin = new System.Windows.Forms.Padding(5);
            this.newDelete.Name = "newDelete";
            this.newDelete.Size = new System.Drawing.Size(190, 53);
            this.newDelete.TabIndex = 32;
            this.newDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.newDelete, "Delete A/c");
            this.newDelete.Click += new System.EventHandler(this.newDelete_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 390F));
            this.tableLayoutPanel3.Controls.Add(this.iconPictureBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.newUpdate, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.newusername, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.newpassword, 0, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(732, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.6556F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18257F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.832298F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(390, 583);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.HotPink;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconPictureBox3.IconColor = System.Drawing.Color.HotPink;
            this.iconPictureBox3.IconSize = 254;
            this.iconPictureBox3.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(384, 254);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox3.TabIndex = 2;
            this.iconPictureBox3.TabStop = false;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Fuchsia;
            this.label.Location = new System.Drawing.Point(3, 414);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(384, 29);
            this.label.TabIndex = 35;
            this.label.Text = "NEWPASSWORD:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Fuchsia;
            this.label6.Location = new System.Drawing.Point(3, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "NEWUSERNAME:";
            // 
            // newUpdate
            // 
            this.newUpdate.ActiveBorderThickness = 1;
            this.newUpdate.ActiveCornerRadius = 20;
            this.newUpdate.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.newUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.newUpdate.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.newUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newUpdate.BackColor = System.Drawing.Color.White;
            this.newUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newUpdate.BackgroundImage")));
            this.newUpdate.ButtonText = "UPDATE";
            this.newUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUpdate.ForeColor = System.Drawing.Color.Fuchsia;
            this.newUpdate.IdleBorderThickness = 1;
            this.newUpdate.IdleCornerRadius = 20;
            this.newUpdate.IdleFillColor = System.Drawing.Color.White;
            this.newUpdate.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.newUpdate.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.newUpdate.Location = new System.Drawing.Point(111, 525);
            this.newUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.newUpdate.Name = "newUpdate";
            this.newUpdate.Size = new System.Drawing.Size(167, 50);
            this.newUpdate.TabIndex = 33;
            this.newUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.newUpdate, "Update Existing Account");
            this.newUpdate.Click += new System.EventHandler(this.newUpdate_Click);
            // 
            // newusername
            // 
            this.newusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newusername.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newusername.ForeColor = System.Drawing.Color.Fuchsia;
            this.newusername.HintForeColor = System.Drawing.Color.Empty;
            this.newusername.HintText = "";
            this.newusername.isPassword = false;
            this.newusername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.newusername.LineIdleColor = System.Drawing.Color.Silver;
            this.newusername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.newusername.LineThickness = 3;
            this.newusername.Location = new System.Drawing.Point(4, 359);
            this.newusername.Margin = new System.Windows.Forms.Padding(4);
            this.newusername.Name = "newusername";
            this.newusername.Size = new System.Drawing.Size(382, 51);
            this.newusername.TabIndex = 36;
            this.newusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.newusername, "Enter newusername");
            // 
            // newpassword
            // 
            this.newpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newpassword.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassword.ForeColor = System.Drawing.Color.Fuchsia;
            this.newpassword.HintForeColor = System.Drawing.Color.Empty;
            this.newpassword.HintText = "";
            this.newpassword.isPassword = false;
            this.newpassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.newpassword.LineIdleColor = System.Drawing.Color.Silver;
            this.newpassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.newpassword.LineThickness = 3;
            this.newpassword.Location = new System.Drawing.Point(4, 463);
            this.newpassword.Margin = new System.Windows.Forms.Padding(4);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(382, 51);
            this.newpassword.TabIndex = 37;
            this.newpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.newpassword, "Enter newpassword");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 390F));
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Username, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Password, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newADD, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.6556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18257F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.832298F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 586);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.HotPink;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.HotPink;
            this.iconPictureBox1.IconSize = 256;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(384, 256);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Fuchsia;
            this.Username.HintForeColor = System.Drawing.Color.Empty;
            this.Username.HintText = "";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.Username.LineIdleColor = System.Drawing.Color.Silver;
            this.Username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.Username.LineThickness = 3;
            this.Username.Location = new System.Drawing.Point(4, 361);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(382, 51);
            this.Username.TabIndex = 15;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.Username, "Enter Username");
            this.Username.OnValueChanged += new System.EventHandler(this.Username_OnValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(3, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "PASSWORD:";
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Fuchsia;
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Password.LineIdleColor = System.Drawing.Color.Silver;
            this.Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(4, 465);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password.Size = new System.Drawing.Size(382, 48);
            this.Password.TabIndex = 16;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.Password, "Enter password");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(3, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "USERNAME:";
            // 
            // newADD
            // 
            this.newADD.ActiveBorderThickness = 1;
            this.newADD.ActiveCornerRadius = 20;
            this.newADD.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.newADD.ActiveForecolor = System.Drawing.Color.White;
            this.newADD.ActiveLineColor = System.Drawing.Color.Fuchsia;
            this.newADD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newADD.BackColor = System.Drawing.Color.White;
            this.newADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newADD.BackgroundImage")));
            this.newADD.ButtonText = "ADD";
            this.newADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newADD.ForeColor = System.Drawing.Color.Fuchsia;
            this.newADD.IdleBorderThickness = 1;
            this.newADD.IdleCornerRadius = 20;
            this.newADD.IdleFillColor = System.Drawing.Color.White;
            this.newADD.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.newADD.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.newADD.Location = new System.Drawing.Point(111, 522);
            this.newADD.Margin = new System.Windows.Forms.Padding(5);
            this.newADD.Name = "newADD";
            this.newADD.Size = new System.Drawing.Size(167, 50);
            this.newADD.TabIndex = 31;
            this.newADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.newADD, "add Agent A/c");
            this.newADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // newClose
            // 
            this.newClose.ActiveBorderThickness = 1;
            this.newClose.ActiveCornerRadius = 20;
            this.newClose.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.newClose.ActiveForecolor = System.Drawing.Color.Empty;
            this.newClose.ActiveLineColor = System.Drawing.Color.White;
            this.newClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newClose.BackColor = System.Drawing.Color.White;
            this.newClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newClose.BackgroundImage")));
            this.newClose.ButtonText = "X";
            this.newClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newClose.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.newClose.IdleBorderThickness = 1;
            this.newClose.IdleCornerRadius = 20;
            this.newClose.IdleFillColor = System.Drawing.Color.White;
            this.newClose.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.newClose.IdleLineColor = System.Drawing.Color.White;
            this.newClose.Location = new System.Drawing.Point(1147, 14);
            this.newClose.Margin = new System.Windows.Forms.Padding(5);
            this.newClose.Name = "newClose";
            this.newClose.Size = new System.Drawing.Size(72, 53);
            this.newClose.TabIndex = 37;
            this.newClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.newClose, "Close");
            this.newClose.Click += new System.EventHandler(this.newClose_Click);
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 703);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUsers";
            this.Text = "TradeHistory";
            this.bunifuCards1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        protected internal Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
        private Bunifu.Framework.UI.BunifuThinButton2 newUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 newDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 newADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 newClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newusername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newpassword;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}