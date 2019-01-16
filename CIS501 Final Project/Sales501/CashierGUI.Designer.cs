namespace Sales501
{
    partial class CashierGUI
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Item", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Price", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Item", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Price", System.Windows.Forms.HorizontalAlignment.Left);
            this.uxItemLabel = new System.Windows.Forms.Label();
            this.uxCartLabel = new System.Windows.Forms.Label();
            this.uxAddItem = new System.Windows.Forms.Button();
            this.uxRemoveItem = new System.Windows.Forms.Button();
            this.uxCheckout = new System.Windows.Forms.Button();
            this.uxQuantity = new System.Windows.Forms.NumericUpDown();
            this.uxItemQuantity = new System.Windows.Forms.Label();
            this.uxRemoveQuantity = new System.Windows.Forms.NumericUpDown();
            this.uxCartQuantity = new System.Windows.Forms.Label();
            this.uxItems = new System.Windows.Forms.ListView();
            this.uxCart = new System.Windows.Forms.ListView();
            this.uxTotalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRemoveQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // uxItemLabel
            // 
            this.uxItemLabel.AutoSize = true;
            this.uxItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxItemLabel.Location = new System.Drawing.Point(131, 38);
            this.uxItemLabel.Name = "uxItemLabel";
            this.uxItemLabel.Size = new System.Drawing.Size(59, 25);
            this.uxItemLabel.TabIndex = 0;
            this.uxItemLabel.Text = "Items";
            // 
            // uxCartLabel
            // 
            this.uxCartLabel.AutoSize = true;
            this.uxCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCartLabel.Location = new System.Drawing.Point(435, 38);
            this.uxCartLabel.Name = "uxCartLabel";
            this.uxCartLabel.Size = new System.Drawing.Size(138, 25);
            this.uxCartLabel.TabIndex = 1;
            this.uxCartLabel.Text = "Shopping Cart";
            // 
            // uxAddItem
            // 
            this.uxAddItem.Location = new System.Drawing.Point(93, 435);
            this.uxAddItem.Name = "uxAddItem";
            this.uxAddItem.Size = new System.Drawing.Size(127, 44);
            this.uxAddItem.TabIndex = 4;
            this.uxAddItem.Text = "AddItem";
            this.uxAddItem.UseVisualStyleBackColor = true;
            this.uxAddItem.Click += new System.EventHandler(this.uxAddItem_Click);
            // 
            // uxRemoveItem
            // 
            this.uxRemoveItem.Location = new System.Drawing.Point(440, 435);
            this.uxRemoveItem.Name = "uxRemoveItem";
            this.uxRemoveItem.Size = new System.Drawing.Size(127, 44);
            this.uxRemoveItem.TabIndex = 5;
            this.uxRemoveItem.Text = "Remove Item";
            this.uxRemoveItem.UseVisualStyleBackColor = true;
            this.uxRemoveItem.Click += new System.EventHandler(this.uxRemoveItem_Click);
            // 
            // uxCheckout
            // 
            this.uxCheckout.Location = new System.Drawing.Point(387, 485);
            this.uxCheckout.Name = "uxCheckout";
            this.uxCheckout.Size = new System.Drawing.Size(127, 44);
            this.uxCheckout.TabIndex = 6;
            this.uxCheckout.Text = "Checkout";
            this.uxCheckout.UseVisualStyleBackColor = true;
            this.uxCheckout.Click += new System.EventHandler(this.uxCheckout_Click);
            // 
            // uxQuantity
            // 
            this.uxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxQuantity.Location = new System.Drawing.Point(187, 390);
            this.uxQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxQuantity.Name = "uxQuantity";
            this.uxQuantity.Size = new System.Drawing.Size(120, 30);
            this.uxQuantity.TabIndex = 7;
            this.uxQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxItemQuantity
            // 
            this.uxItemQuantity.AutoSize = true;
            this.uxItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxItemQuantity.Location = new System.Drawing.Point(20, 394);
            this.uxItemQuantity.Name = "uxItemQuantity";
            this.uxItemQuantity.Size = new System.Drawing.Size(91, 25);
            this.uxItemQuantity.TabIndex = 8;
            this.uxItemQuantity.Text = "Quantity:";
            // 
            // uxRemoveQuantity
            // 
            this.uxRemoveQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemoveQuantity.Location = new System.Drawing.Point(529, 392);
            this.uxRemoveQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxRemoveQuantity.Name = "uxRemoveQuantity";
            this.uxRemoveQuantity.Size = new System.Drawing.Size(120, 30);
            this.uxRemoveQuantity.TabIndex = 9;
            this.uxRemoveQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxCartQuantity
            // 
            this.uxCartQuantity.AutoSize = true;
            this.uxCartQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCartQuantity.Location = new System.Drawing.Point(362, 397);
            this.uxCartQuantity.Name = "uxCartQuantity";
            this.uxCartQuantity.Size = new System.Drawing.Size(91, 25);
            this.uxCartQuantity.TabIndex = 10;
            this.uxCartQuantity.Text = "Quantity:";
            // 
            // uxItems
            // 
            this.uxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxItems.FullRowSelect = true;
            this.uxItems.GridLines = true;
            listViewGroup1.Header = "Item";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Price";
            listViewGroup2.Name = "listViewGroup2";
            this.uxItems.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.uxItems.Location = new System.Drawing.Point(25, 82);
            this.uxItems.MultiSelect = false;
            this.uxItems.Name = "uxItems";
            this.uxItems.Size = new System.Drawing.Size(282, 302);
            this.uxItems.TabIndex = 11;
            this.uxItems.UseCompatibleStateImageBehavior = false;
            this.uxItems.View = System.Windows.Forms.View.Details;
            // 
            // uxCart
            // 
            this.uxCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCart.FullRowSelect = true;
            this.uxCart.GridLines = true;
            listViewGroup3.Header = "Item";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "Price";
            listViewGroup4.Name = "listViewGroup2";
            this.uxCart.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.uxCart.Location = new System.Drawing.Point(367, 82);
            this.uxCart.MultiSelect = false;
            this.uxCart.Name = "uxCart";
            this.uxCart.Size = new System.Drawing.Size(282, 302);
            this.uxCart.TabIndex = 12;
            this.uxCart.UseCompatibleStateImageBehavior = false;
            this.uxCart.View = System.Windows.Forms.View.Details;
            // 
            // uxTotalCost
            // 
            this.uxTotalCost.AutoSize = true;
            this.uxTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTotalCost.Location = new System.Drawing.Point(182, 492);
            this.uxTotalCost.Name = "uxTotalCost";
            this.uxTotalCost.Size = new System.Drawing.Size(113, 25);
            this.uxTotalCost.TabIndex = 13;
            this.uxTotalCost.Text = "Total Cost: ";
            // 
            // CashierGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 553);
            this.Controls.Add(this.uxTotalCost);
            this.Controls.Add(this.uxCart);
            this.Controls.Add(this.uxItems);
            this.Controls.Add(this.uxCartQuantity);
            this.Controls.Add(this.uxRemoveQuantity);
            this.Controls.Add(this.uxItemQuantity);
            this.Controls.Add(this.uxQuantity);
            this.Controls.Add(this.uxCheckout);
            this.Controls.Add(this.uxRemoveItem);
            this.Controls.Add(this.uxAddItem);
            this.Controls.Add(this.uxCartLabel);
            this.Controls.Add(this.uxItemLabel);
            this.Name = "CashierGUI";
            this.Text = "CashierGUI";
            ((System.ComponentModel.ISupportInitialize)(this.uxQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRemoveQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxItemLabel;
        private System.Windows.Forms.Label uxCartLabel;
        private System.Windows.Forms.Button uxAddItem;
        private System.Windows.Forms.Button uxRemoveItem;
        private System.Windows.Forms.Button uxCheckout;
        private System.Windows.Forms.NumericUpDown uxQuantity;
        private System.Windows.Forms.Label uxItemQuantity;
        private System.Windows.Forms.NumericUpDown uxRemoveQuantity;
        private System.Windows.Forms.Label uxCartQuantity;
        private System.Windows.Forms.ListView uxItems;
        private System.Windows.Forms.Label uxTotalCost;
        private System.Windows.Forms.ListView uxCart;
    }
}