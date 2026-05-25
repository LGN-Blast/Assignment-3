namespace Assignment_3
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.flowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTotalInv = new System.Windows.Forms.Panel();
            this.lblTotalInventory = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalStockValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dashTimer = new System.Windows.Forms.Timer(this.components);
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.txtSearchHome = new System.Windows.Forms.TextBox();
            this.dgvHomepage = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.flowCards.SuspendLayout();
            this.pnlTotalInv.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomepage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.grpInventory);
            this.pnlMain.Controls.Add(this.flowCards);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1646, 819);
            this.pnlMain.TabIndex = 0;
            // 
            // flowCards
            // 
            this.flowCards.BackColor = System.Drawing.Color.Transparent;
            this.flowCards.Controls.Add(this.pnlTotalInv);
            this.flowCards.Controls.Add(this.panel1);
            this.flowCards.Controls.Add(this.panel2);
            this.flowCards.Location = new System.Drawing.Point(0, 106);
            this.flowCards.Name = "flowCards";
            this.flowCards.Size = new System.Drawing.Size(1283, 99);
            this.flowCards.TabIndex = 1;
            this.flowCards.WrapContents = false;
            // 
            // pnlTotalInv
            // 
            this.pnlTotalInv.BackColor = System.Drawing.Color.White;
            this.pnlTotalInv.Controls.Add(this.lblTotalInventory);
            this.pnlTotalInv.Controls.Add(this.label8);
            this.pnlTotalInv.Location = new System.Drawing.Point(3, 3);
            this.pnlTotalInv.Name = "pnlTotalInv";
            this.pnlTotalInv.Size = new System.Drawing.Size(423, 90);
            this.pnlTotalInv.TabIndex = 0;
            // 
            // lblTotalInventory
            // 
            this.lblTotalInventory.AutoSize = true;
            this.lblTotalInventory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInventory.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTotalInventory.Location = new System.Drawing.Point(186, 39);
            this.lblTotalInventory.Name = "lblTotalInventory";
            this.lblTotalInventory.Size = new System.Drawing.Size(35, 41);
            this.lblTotalInventory.TabIndex = 1;
            this.lblTotalInventory.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Inventory";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblLowStock);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(432, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 90);
            this.panel1.TabIndex = 2;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLowStock.Location = new System.Drawing.Point(191, 39);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(35, 41);
            this.lblLowStock.TabIndex = 1;
            this.lblLowStock.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Low Stock Alerts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalStockValue);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(859, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 90);
            this.panel2.TabIndex = 3;
            // 
            // lblTotalStockValue
            // 
            this.lblTotalStockValue.AutoSize = true;
            this.lblTotalStockValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStockValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTotalStockValue.Location = new System.Drawing.Point(189, 39);
            this.lblTotalStockValue.Name = "lblTotalStockValue";
            this.lblTotalStockValue.Size = new System.Drawing.Size(35, 41);
            this.lblTotalStockValue.TabIndex = 1;
            this.lblTotalStockValue.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Stock Value";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1646, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(1175, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 23);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(1072, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 23);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(541, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "DASHBOARD";
            // 
            // dashTimer
            // 
            this.dashTimer.Enabled = true;
            this.dashTimer.Interval = 1000;
            this.dashTimer.Tick += new System.EventHandler(this.dashTimer_Tick);
            // 
            // grpInventory
            // 
            this.grpInventory.BackColor = System.Drawing.Color.White;
            this.grpInventory.Controls.Add(this.btnSearchOrder);
            this.grpInventory.Controls.Add(this.txtSearchHome);
            this.grpInventory.Controls.Add(this.dgvHomepage);
            this.grpInventory.Location = new System.Drawing.Point(29, 249);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(1217, 567);
            this.grpInventory.TabIndex = 15;
            this.grpInventory.TabStop = false;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOrder.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrder.ForeColor = System.Drawing.Color.White;
            this.btnSearchOrder.Location = new System.Drawing.Point(0, 5);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(120, 38);
            this.btnSearchOrder.TabIndex = 21;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = false;
            // 
            // txtSearchHome
            // 
            this.txtSearchHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchHome.Location = new System.Drawing.Point(126, 9);
            this.txtSearchHome.Name = "txtSearchHome";
            this.txtSearchHome.Size = new System.Drawing.Size(341, 31);
            this.txtSearchHome.TabIndex = 21;
            this.txtSearchHome.TextChanged += new System.EventHandler(this.txtSearchHome_TextChanged);
            // 
            // dgvHomepage
            // 
            this.dgvHomepage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHomepage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomepage.Location = new System.Drawing.Point(0, 46);
            this.dgvHomepage.Name = "dgvHomepage";
            this.dgvHomepage.RowHeadersWidth = 51;
            this.dgvHomepage.RowTemplate.Height = 24;
            this.dgvHomepage.Size = new System.Drawing.Size(1217, 515);
            this.dgvHomepage.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1646, 819);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlMain.ResumeLayout(false);
            this.flowCards.ResumeLayout(false);
            this.pnlTotalInv.ResumeLayout(false);
            this.pnlTotalInv.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpInventory.ResumeLayout(false);
            this.grpInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomepage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer dashTimer;
        private System.Windows.Forms.FlowLayoutPanel flowCards;
        private System.Windows.Forms.Panel pnlTotalInv;
        private System.Windows.Forms.Label lblTotalInventory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalStockValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox txtSearchHome;
        public System.Windows.Forms.DataGridView dgvHomepage;
    }
}
