namespace Sales501
{
    partial class CustomerServiceGUI
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
            this.uxGetSale = new System.Windows.Forms.Button();
            this.uxSalesID = new System.Windows.Forms.TextBox();
            this.uxGetSaleLabel = new System.Windows.Forms.Label();
            this.uxReturnItems = new System.Windows.Forms.Button();
            this.uxItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.uxQuantityLabel = new System.Windows.Forms.Label();
            this.uxCompleteReturn = new System.Windows.Forms.Button();
            this.uxItemList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.uxItemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // uxGetSale
            // 
            this.uxGetSale.Location = new System.Drawing.Point(197, 2);
            this.uxGetSale.Name = "uxGetSale";
            this.uxGetSale.Size = new System.Drawing.Size(90, 27);
            this.uxGetSale.TabIndex = 0;
            this.uxGetSale.Text = "Get Sale";
            this.uxGetSale.UseVisualStyleBackColor = true;
            this.uxGetSale.Click += new System.EventHandler(this.uxGetSale_Click);
            // 
            // uxSalesID
            // 
            this.uxSalesID.Location = new System.Drawing.Point(91, 6);
            this.uxSalesID.Name = "uxSalesID";
            this.uxSalesID.Size = new System.Drawing.Size(100, 20);
            this.uxSalesID.TabIndex = 1;
            // 
            // uxGetSaleLabel
            // 
            this.uxGetSaleLabel.AutoSize = true;
            this.uxGetSaleLabel.Location = new System.Drawing.Point(12, 9);
            this.uxGetSaleLabel.Name = "uxGetSaleLabel";
            this.uxGetSaleLabel.Size = new System.Drawing.Size(73, 13);
            this.uxGetSaleLabel.TabIndex = 2;
            this.uxGetSaleLabel.Text = "Enter Sale ID:";
            // 
            // uxReturnItems
            // 
            this.uxReturnItems.Location = new System.Drawing.Point(188, 260);
            this.uxReturnItems.Name = "uxReturnItems";
            this.uxReturnItems.Size = new System.Drawing.Size(98, 28);
            this.uxReturnItems.TabIndex = 4;
            this.uxReturnItems.Text = "Return Items";
            this.uxReturnItems.UseVisualStyleBackColor = true;
            this.uxReturnItems.Click += new System.EventHandler(this.uxReturnItems_Click);
            // 
            // uxItemQuantity
            // 
            this.uxItemQuantity.Location = new System.Drawing.Point(96, 266);
            this.uxItemQuantity.Name = "uxItemQuantity";
            this.uxItemQuantity.Size = new System.Drawing.Size(86, 20);
            this.uxItemQuantity.TabIndex = 5;
            // 
            // uxQuantityLabel
            // 
            this.uxQuantityLabel.AutoSize = true;
            this.uxQuantityLabel.Location = new System.Drawing.Point(33, 268);
            this.uxQuantityLabel.Name = "uxQuantityLabel";
            this.uxQuantityLabel.Size = new System.Drawing.Size(52, 13);
            this.uxQuantityLabel.TabIndex = 6;
            this.uxQuantityLabel.Text = "Quantity: ";
            // 
            // uxCompleteReturn
            // 
            this.uxCompleteReturn.Location = new System.Drawing.Point(91, 294);
            this.uxCompleteReturn.Name = "uxCompleteReturn";
            this.uxCompleteReturn.Size = new System.Drawing.Size(117, 23);
            this.uxCompleteReturn.TabIndex = 7;
            this.uxCompleteReturn.Text = "Complete Return";
            this.uxCompleteReturn.UseVisualStyleBackColor = true;
            this.uxCompleteReturn.Click += new System.EventHandler(this.uxCompleteReturn_Click);
            // 
            // uxItemList
            // 
            this.uxItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxItemList.FullRowSelect = true;
            this.uxItemList.Location = new System.Drawing.Point(12, 32);
            this.uxItemList.Name = "uxItemList";
            this.uxItemList.Size = new System.Drawing.Size(274, 222);
            this.uxItemList.TabIndex = 8;
            this.uxItemList.UseCompatibleStateImageBehavior = false;
            this.uxItemList.View = System.Windows.Forms.View.Details;
            // 
            // CustomerServiceGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 332);
            this.Controls.Add(this.uxItemList);
            this.Controls.Add(this.uxCompleteReturn);
            this.Controls.Add(this.uxQuantityLabel);
            this.Controls.Add(this.uxItemQuantity);
            this.Controls.Add(this.uxReturnItems);
            this.Controls.Add(this.uxGetSaleLabel);
            this.Controls.Add(this.uxSalesID);
            this.Controls.Add(this.uxGetSale);
            this.Name = "CustomerServiceGUI";
            this.Text = "CustomerServiceGUI";
            ((System.ComponentModel.ISupportInitialize)(this.uxItemQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxGetSale;
        private System.Windows.Forms.TextBox uxSalesID;
        private System.Windows.Forms.Label uxGetSaleLabel;
        private System.Windows.Forms.Button uxReturnItems;
        private System.Windows.Forms.NumericUpDown uxItemQuantity;
        private System.Windows.Forms.Label uxQuantityLabel;
        private System.Windows.Forms.Button uxCompleteReturn;
        private System.Windows.Forms.ListView uxItemList;
    }
}