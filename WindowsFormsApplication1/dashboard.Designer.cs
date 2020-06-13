namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStocksReport = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnDatabaseConfig = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox11 = new System.Windows.Forms.PictureBox();
            this.LinkLabel4 = new System.Windows.Forms.LinkLabel();
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Time Management System";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Time Management System";
            this.notifyIcon1.Visible = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Live-Messenger-Metro.PNG");
            this.imageList1.Images.SetKeyName(1, "Documents-Library-Metro.PNG");
            this.imageList1.Images.SetKeyName(2, "Windows-Phone-Metro.PNG");
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1055, 439);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 41);
            this.label10.TabIndex = 11;
            this.label10.Text = "Stocks ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1439, 439);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Accounts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(647, 440);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 40);
            this.label9.TabIndex = 11;
            this.label9.Text = "Estimates";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 439);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 34);
            this.label8.TabIndex = 11;
            this.label8.Text = "Staffs";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(67, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1026, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "ODMUS ELECTRICALS MANAGEMENT SYSTEM";
            // 
            // btnStocksReport
            // 
            this.btnStocksReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStocksReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStocksReport.BackgroundImage")));
            this.btnStocksReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStocksReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStocksReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStocksReport.FlatAppearance.BorderSize = 0;
            this.btnStocksReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnStocksReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStocksReport.Location = new System.Drawing.Point(953, 133);
            this.btnStocksReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnStocksReport.Name = "btnStocksReport";
            this.btnStocksReport.Size = new System.Drawing.Size(337, 283);
            this.btnStocksReport.TabIndex = 9;
            this.btnStocksReport.UseVisualStyleBackColor = false;
            this.btnStocksReport.Click += new System.EventHandler(this.btnStocksReport_Click);
            // 
            // btnDailySales
            // 
            this.btnDailySales.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDailySales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDailySales.BackgroundImage")));
            this.btnDailySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDailySales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailySales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDailySales.FlatAppearance.BorderSize = 0;
            this.btnDailySales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDailySales.Location = new System.Drawing.Point(543, 133);
            this.btnDailySales.Margin = new System.Windows.Forms.Padding(4);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(350, 283);
            this.btnDailySales.TabIndex = 9;
            this.btnDailySales.UseVisualStyleBackColor = false;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPOS.BackgroundImage")));
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPOS.Location = new System.Drawing.Point(146, 134);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(4);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(343, 283);
            this.btnPOS.TabIndex = 9;
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnDatabaseConfig
            // 
            this.btnDatabaseConfig.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDatabaseConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDatabaseConfig.BackgroundImage")));
            this.btnDatabaseConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatabaseConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatabaseConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDatabaseConfig.FlatAppearance.BorderSize = 0;
            this.btnDatabaseConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnDatabaseConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatabaseConfig.Location = new System.Drawing.Point(1338, 133);
            this.btnDatabaseConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatabaseConfig.Name = "btnDatabaseConfig";
            this.btnDatabaseConfig.Size = new System.Drawing.Size(341, 283);
            this.btnDatabaseConfig.TabIndex = 9;
            this.btnDatabaseConfig.UseVisualStyleBackColor = false;
            this.btnDatabaseConfig.Click += new System.EventHandler(this.btnDatabaseConfig_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 54);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PictureBox11);
            this.splitContainer1.Panel2.Controls.Add(this.LinkLabel4);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.btnStocksReport);
            this.splitContainer1.Panel2.Controls.Add(this.btnDailySales);
            this.splitContainer1.Panel2.Controls.Add(this.btnPOS);
            this.splitContainer1.Panel2.Controls.Add(this.btnDatabaseConfig);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1653, 863);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1653, 703);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1528, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 137);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // PictureBox11
            // 
            this.PictureBox11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox11.Image")));
            this.PictureBox11.Location = new System.Drawing.Point(146, 4);
            this.PictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox11.Name = "PictureBox11";
            this.PictureBox11.Size = new System.Drawing.Size(71, 62);
            this.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox11.TabIndex = 20;
            this.PictureBox11.TabStop = false;
            this.PictureBox11.Click += new System.EventHandler(this.PictureBox11_Click);
            // 
            // LinkLabel4
            // 
            this.LinkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LinkLabel4.AutoSize = true;
            this.LinkLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LinkLabel4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.LinkLabel4.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel4.Location = new System.Drawing.Point(147, 67);
            this.LinkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel4.Name = "LinkLabel4";
            this.LinkLabel4.Size = new System.Drawing.Size(76, 32);
            this.LinkLabel4.TabIndex = 19;
            this.LinkLabel4.TabStop = true;
            this.LinkLabel4.Text = "Close";
            this.LinkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1653, 863);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStocksReport;
        private System.Windows.Forms.Button btnDailySales;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnDatabaseConfig;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.PictureBox PictureBox11;
        internal System.Windows.Forms.LinkLabel LinkLabel4;
    }
}

