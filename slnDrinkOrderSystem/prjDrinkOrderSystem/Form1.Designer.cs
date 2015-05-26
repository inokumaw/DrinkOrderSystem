namespace prjDrinkOrderSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSugarLevel2 = new System.Windows.Forms.Label();
            this.lblSugarLevel3 = new System.Windows.Forms.Label();
            this.lblSugarLevel1 = new System.Windows.Forms.Label();
            this.lblSugarLevel0 = new System.Windows.Forms.Label();
            this.lblIceLevel0 = new System.Windows.Forms.Label();
            this.lblIceLevel1 = new System.Windows.Forms.Label();
            this.lblIceLevel3 = new System.Windows.Forms.Label();
            this.lblIceLevel2 = new System.Windows.Forms.Label();
            this.lblSugarLevel4 = new System.Windows.Forms.Label();
            this.lblIceLevel4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.tbTotalCount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbFeedBack = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbPay = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblSizeMiddle = new System.Windows.Forms.Label();
            this.lblSizeLarge = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBackSpace = new System.Windows.Forms.Label();
            this.lblUseMode = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbRefresh,
            this.toolStripSeparator1,
            this.tsbHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 56);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(468, 680);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(766, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(838, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(910, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(766, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(766, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "7";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(837, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 50);
            this.label6.TabIndex = 6;
            this.label6.Text = "8";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(838, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 50);
            this.label7.TabIndex = 7;
            this.label7.Text = "5";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(910, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 50);
            this.label8.TabIndex = 8;
            this.label8.Text = "9";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.DarkGreen;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(910, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 50);
            this.label9.TabIndex = 9;
            this.label9.Text = "6";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(496, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 236);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblSugarLevel2
            // 
            this.lblSugarLevel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSugarLevel2.BackColor = System.Drawing.Color.Yellow;
            this.lblSugarLevel2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSugarLevel2.ForeColor = System.Drawing.Color.Black;
            this.lblSugarLevel2.Location = new System.Drawing.Point(499, 610);
            this.lblSugarLevel2.Name = "lblSugarLevel2";
            this.lblSugarLevel2.Size = new System.Drawing.Size(100, 33);
            this.lblSugarLevel2.TabIndex = 15;
            this.lblSugarLevel2.Text = "少糖";
            this.lblSugarLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSugarLevel2.Click += new System.EventHandler(this.lblSugarLevel_Click);
            // 
            // lblSugarLevel3
            // 
            this.lblSugarLevel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSugarLevel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSugarLevel3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSugarLevel3.ForeColor = System.Drawing.Color.Black;
            this.lblSugarLevel3.Location = new System.Drawing.Point(499, 560);
            this.lblSugarLevel3.Name = "lblSugarLevel3";
            this.lblSugarLevel3.Size = new System.Drawing.Size(100, 33);
            this.lblSugarLevel3.TabIndex = 16;
            this.lblSugarLevel3.Text = "半糖";
            this.lblSugarLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSugarLevel3.Click += new System.EventHandler(this.lblSugarLevel_Click);
            // 
            // lblSugarLevel1
            // 
            this.lblSugarLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSugarLevel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSugarLevel1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSugarLevel1.ForeColor = System.Drawing.Color.Black;
            this.lblSugarLevel1.Location = new System.Drawing.Point(499, 658);
            this.lblSugarLevel1.Name = "lblSugarLevel1";
            this.lblSugarLevel1.Size = new System.Drawing.Size(100, 33);
            this.lblSugarLevel1.TabIndex = 17;
            this.lblSugarLevel1.Text = "微糖";
            this.lblSugarLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSugarLevel1.Click += new System.EventHandler(this.lblSugarLevel_Click);
            // 
            // lblSugarLevel0
            // 
            this.lblSugarLevel0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSugarLevel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSugarLevel0.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSugarLevel0.ForeColor = System.Drawing.Color.Black;
            this.lblSugarLevel0.Location = new System.Drawing.Point(499, 709);
            this.lblSugarLevel0.Name = "lblSugarLevel0";
            this.lblSugarLevel0.Size = new System.Drawing.Size(100, 33);
            this.lblSugarLevel0.TabIndex = 18;
            this.lblSugarLevel0.Text = "無糖";
            this.lblSugarLevel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSugarLevel0.Click += new System.EventHandler(this.lblSugarLevel_Click);
            // 
            // lblIceLevel0
            // 
            this.lblIceLevel0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIceLevel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblIceLevel0.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIceLevel0.ForeColor = System.Drawing.Color.Black;
            this.lblIceLevel0.Location = new System.Drawing.Point(620, 709);
            this.lblIceLevel0.Name = "lblIceLevel0";
            this.lblIceLevel0.Size = new System.Drawing.Size(100, 33);
            this.lblIceLevel0.TabIndex = 22;
            this.lblIceLevel0.Text = "去冰";
            this.lblIceLevel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIceLevel0.Click += new System.EventHandler(this.lblIceLevel_Click);
            // 
            // lblIceLevel1
            // 
            this.lblIceLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIceLevel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblIceLevel1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIceLevel1.ForeColor = System.Drawing.Color.Black;
            this.lblIceLevel1.Location = new System.Drawing.Point(620, 658);
            this.lblIceLevel1.Name = "lblIceLevel1";
            this.lblIceLevel1.Size = new System.Drawing.Size(100, 33);
            this.lblIceLevel1.TabIndex = 21;
            this.lblIceLevel1.Text = "微冰";
            this.lblIceLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIceLevel1.Click += new System.EventHandler(this.lblIceLevel_Click);
            // 
            // lblIceLevel3
            // 
            this.lblIceLevel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIceLevel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblIceLevel3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIceLevel3.ForeColor = System.Drawing.Color.Black;
            this.lblIceLevel3.Location = new System.Drawing.Point(620, 560);
            this.lblIceLevel3.Name = "lblIceLevel3";
            this.lblIceLevel3.Size = new System.Drawing.Size(100, 33);
            this.lblIceLevel3.TabIndex = 20;
            this.lblIceLevel3.Text = "半冰";
            this.lblIceLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIceLevel3.Click += new System.EventHandler(this.lblIceLevel_Click);
            // 
            // lblIceLevel2
            // 
            this.lblIceLevel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIceLevel2.BackColor = System.Drawing.Color.Aqua;
            this.lblIceLevel2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIceLevel2.ForeColor = System.Drawing.Color.Black;
            this.lblIceLevel2.Location = new System.Drawing.Point(620, 610);
            this.lblIceLevel2.Name = "lblIceLevel2";
            this.lblIceLevel2.Size = new System.Drawing.Size(100, 33);
            this.lblIceLevel2.TabIndex = 19;
            this.lblIceLevel2.Text = "少冰";
            this.lblIceLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIceLevel2.Click += new System.EventHandler(this.lblIceLevel_Click);
            // 
            // lblSugarLevel4
            // 
            this.lblSugarLevel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSugarLevel4.BackColor = System.Drawing.Color.Olive;
            this.lblSugarLevel4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSugarLevel4.ForeColor = System.Drawing.Color.Black;
            this.lblSugarLevel4.Location = new System.Drawing.Point(499, 514);
            this.lblSugarLevel4.Name = "lblSugarLevel4";
            this.lblSugarLevel4.Size = new System.Drawing.Size(100, 33);
            this.lblSugarLevel4.TabIndex = 23;
            this.lblSugarLevel4.Text = "正常";
            this.lblSugarLevel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSugarLevel4.Click += new System.EventHandler(this.lblSugarLevel_Click);
            // 
            // lblIceLevel4
            // 
            this.lblIceLevel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIceLevel4.BackColor = System.Drawing.Color.Teal;
            this.lblIceLevel4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIceLevel4.ForeColor = System.Drawing.Color.Black;
            this.lblIceLevel4.Location = new System.Drawing.Point(620, 514);
            this.lblIceLevel4.Name = "lblIceLevel4";
            this.lblIceLevel4.Size = new System.Drawing.Size(100, 33);
            this.lblIceLevel4.TabIndex = 24;
            this.lblIceLevel4.Text = "正常";
            this.lblIceLevel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIceLevel4.Click += new System.EventHandler(this.lblIceLevel_Click);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.BackColor = System.Drawing.Color.DarkCyan;
            this.label21.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(620, 472);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 33);
            this.label21.TabIndex = 26;
            this.label21.Text = "冰塊";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(502, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 21);
            this.label22.TabIndex = 27;
            this.label22.Text = "總金額：";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalPrice.Enabled = false;
            this.tbTotalPrice.Location = new System.Drawing.Point(582, 81);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(100, 29);
            this.tbTotalPrice.TabIndex = 28;
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalCount
            // 
            this.tbTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalCount.Enabled = false;
            this.tbTotalCount.Location = new System.Drawing.Point(582, 127);
            this.tbTotalCount.Name = "tbTotalCount";
            this.tbTotalCount.Size = new System.Drawing.Size(100, 29);
            this.tbTotalCount.TabIndex = 30;
            this.tbTotalCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(518, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 21);
            this.label23.TabIndex = 29;
            this.label23.Text = "杯數：";
            // 
            // tbFeedBack
            // 
            this.tbFeedBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFeedBack.Enabled = false;
            this.tbFeedBack.Location = new System.Drawing.Point(799, 127);
            this.tbFeedBack.Name = "tbFeedBack";
            this.tbFeedBack.Size = new System.Drawing.Size(100, 29);
            this.tbFeedBack.TabIndex = 34;
            this.tbFeedBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(740, 130);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 21);
            this.label24.TabIndex = 33;
            this.label24.Text = "找零：";
            // 
            // tbPay
            // 
            this.tbPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPay.Enabled = false;
            this.tbPay.Location = new System.Drawing.Point(799, 81);
            this.tbPay.Name = "tbPay";
            this.tbPay.Size = new System.Drawing.Size(100, 29);
            this.tbPay.TabIndex = 32;
            this.tbPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPay
            // 
            this.lblPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPay.ForeColor = System.Drawing.Color.White;
            this.lblPay.Location = new System.Drawing.Point(708, 84);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(90, 21);
            this.lblPay.TabIndex = 31;
            this.lblPay.Text = "已付金額：";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.BackColor = System.Drawing.Color.DarkGreen;
            this.label26.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(766, 632);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 50);
            this.label26.TabIndex = 35;
            this.label26.Text = "0";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // lblSizeMiddle
            // 
            this.lblSizeMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSizeMiddle.BackColor = System.Drawing.Color.Green;
            this.lblSizeMiddle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSizeMiddle.ForeColor = System.Drawing.Color.Black;
            this.lblSizeMiddle.Location = new System.Drawing.Point(499, 426);
            this.lblSizeMiddle.Name = "lblSizeMiddle";
            this.lblSizeMiddle.Size = new System.Drawing.Size(100, 33);
            this.lblSizeMiddle.TabIndex = 36;
            this.lblSizeMiddle.Text = "中杯";
            this.lblSizeMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSizeMiddle.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // lblSizeLarge
            // 
            this.lblSizeLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSizeLarge.BackColor = System.Drawing.Color.Green;
            this.lblSizeLarge.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSizeLarge.ForeColor = System.Drawing.Color.Black;
            this.lblSizeLarge.Location = new System.Drawing.Point(620, 426);
            this.lblSizeLarge.Name = "lblSizeLarge";
            this.lblSizeLarge.Size = new System.Drawing.Size(100, 33);
            this.lblSizeLarge.TabIndex = 37;
            this.lblSizeLarge.Text = "大杯";
            this.lblSizeLarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSizeLarge.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirm.BackColor = System.Drawing.Color.GreenYellow;
            this.lblConfirm.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Black;
            this.lblConfirm.Location = new System.Drawing.Point(767, 692);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(95, 50);
            this.lblConfirm.TabIndex = 38;
            this.lblConfirm.Text = "確認";
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancel.BackColor = System.Drawing.Color.DarkRed;
            this.lblCancel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCancel.ForeColor = System.Drawing.Color.Black;
            this.lblCancel.Location = new System.Drawing.Point(865, 692);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(95, 50);
            this.lblCancel.TabIndex = 39;
            this.lblCancel.Text = "取消";
            this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.BackColor = System.Drawing.Color.DarkCyan;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(499, 472);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 33);
            this.label20.TabIndex = 25;
            this.label20.Text = "甜度";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBackSpace
            // 
            this.lblBackSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackSpace.BackColor = System.Drawing.Color.DarkGreen;
            this.lblBackSpace.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBackSpace.ForeColor = System.Drawing.Color.White;
            this.lblBackSpace.Location = new System.Drawing.Point(837, 632);
            this.lblBackSpace.Name = "lblBackSpace";
            this.lblBackSpace.Size = new System.Drawing.Size(123, 50);
            this.lblBackSpace.TabIndex = 40;
            this.lblBackSpace.Text = "|←";
            this.lblBackSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBackSpace.Click += new System.EventHandler(this.lblBackSpace_Click);
            // 
            // lblUseMode
            // 
            this.lblUseMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUseMode.BackColor = System.Drawing.Color.GreenYellow;
            this.lblUseMode.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUseMode.ForeColor = System.Drawing.Color.Black;
            this.lblUseMode.Location = new System.Drawing.Point(921, 81);
            this.lblUseMode.Name = "lblUseMode";
            this.lblUseMode.Size = new System.Drawing.Size(75, 75);
            this.lblUseMode.TabIndex = 41;
            this.lblUseMode.Text = "付款";
            this.lblUseMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUseMode.Click += new System.EventHandler(this.lblPay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbOpen
            // 
            this.tsbOpen.AutoSize = false;
            this.tsbOpen.Image = global::prjDrinkOrderSystem.Properties.Resources.open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(36, 46);
            this.tsbOpen.Text = "開啟";
            this.tsbOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbHelp
            // 
            this.tsbHelp.Image = global::prjDrinkOrderSystem.Properties.Resources.help;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(36, 53);
            this.tsbHelp.Text = "說明";
            this.tsbHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::prjDrinkOrderSystem.Properties.Resources.refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(36, 53);
            this.tsbRefresh.Text = "重置";
            this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1008, 762);
            this.Controls.Add(this.lblUseMode);
            this.Controls.Add(this.lblBackSpace);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblSizeLarge);
            this.Controls.Add(this.lblSizeMiddle);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tbFeedBack);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.tbPay);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.tbTotalCount);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblIceLevel4);
            this.Controls.Add(this.lblSugarLevel4);
            this.Controls.Add(this.lblIceLevel0);
            this.Controls.Add(this.lblIceLevel1);
            this.Controls.Add(this.lblIceLevel3);
            this.Controls.Add(this.lblIceLevel2);
            this.Controls.Add(this.lblSugarLevel0);
            this.Controls.Add(this.lblSugarLevel1);
            this.Controls.Add(this.lblSugarLevel3);
            this.Controls.Add(this.lblSugarLevel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSugarLevel2;
        private System.Windows.Forms.Label lblSugarLevel3;
        private System.Windows.Forms.Label lblSugarLevel1;
        private System.Windows.Forms.Label lblSugarLevel0;
        private System.Windows.Forms.Label lblIceLevel0;
        private System.Windows.Forms.Label lblIceLevel1;
        private System.Windows.Forms.Label lblIceLevel3;
        private System.Windows.Forms.Label lblIceLevel2;
        private System.Windows.Forms.Label lblSugarLevel4;
        private System.Windows.Forms.Label lblIceLevel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.TextBox tbTotalCount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbFeedBack;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbPay;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblSizeMiddle;
        private System.Windows.Forms.Label lblSizeLarge;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblBackSpace;
        private System.Windows.Forms.Label lblUseMode;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.HelpProvider helpProvider1;

    }
}

