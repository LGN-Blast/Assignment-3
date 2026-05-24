namespace Assignment_3
{
    partial class Checkout
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.txtFinalStatus = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFinalQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinalProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFinalOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFinalCustomer = new System.Windows.Forms.TextBox();
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCheckout = new System.Windows.Forms.TextBox();
            this.dgvCheckout = new System.Windows.Forms.DataGridView();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1655, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(496, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order Checkout";
            // 
            // grpProduct
            // 
            this.grpProduct.BackColor = System.Drawing.Color.White;
            this.grpProduct.Controls.Add(this.panel2);
            this.grpProduct.Controls.Add(this.label7);
            this.grpProduct.Controls.Add(this.btnClearOrder);
            this.grpProduct.Controls.Add(this.txtFinalStatus);
            this.grpProduct.Controls.Add(this.btnConfirm);
            this.grpProduct.Controls.Add(this.label6);
            this.grpProduct.Controls.Add(this.txtFinalQuantity);
            this.grpProduct.Controls.Add(this.label5);
            this.grpProduct.Controls.Add(this.txtFinalProduct);
            this.grpProduct.Controls.Add(this.label4);
            this.grpProduct.Controls.Add(this.txtFinalOrderID);
            this.grpProduct.Controls.Add(this.label2);
            this.grpProduct.Controls.Add(this.label3);
            this.grpProduct.Controls.Add(this.txtFinalCustomer);
            this.grpProduct.Location = new System.Drawing.Point(26, 102);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(409, 650);
            this.grpProduct.TabIndex = 2;
            this.grpProduct.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(6, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 90);
            this.panel2.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTotal.Location = new System.Drawing.Point(179, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 41);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(99, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "PRODUCT DETAILS";
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.DarkGray;
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.ForeColor = System.Drawing.Color.White;
            this.btnClearOrder.Location = new System.Drawing.Point(6, 581);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(397, 45);
            this.btnClearOrder.TabIndex = 17;
            this.btnClearOrder.Text = "Cancel Order";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // txtFinalStatus
            // 
            this.txtFinalStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalStatus.Location = new System.Drawing.Point(120, 330);
            this.txtFinalStatus.Name = "txtFinalStatus";
            this.txtFinalStatus.ReadOnly = true;
            this.txtFinalStatus.Size = new System.Drawing.Size(220, 31);
            this.txtFinalStatus.TabIndex = 15;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(6, 513);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(397, 45);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantity";
            // 
            // txtFinalQuantity
            // 
            this.txtFinalQuantity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalQuantity.Location = new System.Drawing.Point(120, 274);
            this.txtFinalQuantity.Name = "txtFinalQuantity";
            this.txtFinalQuantity.ReadOnly = true;
            this.txtFinalQuantity.Size = new System.Drawing.Size(220, 31);
            this.txtFinalQuantity.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // txtFinalProduct
            // 
            this.txtFinalProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalProduct.Location = new System.Drawing.Point(120, 214);
            this.txtFinalProduct.Name = "txtFinalProduct";
            this.txtFinalProduct.ReadOnly = true;
            this.txtFinalProduct.Size = new System.Drawing.Size(220, 31);
            this.txtFinalProduct.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product";
            // 
            // txtFinalOrderID
            // 
            this.txtFinalOrderID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalOrderID.Location = new System.Drawing.Point(120, 90);
            this.txtFinalOrderID.Name = "txtFinalOrderID";
            this.txtFinalOrderID.ReadOnly = true;
            this.txtFinalOrderID.Size = new System.Drawing.Size(220, 31);
            this.txtFinalOrderID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order ID";
            // 
            // txtFinalCustomer
            // 
            this.txtFinalCustomer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalCustomer.Location = new System.Drawing.Point(120, 150);
            this.txtFinalCustomer.Name = "txtFinalCustomer";
            this.txtFinalCustomer.ReadOnly = true;
            this.txtFinalCustomer.Size = new System.Drawing.Size(220, 31);
            this.txtFinalCustomer.TabIndex = 5;
            // 
            // grpInventory
            // 
            this.grpInventory.BackColor = System.Drawing.Color.White;
            this.grpInventory.Controls.Add(this.lblStatusBar);
            this.grpInventory.Controls.Add(this.btnSearch);
            this.grpInventory.Controls.Add(this.txtSearchCheckout);
            this.grpInventory.Controls.Add(this.dgvCheckout);
            this.grpInventory.Location = new System.Drawing.Point(457, 120);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(829, 632);
            this.grpInventory.TabIndex = 3;
            this.grpInventory.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(0, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 38);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchCheckout
            // 
            this.txtSearchCheckout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCheckout.Location = new System.Drawing.Point(126, 9);
            this.txtSearchCheckout.Name = "txtSearchCheckout";
            this.txtSearchCheckout.Size = new System.Drawing.Size(341, 31);
            this.txtSearchCheckout.TabIndex = 21;
            this.txtSearchCheckout.TextChanged += new System.EventHandler(this.txtSearchCheckout_TextChanged);
            // 
            // dgvCheckout
            // 
            this.dgvCheckout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckout.Location = new System.Drawing.Point(0, 46);
            this.dgvCheckout.Name = "dgvCheckout";
            this.dgvCheckout.RowHeadersWidth = 51;
            this.dgvCheckout.RowTemplate.Height = 24;
            this.dgvCheckout.Size = new System.Drawing.Size(829, 537);
            this.dgvCheckout.TabIndex = 0;
            this.dgvCheckout.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckout_CellClick);
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBar.Location = new System.Drawing.Point(269, 586);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(311, 31);
            this.lblStatusBar.TabIndex = 22;
            this.lblStatusBar.Text = " 0 Orders Pending Checkout";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInventory);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Checkout";
            this.Size = new System.Drawing.Size(1655, 802);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpInventory.ResumeLayout(false);
            this.grpInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.TextBox txtFinalStatus;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFinalQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFinalProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFinalOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFinalCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchCheckout;
        public System.Windows.Forms.DataGridView dgvCheckout;
        private System.Windows.Forms.Label lblStatusBar;
    }
}
