namespace Flogin
{
    partial class Fmain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnCustormer = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnCustormer);
            this.panel1.Controls.Add(this.btnTable);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnRevenue);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 636);
            this.panel1.TabIndex = 0;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(-1, 287);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(183, 67);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnCustormer
            // 
            this.btnCustormer.Location = new System.Drawing.Point(-1, 215);
            this.btnCustormer.Name = "btnCustormer";
            this.btnCustormer.Size = new System.Drawing.Size(183, 67);
            this.btnCustormer.TabIndex = 2;
            this.btnCustormer.Text = "Khách hàng";
            this.btnCustormer.UseVisualStyleBackColor = true;
            this.btnCustormer.Click += new System.EventHandler(this.btnCustormer_Click);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(-1, 142);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(183, 67);
            this.btnTable.TabIndex = 1;
            this.btnTable.Text = "Bàn";
            this.btnTable.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(-1, 566);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(183, 67);
            this.button6.TabIndex = 6;
            this.button6.Text = "Đăng xuất";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(-1, 360);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(183, 67);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(-1, 433);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(183, 67);
            this.btnRevenue.TabIndex = 5;
            this.btnRevenue.Text = "Thống kê";
            this.btnRevenue.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(-1, 69);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(183, 67);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(193, 288);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(851, 349);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(193, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 280);
            this.panel2.TabIndex = 2;
            // 
            // Fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fmain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnCustormer;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnTable;
    }
}