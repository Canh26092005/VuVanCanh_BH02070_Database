namespace SaleManagementWinform
{
    partial class Updatepurchase
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
            this.txb_status.Location = new System.Drawing.Point(223, 432);
            this.txb_status.Name = "txb_status";
            this.txb_status.Size = new System.Drawing.Size(248, 22);
            this.txb_status.TabIndex = 46;
            // 
            // txb_quantity
            // 
            this.txb_quantity.Location = new System.Drawing.Point(223, 363);
            this.txb_quantity.Name = "txb_quantity";
            this.txb_quantity.Size = new System.Drawing.Size(248, 22);
            this.txb_quantity.TabIndex = 47;
            // 
            // txb_purchasedate
            // 
            this.txb_purchasedate.Location = new System.Drawing.Point(223, 304);
            this.txb_purchasedate.Name = "txb_purchasedate";
            this.txb_purchasedate.Size = new System.Drawing.Size(248, 22);
            this.txb_purchasedate.TabIndex = 48;
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(223, 242);
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(248, 22);
            this.txb_code.TabIndex = 49;
            // 
            // txb_customeid
            // 
            this.txb_customeid.Location = new System.Drawing.Point(223, 187);
            this.txb_customeid.Name = "txb_customeid";
            this.txb_customeid.Size = new System.Drawing.Size(248, 22);
            this.txb_customeid.TabIndex = 50;
            // 
            // txb_purchaseid
            // 
            this.txb_purchaseid.Location = new System.Drawing.Point(223, 136);
            this.txb_purchaseid.Name = "txb_purchaseid";
            this.txb_purchaseid.Size = new System.Drawing.Size(248, 22);
            this.txb_purchaseid.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 47);
            this.button2.TabIndex = 44;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 47);
            this.button1.TabIndex = 45;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "PurchaseDate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "CustomerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "PurchaseID";
            // 
            // Updatepurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 685);
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
            this.Name = "Updatepurchase";
            this.Text = "Updatepurchase";
            this.Load += new System.EventHandler(this.Updatepurchase_Load);
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