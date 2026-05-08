namespace Assignment_3
{
    partial class Order_Page
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
            this.dgv_available = new System.Windows.Forms.DataGridView();
            this.dgv_corders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Oadd = new System.Windows.Forms.Button();
            this.btn_rord = new System.Windows.Forms.Button();
            this.btn_btn = new System.Windows.Forms.Button();
            this.btn_sord = new System.Windows.Forms.Button();
            this.btn_lord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_available)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_available
            // 
            this.dgv_available.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_available.Location = new System.Drawing.Point(68, 39);
            this.dgv_available.Name = "dgv_available";
            this.dgv_available.Size = new System.Drawing.Size(240, 483);
            this.dgv_available.TabIndex = 0;
            // 
            // dgv_corders
            // 
            this.dgv_corders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_corders.Location = new System.Drawing.Point(340, 39);
            this.dgv_corders.Name = "dgv_corders";
            this.dgv_corders.Size = new System.Drawing.Size(678, 483);
            this.dgv_corders.TabIndex = 1;
            this.dgv_corders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_corders_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1049, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Oadd
            // 
            this.btn_Oadd.Location = new System.Drawing.Point(133, 555);
            this.btn_Oadd.Name = "btn_Oadd";
            this.btn_Oadd.Size = new System.Drawing.Size(75, 23);
            this.btn_Oadd.TabIndex = 3;
            this.btn_Oadd.Text = "Add to Order";
            this.btn_Oadd.UseVisualStyleBackColor = true;
            // 
            // btn_rord
            // 
            this.btn_rord.Location = new System.Drawing.Point(340, 555);
            this.btn_rord.Name = "btn_rord";
            this.btn_rord.Size = new System.Drawing.Size(119, 23);
            this.btn_rord.TabIndex = 4;
            this.btn_rord.Text = "Remove from Order";
            this.btn_rord.UseVisualStyleBackColor = true;
            // 
            // btn_btn
            // 
            this.btn_btn.Location = new System.Drawing.Point(522, 555);
            this.btn_btn.Name = "btn_btn";
            this.btn_btn.Size = new System.Drawing.Size(75, 23);
            this.btn_btn.TabIndex = 5;
            this.btn_btn.Text = "Button";
            this.btn_btn.UseVisualStyleBackColor = true;
            // 
            // btn_sord
            // 
            this.btn_sord.Location = new System.Drawing.Point(707, 555);
            this.btn_sord.Name = "btn_sord";
            this.btn_sord.Size = new System.Drawing.Size(75, 23);
            this.btn_sord.TabIndex = 6;
            this.btn_sord.Text = "Save Order";
            this.btn_sord.UseVisualStyleBackColor = true;
            // 
            // btn_lord
            // 
            this.btn_lord.Location = new System.Drawing.Point(943, 555);
            this.btn_lord.Name = "btn_lord";
            this.btn_lord.Size = new System.Drawing.Size(75, 23);
            this.btn_lord.TabIndex = 7;
            this.btn_lord.Text = "Load Order";
            this.btn_lord.UseVisualStyleBackColor = true;
            this.btn_lord.Click += new System.EventHandler(this.btn_lord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1051, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Order Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1055, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1050, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1054, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 11;
            // 
            // Order_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_lord);
            this.Controls.Add(this.btn_sord);
            this.Controls.Add(this.btn_btn);
            this.Controls.Add(this.btn_rord);
            this.Controls.Add(this.btn_Oadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_corders);
            this.Controls.Add(this.dgv_available);
            this.Name = "Order_Page";
            this.Size = new System.Drawing.Size(1281, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_available)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_available;
        private System.Windows.Forms.DataGridView dgv_corders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Oadd;
        private System.Windows.Forms.Button btn_rord;
        private System.Windows.Forms.Button btn_btn;
        private System.Windows.Forms.Button btn_sord;
        private System.Windows.Forms.Button btn_lord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}
