namespace CS2Final
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
            this.rdbCustByName = new System.Windows.Forms.RadioButton();
            this.rdbCustById = new System.Windows.Forms.RadioButton();
            this.rdbInvByPrice = new System.Windows.Forms.RadioButton();
            this.rdbInvById = new System.Windows.Forms.RadioButton();
            this.rdbInvoices = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbInvSold = new System.Windows.Forms.RadioButton();
            this.rdbInvoicesByCust = new System.Windows.Forms.RadioButton();
            this.rtbLeft = new System.Windows.Forms.RichTextBox();
            this.rtbRight = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbCustByName
            // 
            this.rdbCustByName.AutoSize = true;
            this.rdbCustByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCustByName.Location = new System.Drawing.Point(49, 10);
            this.rdbCustByName.Name = "rdbCustByName";
            this.rdbCustByName.Size = new System.Drawing.Size(160, 22);
            this.rdbCustByName.TabIndex = 0;
            this.rdbCustByName.Text = "Customers by name";
            this.rdbCustByName.UseVisualStyleBackColor = true;
            this.rdbCustByName.CheckedChanged += new System.EventHandler(this.RdbCustByName_CheckedChanged);
            // 
            // rdbCustById
            // 
            this.rdbCustById.AutoSize = true;
            this.rdbCustById.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCustById.Location = new System.Drawing.Point(215, 10);
            this.rdbCustById.Name = "rdbCustById";
            this.rdbCustById.Size = new System.Drawing.Size(137, 22);
            this.rdbCustById.TabIndex = 1;
            this.rdbCustById.Text = "Customers by ID";
            this.rdbCustById.UseVisualStyleBackColor = true;
            this.rdbCustById.CheckedChanged += new System.EventHandler(this.RdbCustById_CheckedChanged);
            // 
            // rdbInvByPrice
            // 
            this.rdbInvByPrice.AutoSize = true;
            this.rdbInvByPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInvByPrice.Location = new System.Drawing.Point(49, 38);
            this.rdbInvByPrice.Name = "rdbInvByPrice";
            this.rdbInvByPrice.Size = new System.Drawing.Size(140, 22);
            this.rdbInvByPrice.TabIndex = 2;
            this.rdbInvByPrice.Text = "Inventory by price";
            this.rdbInvByPrice.UseVisualStyleBackColor = true;
            this.rdbInvByPrice.CheckedChanged += new System.EventHandler(this.RdbInvByPrice_CheckedChanged);
            // 
            // rdbInvById
            // 
            this.rdbInvById.AutoSize = true;
            this.rdbInvById.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInvById.Location = new System.Drawing.Point(215, 38);
            this.rdbInvById.Name = "rdbInvById";
            this.rdbInvById.Size = new System.Drawing.Size(122, 22);
            this.rdbInvById.TabIndex = 3;
            this.rdbInvById.Text = "Inventory by ID";
            this.rdbInvById.UseVisualStyleBackColor = true;
            this.rdbInvById.CheckedChanged += new System.EventHandler(this.RdbInvById_CheckedChanged);
            // 
            // rdbInvoices
            // 
            this.rdbInvoices.AutoSize = true;
            this.rdbInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInvoices.Location = new System.Drawing.Point(13, 19);
            this.rdbInvoices.Name = "rdbInvoices";
            this.rdbInvoices.Size = new System.Drawing.Size(80, 22);
            this.rdbInvoices.TabIndex = 4;
            this.rdbInvoices.Text = "Invoices";
            this.rdbInvoices.UseVisualStyleBackColor = true;
            this.rdbInvoices.CheckedChanged += new System.EventHandler(this.RdbInvoices_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbLeft);
            this.panel1.Controls.Add(this.rdbCustByName);
            this.panel1.Controls.Add(this.rdbCustById);
            this.panel1.Controls.Add(this.rdbInvById);
            this.panel1.Controls.Add(this.rdbInvByPrice);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 549);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbRight);
            this.panel2.Controls.Add(this.rdbInvoicesByCust);
            this.panel2.Controls.Add(this.rdbInvSold);
            this.panel2.Controls.Add(this.rdbInvoices);
            this.panel2.Location = new System.Drawing.Point(420, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 549);
            this.panel2.TabIndex = 6;
            // 
            // rdbInvSold
            // 
            this.rdbInvSold.AutoSize = true;
            this.rdbInvSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInvSold.Location = new System.Drawing.Point(99, 20);
            this.rdbInvSold.Name = "rdbInvSold";
            this.rdbInvSold.Size = new System.Drawing.Size(117, 22);
            this.rdbInvSold.TabIndex = 5;
            this.rdbInvSold.Text = "Inventory sold";
            this.rdbInvSold.UseVisualStyleBackColor = true;
            this.rdbInvSold.CheckedChanged += new System.EventHandler(this.RdbInvSold_CheckedChanged);
            // 
            // rdbInvoicesByCust
            // 
            this.rdbInvoicesByCust.AutoSize = true;
            this.rdbInvoicesByCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInvoicesByCust.Location = new System.Drawing.Point(222, 20);
            this.rdbInvoicesByCust.Name = "rdbInvoicesByCust";
            this.rdbInvoicesByCust.Size = new System.Drawing.Size(166, 22);
            this.rdbInvoicesByCust.TabIndex = 6;
            this.rdbInvoicesByCust.Text = "Invoices by customer";
            this.rdbInvoicesByCust.UseVisualStyleBackColor = true;
            this.rdbInvoicesByCust.CheckedChanged += new System.EventHandler(this.RdbInvoicesByCust_CheckedChanged);
            // 
            // rtbLeft
            // 
            this.rtbLeft.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLeft.Location = new System.Drawing.Point(9, 66);
            this.rtbLeft.Name = "rtbLeft";
            this.rtbLeft.Size = new System.Drawing.Size(399, 480);
            this.rtbLeft.TabIndex = 4;
            this.rtbLeft.Text = "";
            // 
            // rtbRight
            // 
            this.rtbRight.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRight.Location = new System.Drawing.Point(3, 66);
            this.rtbRight.Name = "rtbRight";
            this.rtbRight.Size = new System.Drawing.Size(828, 483);
            this.rtbRight.TabIndex = 5;
            this.rtbRight.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CS2 Final";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCustByName;
        private System.Windows.Forms.RadioButton rdbCustById;
        private System.Windows.Forms.RadioButton rdbInvByPrice;
        private System.Windows.Forms.RadioButton rdbInvById;
        private System.Windows.Forms.RadioButton rdbInvoices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbInvoicesByCust;
        private System.Windows.Forms.RadioButton rdbInvSold;
        private System.Windows.Forms.RichTextBox rtbLeft;
        private System.Windows.Forms.RichTextBox rtbRight;
    }
}

