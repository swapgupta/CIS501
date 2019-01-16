namespace Sales501
{
    partial class Receipt
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
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxSaleIDLabel = new System.Windows.Forms.Label();
            this.uxItemList = new System.Windows.Forms.ListView();
            this.uxSaleTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Location = new System.Drawing.Point(13, 13);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(36, 13);
            this.uxDateLabel.TabIndex = 0;
            this.uxDateLabel.Text = "Date: ";
            // 
            // uxSaleIDLabel
            // 
            this.uxSaleIDLabel.AutoSize = true;
            this.uxSaleIDLabel.Location = new System.Drawing.Point(13, 30);
            this.uxSaleIDLabel.Name = "uxSaleIDLabel";
            this.uxSaleIDLabel.Size = new System.Drawing.Size(48, 13);
            this.uxSaleIDLabel.TabIndex = 1;
            this.uxSaleIDLabel.Text = "Sale ID: ";
            // 
            // uxItemList
            // 
            this.uxItemList.Location = new System.Drawing.Point(12, 46);
            this.uxItemList.Name = "uxItemList";
            this.uxItemList.Size = new System.Drawing.Size(262, 214);
            this.uxItemList.TabIndex = 2;
            this.uxItemList.UseCompatibleStateImageBehavior = false;
            this.uxItemList.View = System.Windows.Forms.View.Details;
            // 
            // uxSaleTotalLabel
            // 
            this.uxSaleTotalLabel.AutoSize = true;
            this.uxSaleTotalLabel.Location = new System.Drawing.Point(16, 267);
            this.uxSaleTotalLabel.Name = "uxSaleTotalLabel";
            this.uxSaleTotalLabel.Size = new System.Drawing.Size(57, 13);
            this.uxSaleTotalLabel.TabIndex = 3;
            this.uxSaleTotalLabel.Text = "Sale total: ";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.uxSaleTotalLabel);
            this.Controls.Add(this.uxItemList);
            this.Controls.Add(this.uxSaleIDLabel);
            this.Controls.Add(this.uxDateLabel);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.Label uxSaleIDLabel;
        private System.Windows.Forms.ListView uxItemList;
        private System.Windows.Forms.Label uxSaleTotalLabel;
    }
}