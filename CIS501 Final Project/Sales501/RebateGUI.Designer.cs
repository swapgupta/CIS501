namespace Sales501
{
    partial class RebateGUI
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
            this.uxGenerateRebate = new System.Windows.Forms.Button();
            this.uxEnterRebate = new System.Windows.Forms.Button();
            this.uxSalesIDLabel = new System.Windows.Forms.Label();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxSalesID = new System.Windows.Forms.TextBox();
            this.uxDate = new System.Windows.Forms.TextBox();
            this.uxRebateCheckList = new System.Windows.Forms.ListView();
            this.uxRebateList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxGenerateRebate
            // 
            this.uxGenerateRebate.Location = new System.Drawing.Point(293, 241);
            this.uxGenerateRebate.Name = "uxGenerateRebate";
            this.uxGenerateRebate.Size = new System.Drawing.Size(261, 28);
            this.uxGenerateRebate.TabIndex = 0;
            this.uxGenerateRebate.Text = "Generate Rebate";
            this.uxGenerateRebate.UseVisualStyleBackColor = true;
            this.uxGenerateRebate.Click += new System.EventHandler(this.uxGenerateRebate_Click);
            // 
            // uxEnterRebate
            // 
            this.uxEnterRebate.Location = new System.Drawing.Point(101, 296);
            this.uxEnterRebate.Name = "uxEnterRebate";
            this.uxEnterRebate.Size = new System.Drawing.Size(97, 23);
            this.uxEnterRebate.TabIndex = 1;
            this.uxEnterRebate.Text = "Enter Rebate";
            this.uxEnterRebate.UseVisualStyleBackColor = true;
            this.uxEnterRebate.Click += new System.EventHandler(this.uxEnterRebate_Click);
            // 
            // uxSalesIDLabel
            // 
            this.uxSalesIDLabel.AutoSize = true;
            this.uxSalesIDLabel.Location = new System.Drawing.Point(12, 244);
            this.uxSalesIDLabel.Name = "uxSalesIDLabel";
            this.uxSalesIDLabel.Size = new System.Drawing.Size(53, 13);
            this.uxSalesIDLabel.TabIndex = 2;
            this.uxSalesIDLabel.Text = "Sales ID: ";
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Location = new System.Drawing.Point(12, 273);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(64, 13);
            this.uxDateLabel.TabIndex = 3;
            this.uxDateLabel.Text = "Sale\'s Date:";
            // 
            // uxSalesID
            // 
            this.uxSalesID.Location = new System.Drawing.Point(101, 241);
            this.uxSalesID.Name = "uxSalesID";
            this.uxSalesID.Size = new System.Drawing.Size(100, 20);
            this.uxSalesID.TabIndex = 4;
            // 
            // uxDate
            // 
            this.uxDate.Location = new System.Drawing.Point(101, 270);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(100, 20);
            this.uxDate.TabIndex = 5;
            // 
            // uxRebateCheckList
            // 
            this.uxRebateCheckList.Location = new System.Drawing.Point(293, 53);
            this.uxRebateCheckList.Name = "uxRebateCheckList";
            this.uxRebateCheckList.Size = new System.Drawing.Size(261, 170);
            this.uxRebateCheckList.TabIndex = 6;
            this.uxRebateCheckList.UseCompatibleStateImageBehavior = false;
            this.uxRebateCheckList.View = System.Windows.Forms.View.Details;
            // 
            // uxRebateList
            // 
            this.uxRebateList.Location = new System.Drawing.Point(15, 53);
            this.uxRebateList.Name = "uxRebateList";
            this.uxRebateList.Size = new System.Drawing.Size(261, 170);
            this.uxRebateList.TabIndex = 7;
            this.uxRebateList.UseCompatibleStateImageBehavior = false;
            this.uxRebateList.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ungenerated Rebate Checks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Generated Rebate Checks";
            // 
            // RebateGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxRebateList);
            this.Controls.Add(this.uxRebateCheckList);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.uxSalesID);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.uxSalesIDLabel);
            this.Controls.Add(this.uxEnterRebate);
            this.Controls.Add(this.uxGenerateRebate);
            this.Name = "RebateGUI";
            this.Text = "RebateGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxGenerateRebate;
        private System.Windows.Forms.Button uxEnterRebate;
        private System.Windows.Forms.Label uxSalesIDLabel;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.TextBox uxSalesID;
        private System.Windows.Forms.TextBox uxDate;
        private System.Windows.Forms.ListView uxRebateCheckList;
        private System.Windows.Forms.ListView uxRebateList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}