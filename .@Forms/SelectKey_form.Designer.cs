
namespace PGPKeys____Pretty_Good_Privacy_utility
{
    partial class SelectKey_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.select_key_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // select_key_listbox
            // 
            this.select_key_listbox.FormattingEnabled = true;
            this.select_key_listbox.ItemHeight = 25;
            this.select_key_listbox.Location = new System.Drawing.Point(3, 2);
            this.select_key_listbox.Name = "select_key_listbox";
            this.select_key_listbox.Size = new System.Drawing.Size(521, 454);
            this.select_key_listbox.TabIndex = 0;
            // 
            // SelectKey_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 459);
            this.Controls.Add(this.select_key_listbox);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SelectKey_form";
            this.Text = "Select key";
            this.Load += new System.EventHandler(this.SelectKey_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox select_key_listbox;
    }
}

