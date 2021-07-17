
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.MainForm_tabControl = new System.Windows.Forms.TabControl();
            this.Dashboard_page = new System.Windows.Forms.TabPage();
            this.keychain_page = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keychain_listbox = new System.Windows.Forms.ListBox();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_tabControl.SuspendLayout();
            this.keychain_page.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.keychain_page.Controls.Add(this.toolStrip1);
            this.keychain_page.Controls.Add(this.panel1);
            this.keychain_page.Location = new System.Drawing.Point(4, 30);
            this.keychain_page.Name = "keychain_page";
            this.keychain_page.Size = new System.Drawing.Size(1215, 845);
            this.keychain_page.TabIndex = 1;
            this.keychain_page.Text = "KeyChain";
            this.keychain_page.ToolTipText = "All your PGP keys";
            this.keychain_page.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1215, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.keychain_listbox);
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 604);
            this.panel1.TabIndex = 0;
            // 
            // keychain_listbox
            // 
            this.keychain_listbox.FormattingEnabled = true;
            this.keychain_listbox.ItemHeight = 21;
            this.keychain_listbox.Location = new System.Drawing.Point(0, 6);
            this.keychain_listbox.Name = "keychain_listbox";
            this.keychain_listbox.Size = new System.Drawing.Size(212, 592);
            this.keychain_listbox.TabIndex = 0;
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 668);
            this.Controls.Add(this.MainForm_tabControl);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Form";
            this.Text = "PGPKeys";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.MainForm_tabControl.ResumeLayout(false);
            this.keychain_page.ResumeLayout(false);
            this.keychain_page.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainForm_tabControl;
        private System.Windows.Forms.TabPage Dashboard_page;
        private System.Windows.Forms.TabPage keychain_page;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox keychain_listbox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

