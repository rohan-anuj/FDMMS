namespace WindowsFormsApplication10.Report
{
    partial class Invoiceshow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoiceshow));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Printslip = new Bunifu.Framework.UI.BunifuThinButton2();
            this.InvoiceId = new System.Windows.Forms.TextBox();
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.RightBorderPanel = new System.Windows.Forms.Panel();
            this.LeftBorderPanel = new System.Windows.Forms.Panel();
            this.BottomBorderPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication10.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 140);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(673, 700);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Fuchsia;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.Empty;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton24.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.bunifuThinButton24.Location = new System.Drawing.Point(611, 4);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(72, 39);
            this.bunifuThinButton24.TabIndex = 37;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // Printslip
            // 
            this.Printslip.ActiveBorderThickness = 1;
            this.Printslip.ActiveCornerRadius = 20;
            this.Printslip.ActiveFillColor = System.Drawing.Color.Magenta;
            this.Printslip.ActiveForecolor = System.Drawing.Color.White;
            this.Printslip.ActiveLineColor = System.Drawing.Color.Magenta;
            this.Printslip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Printslip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Printslip.BackgroundImage")));
            this.Printslip.ButtonText = "Print slip";
            this.Printslip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Printslip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printslip.ForeColor = System.Drawing.Color.Magenta;
            this.Printslip.IdleBorderThickness = 1;
            this.Printslip.IdleCornerRadius = 20;
            this.Printslip.IdleFillColor = System.Drawing.Color.White;
            this.Printslip.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.Printslip.IdleLineColor = System.Drawing.Color.Magenta;
            this.Printslip.Location = new System.Drawing.Point(330, 77);
            this.Printslip.Margin = new System.Windows.Forms.Padding(5);
            this.Printslip.Name = "Printslip";
            this.Printslip.Size = new System.Drawing.Size(165, 41);
            this.Printslip.TabIndex = 38;
            this.Printslip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Printslip.Click += new System.EventHandler(this.Printslip_Click);
            // 
            // InvoiceId
            // 
            this.InvoiceId.Location = new System.Drawing.Point(118, 86);
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.Size = new System.Drawing.Size(134, 22);
            this.InvoiceId.TabIndex = 39;
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.BackColor = System.Drawing.Color.Fuchsia;
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.ForeColor = System.Drawing.Color.Fuchsia;
            this.TopBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(697, 5);
            this.TopBorderPanel.TabIndex = 40;
            this.TopBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseDown);
            this.TopBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseMove);
            this.TopBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseUp);
            // 
            // RightBorderPanel
            // 
            this.RightBorderPanel.BackColor = System.Drawing.Color.Fuchsia;
            this.RightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorderPanel.ForeColor = System.Drawing.Color.Fuchsia;
            this.RightBorderPanel.Location = new System.Drawing.Point(692, 5);
            this.RightBorderPanel.Name = "RightBorderPanel";
            this.RightBorderPanel.Size = new System.Drawing.Size(5, 851);
            this.RightBorderPanel.TabIndex = 41;
            this.RightBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBorderPanel_MouseDown);
            this.RightBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBorderPanel_MouseMove);
            this.RightBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBorderPanel_MouseUp);
            // 
            // LeftBorderPanel
            // 
            this.LeftBorderPanel.BackColor = System.Drawing.Color.Fuchsia;
            this.LeftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorderPanel.ForeColor = System.Drawing.Color.Fuchsia;
            this.LeftBorderPanel.Location = new System.Drawing.Point(0, 5);
            this.LeftBorderPanel.Name = "LeftBorderPanel";
            this.LeftBorderPanel.Size = new System.Drawing.Size(5, 851);
            this.LeftBorderPanel.TabIndex = 42;
            this.LeftBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBorderPanel_MouseDown);
            this.LeftBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBorderPanel_MouseMove);
            this.LeftBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftBorderPanel_MouseUp);
            // 
            // BottomBorderPanel
            // 
            this.BottomBorderPanel.BackColor = System.Drawing.Color.Fuchsia;
            this.BottomBorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorderPanel.ForeColor = System.Drawing.Color.Fuchsia;
            this.BottomBorderPanel.Location = new System.Drawing.Point(5, 851);
            this.BottomBorderPanel.Name = "BottomBorderPanel";
            this.BottomBorderPanel.Size = new System.Drawing.Size(687, 5);
            this.BottomBorderPanel.TabIndex = 43;
            this.BottomBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomBorderPanel_MouseDown);
            this.BottomBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomBorderPanel_MouseMove);
            this.BottomBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomBorderPanel_MouseUp);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.bunifuThinButton24);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(5, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(687, 45);
            this.TopPanel.TabIndex = 44;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Invoiceshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(697, 856);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomBorderPanel);
            this.Controls.Add(this.LeftBorderPanel);
            this.Controls.Add(this.RightBorderPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.Controls.Add(this.InvoiceId);
            this.Controls.Add(this.Printslip);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoiceshow";
            this.Text = "Invoiceshow";
            this.Load += new System.EventHandler(this.Invoiceshow_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 Printslip;
        private System.Windows.Forms.TextBox InvoiceId;
        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel RightBorderPanel;
        private System.Windows.Forms.Panel LeftBorderPanel;
        private System.Windows.Forms.Panel BottomBorderPanel;
        private System.Windows.Forms.Panel TopPanel;
    }
}