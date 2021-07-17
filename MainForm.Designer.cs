
namespace PGPKeys____Pretty_Good_Privacy_utility
{
    partial class Main_Form
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
            this.MainForm_tabControl = new System.Windows.Forms.TabControl();
            this.Dashboard_page = new System.Windows.Forms.TabPage();
            this.keychain_page = new System.Windows.Forms.TabPage();
            this.MainForm_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm_tabControl
            // 
            this.MainForm_tabControl.Controls.Add(this.Dashboard_page);
            this.MainForm_tabControl.Controls.Add(this.keychain_page);
            this.MainForm_tabControl.Location = new System.Drawing.Point(4, 3);
            this.MainForm_tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MainForm_tabControl.Name = "MainForm_tabControl";
            this.MainForm_tabControl.SelectedIndex = 0;
            this.MainForm_tabControl.Size = new System.Drawing.Size(1223, 879);
            this.MainForm_tabControl.TabIndex = 0;
            // 
            // Dashboard_page
            // 
            this.Dashboard_page.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dashboard_page.Location = new System.Drawing.Point(4, 30);
            this.Dashboard_page.Name = "Dashboard_page";
            this.Dashboard_page.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard_page.Size = new System.Drawing.Size(1215, 845);
            this.Dashboard_page.TabIndex = 0;
            this.Dashboard_page.Text = "Dashboard";
            this.Dashboard_page.ToolTipText = "PGPKeys dashboard";
            this.Dashboard_page.UseVisualStyleBackColor = true;
            // 
            // keychain_page
            // 
            this.keychain_page.Location = new System.Drawing.Point(4, 30);
            this.keychain_page.Name = "keychain_page";
            this.keychain_page.Size = new System.Drawing.Size(1215, 845);
            this.keychain_page.TabIndex = 1;
            this.keychain_page.Text = "KeyChain";
            this.keychain_page.ToolTipText = "All your PGP keys";
            this.keychain_page.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 630);
            this.Controls.Add(this.MainForm_tabControl);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Form";
            this.Text = "PGPKeys";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.MainForm_tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainForm_tabControl;
        private System.Windows.Forms.TabPage Dashboard_page;
        private System.Windows.Forms.TabPage keychain_page;
    }
}

