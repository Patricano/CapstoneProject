
namespace RetailEstateApp
{
    partial class FormPropertyListing
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
            this.labelProperty = new System.Windows.Forms.Label();
            this.listBoxProperty = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelProperty.Location = new System.Drawing.Point(12, 9);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(145, 39);
            this.labelProperty.TabIndex = 0;
            this.labelProperty.Text = "Property";
            // 
            // listBoxProperty
            // 
            this.listBoxProperty.FormattingEnabled = true;
            this.listBoxProperty.Location = new System.Drawing.Point(43, 91);
            this.listBoxProperty.Name = "listBoxProperty";
            this.listBoxProperty.Size = new System.Drawing.Size(1126, 420);
            this.listBoxProperty.TabIndex = 1;
            // 
            // FormPropertyListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 847);
            this.Controls.Add(this.listBoxProperty);
            this.Controls.Add(this.labelProperty);
            this.Name = "FormPropertyListing";
            this.Text = "REHE - Property Listing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.ListBox listBoxProperty;
    }
}