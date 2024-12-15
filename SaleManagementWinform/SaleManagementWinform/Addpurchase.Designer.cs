namespace SaleManagementWinform
{
    partial class AddPurchase
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
            this.txb_status = new System.Windows.Forms.TextBox();
            this.txb_quantity = new System.Windows.Forms.TextBox();
            this.txb_purchasedate = new System.Windows.Forms.TextBox();
            this.txb_code = new System.Windows.Forms.TextBox();
            this.txb_customeid = new System.Windows.Forms.TextBox();
            this.txb_purchaseid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_status
            // 
            this.txb_status.Location = new System.Drawing.Point(207, 401);
            this.txb_status.Name = "txb_status";
            this.txb_status.Size = new System.Drawing.Size(248, 22);
            this.txb_status.TabIndex = 32;
            this.txb_status.TextChanged += new System.EventHandler(this.txb_status_TextChanged);
            // 
            // txb_quantity
            // 
            this.txb_quantity.Location = new System.Drawing.Point(207, 332);
            this.txb_quantity.Name = "txb_quantity";
            this.txb_quantity.Size = new System.Drawing.Size(248, 22);
            this.txb_quantity.TabIndex = 33;
            // 
            // txb_purchasedate
            // 
            this.txb_purchasedate.Location = new System.Drawing.Point(207, 273);
            this.txb_purchasedate.Name = "txb_purchasedate";
            this.txb_purchasedate.Size = new System.Drawing.Size(248, 22);
            this.txb_purchasedate.TabIndex = 34;
            this.txb_purchasedate.TextChanged += new System.EventHandler(this.txb_purchasedate_TextChanged);
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(207, 211);
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(248, 22);
            this.txb_code.TabIndex = 35;
            // 
            // txb_customeid
            // 
            this.txb_customeid.Location = new System.Drawing.Point(207, 156);
            this.txb_customeid.Name = "txb_customeid";
            this.txb_customeid.Size = new System.Drawing.Size(248, 22);
            this.txb_customeid.TabIndex = 36;
            // 
            // txb_purchaseid
            // 
            this.txb_purchaseid.Location = new System.Drawing.Point(207, 105);
            this.txb_purchaseid.Name = "txb_purchaseid";
            this.txb_purchaseid.Size = new System.Drawing.Size(248, 22);
            this.txb_purchaseid.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 47);
            this.button2.TabIndex = 30;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 47);
            this.button1.TabIndex = 31;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "PurchaseDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "CustomerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "PurchaseID";
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 622);
            this.Controls.Add(this.txb_status);
            this.Controls.Add(this.txb_quantity);
            this.Controls.Add(this.txb_purchasedate);
            this.Controls.Add(this.txb_code);
            this.Controls.Add(this.txb_customeid);
            this.Controls.Add(this.txb_purchaseid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPurchase";
            this.Text = "AddPurchase";
            this.Load += new System.EventHandler(this.AddPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_status;
        private System.Windows.Forms.TextBox txb_quantity;
        private System.Windows.Forms.TextBox txb_purchasedate;
        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.TextBox txb_customeid;
        private System.Windows.Forms.TextBox txb_purchaseid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}