namespace RetailEstateApp
{
    partial class FormSearch
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
            this.searchPropertyLabel = new System.Windows.Forms.Label();
            this.propertySearchTextBox = new System.Windows.Forms.TextBox();
            this.propertSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchPropertyLabel
            // 
            this.searchPropertyLabel.AutoSize = true;
            this.searchPropertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.searchPropertyLabel.Location = new System.Drawing.Point(462, 133);
            this.searchPropertyLabel.Name = "searchPropertyLabel";
            this.searchPropertyLabel.Size = new System.Drawing.Size(309, 46);
            this.searchPropertyLabel.TabIndex = 1;
            this.searchPropertyLabel.Text = "Search Property";
            this.searchPropertyLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // propertySearchTextBox
            // 
            this.propertySearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.propertySearchTextBox.Location = new System.Drawing.Point(451, 230);
            this.propertySearchTextBox.Name = "propertySearchTextBox";
            this.propertySearchTextBox.Size = new System.Drawing.Size(320, 32);
            this.propertySearchTextBox.TabIndex = 2;
            // 
            // propertSearchButton
            // 
            this.propertSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.propertSearchButton.Location = new System.Drawing.Point(800, 230);
            this.propertSearchButton.Name = "propertSearchButton";
            this.propertSearchButton.Size = new System.Drawing.Size(81, 32);
            this.propertSearchButton.TabIndex = 3;
            this.propertSearchButton.Text = "Search";
            this.propertSearchButton.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 694);
            this.Controls.Add(this.propertSearchButton);
            this.Controls.Add(this.propertySearchTextBox);
            this.Controls.Add(this.searchPropertyLabel);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REHE- Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label searchPropertyLabel;
        private System.Windows.Forms.TextBox propertySearchTextBox;
        private System.Windows.Forms.Button propertSearchButton;
    }
}