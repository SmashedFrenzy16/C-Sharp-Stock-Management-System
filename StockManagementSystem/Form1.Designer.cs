namespace StockManagementSystem
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
            this.listStock = new System.Windows.Forms.Button();
            this.registerStock = new System.Windows.Forms.Button();
            this.deleteStock = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // listStock
            // 
            this.listStock.Location = new System.Drawing.Point(13, 13);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(247, 121);
            this.listStock.TabIndex = 0;
            this.listStock.Text = "List Stock Items";
            this.listStock.UseVisualStyleBackColor = true;
            this.listStock.Click += new System.EventHandler(this.listStock_Click);
            // 
            // registerStock
            // 
            this.registerStock.Location = new System.Drawing.Point(13, 156);
            this.registerStock.Name = "registerStock";
            this.registerStock.Size = new System.Drawing.Size(247, 121);
            this.registerStock.TabIndex = 1;
            this.registerStock.Text = "Register A New Stock Item";
            this.registerStock.UseVisualStyleBackColor = true;
            this.registerStock.Click += new System.EventHandler(this.registerStock_Click);
            // 
            // deleteStock
            // 
            this.deleteStock.Location = new System.Drawing.Point(13, 300);
            this.deleteStock.Name = "deleteStock";
            this.deleteStock.Size = new System.Drawing.Size(247, 121);
            this.deleteStock.TabIndex = 2;
            this.deleteStock.Text = "Delete A Stock Item";
            this.deleteStock.UseVisualStyleBackColor = true;
            this.deleteStock.Click += new System.EventHandler(this.deleteStock_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(397, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(750, 404);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1950, 987);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deleteStock);
            this.Controls.Add(this.registerStock);
            this.Controls.Add(this.listStock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listStock;
        private System.Windows.Forms.Button registerStock;
        private System.Windows.Forms.Button deleteStock;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


