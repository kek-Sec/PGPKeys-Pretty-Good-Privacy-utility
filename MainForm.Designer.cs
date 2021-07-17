
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.keychain_sign_btn = new System.Windows.Forms.Button();
            this.keychain_verify_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.keychain_decrypt_btn = new System.Windows.Forms.Button();
            this.keychain_emcrypt_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.keychain_privatekey_status = new System.Windows.Forms.Button();
            this.keychain_publickey_status = new System.Windows.Forms.Button();
            this.keychain_toolstrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.importPublicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateKeyPairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keychain_listbox = new System.Windows.Forms.ListBox();
            this.MainForm_tabControl.SuspendLayout();
            this.keychain_page.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.keychain_toolstrip.SuspendLayout();
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
            this.keychain_page.Controls.Add(this.panel4);
            this.keychain_page.Controls.Add(this.panel3);
            this.keychain_page.Controls.Add(this.panel2);
            this.keychain_page.Controls.Add(this.keychain_toolstrip);
            this.keychain_page.Controls.Add(this.panel1);
            this.keychain_page.Location = new System.Drawing.Point(4, 30);
            this.keychain_page.Name = "keychain_page";
            this.keychain_page.Size = new System.Drawing.Size(1215, 845);
            this.keychain_page.TabIndex = 1;
            this.keychain_page.Text = "KeyChain";
            this.keychain_page.ToolTipText = "All your PGP keys";
            this.keychain_page.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.keychain_sign_btn);
            this.panel4.Controls.Add(this.keychain_verify_btn);
            this.panel4.Location = new System.Drawing.Point(641, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 206);
            this.panel4.TabIndex = 4;
            // 
            // keychain_sign_btn
            // 
            this.keychain_sign_btn.BackgroundImage = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources._017_fingerprint;
            this.keychain_sign_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keychain_sign_btn.Location = new System.Drawing.Point(208, 3);
            this.keychain_sign_btn.Name = "keychain_sign_btn";
            this.keychain_sign_btn.Size = new System.Drawing.Size(196, 200);
            this.keychain_sign_btn.TabIndex = 1;
            this.keychain_sign_btn.UseVisualStyleBackColor = true;
            // 
            // keychain_verify_btn
            // 
            this.keychain_verify_btn.BackgroundImage = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources._035_protection;
            this.keychain_verify_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keychain_verify_btn.Location = new System.Drawing.Point(3, 3);
            this.keychain_verify_btn.Name = "keychain_verify_btn";
            this.keychain_verify_btn.Size = new System.Drawing.Size(199, 200);
            this.keychain_verify_btn.TabIndex = 0;
            this.keychain_verify_btn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.keychain_decrypt_btn);
            this.panel3.Controls.Add(this.keychain_emcrypt_btn);
            this.panel3.Location = new System.Drawing.Point(222, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 206);
            this.panel3.TabIndex = 3;
            // 
            // keychain_decrypt_btn
            // 
            this.keychain_decrypt_btn.BackgroundImage = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources._044_unlock;
            this.keychain_decrypt_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keychain_decrypt_btn.Location = new System.Drawing.Point(211, 3);
            this.keychain_decrypt_btn.Name = "keychain_decrypt_btn";
            this.keychain_decrypt_btn.Size = new System.Drawing.Size(199, 200);
            this.keychain_decrypt_btn.TabIndex = 1;
            this.keychain_decrypt_btn.UseVisualStyleBackColor = true;
            // 
            // keychain_emcrypt_btn
            // 
            this.keychain_emcrypt_btn.BackgroundImage = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources._025_lock;
            this.keychain_emcrypt_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keychain_emcrypt_btn.Location = new System.Drawing.Point(3, 3);
            this.keychain_emcrypt_btn.Name = "keychain_emcrypt_btn";
            this.keychain_emcrypt_btn.Size = new System.Drawing.Size(202, 200);
            this.keychain_emcrypt_btn.TabIndex = 0;
            this.keychain_emcrypt_btn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.keychain_privatekey_status);
            this.panel2.Controls.Add(this.keychain_publickey_status);
            this.panel2.Location = new System.Drawing.Point(222, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 56);
            this.panel2.TabIndex = 2;
            // 
            // keychain_privatekey_status
            // 
            this.keychain_privatekey_status.Enabled = false;
            this.keychain_privatekey_status.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keychain_privatekey_status.Location = new System.Drawing.Point(412, 0);
            this.keychain_privatekey_status.Name = "keychain_privatekey_status";
            this.keychain_privatekey_status.Size = new System.Drawing.Size(414, 56);
            this.keychain_privatekey_status.TabIndex = 1;
            this.keychain_privatekey_status.Text = "PRIVATE KEY";
            this.keychain_privatekey_status.UseVisualStyleBackColor = true;
            // 
            // keychain_publickey_status
            // 
            this.keychain_publickey_status.Enabled = false;
            this.keychain_publickey_status.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keychain_publickey_status.Location = new System.Drawing.Point(0, 0);
            this.keychain_publickey_status.Name = "keychain_publickey_status";
            this.keychain_publickey_status.Size = new System.Drawing.Size(413, 56);
            this.keychain_publickey_status.TabIndex = 0;
            this.keychain_publickey_status.Text = "PUBLIC KEY";
            this.keychain_publickey_status.UseVisualStyleBackColor = true;
            // 
            // keychain_toolstrip
            // 
            this.keychain_toolstrip.AllowItemReorder = true;
            this.keychain_toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2});
            this.keychain_toolstrip.Location = new System.Drawing.Point(0, 0);
            this.keychain_toolstrip.Name = "keychain_toolstrip";
            this.keychain_toolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.keychain_toolstrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.keychain_toolstrip.Size = new System.Drawing.Size(1215, 25);
            this.keychain_toolstrip.TabIndex = 1;
            this.keychain_toolstrip.Text = "keychain-menu";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources.message_box_512x512_2194194;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources.history_512x512_1214668;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exportToolStripMenuItem.Text = "Load";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources.save_512x512_1784384;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.importToolStripMenuItem.Text = "Save";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources.sync_512x512_1214660;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importPublicKeyToolStripMenuItem,
            this.importPrivateKeyToolStripMenuItem,
            this.generateKeyPairToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources.key_512x512_1214374;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // importPublicKeyToolStripMenuItem
            // 
            this.importPublicKeyToolStripMenuItem.Image = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources._025_lock1;
            this.importPublicKeyToolStripMenuItem.Name = "importPublicKeyToolStripMenuItem";
            this.importPublicKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importPublicKeyToolStripMenuItem.Text = "Import public key";
            // 
            // importPrivateKeyToolStripMenuItem
            // 
            this.importPrivateKeyToolStripMenuItem.Image = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources._044_unlock1;
            this.importPrivateKeyToolStripMenuItem.Name = "importPrivateKeyToolStripMenuItem";
            this.importPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importPrivateKeyToolStripMenuItem.Text = "Import private key";
            // 
            // generateKeyPairToolStripMenuItem
            // 
            this.generateKeyPairToolStripMenuItem.Image = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources._023_key;
            this.generateKeyPairToolStripMenuItem.Name = "generateKeyPairToolStripMenuItem";
            this.generateKeyPairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateKeyPairToolStripMenuItem.Text = "Generate key pair";
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
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.keychain_toolstrip.ResumeLayout(false);
            this.keychain_toolstrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainForm_tabControl;
        private System.Windows.Forms.TabPage Dashboard_page;
        private System.Windows.Forms.TabPage keychain_page;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox keychain_listbox;
        private System.Windows.Forms.ToolStrip keychain_toolstrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button keychain_privatekey_status;
        private System.Windows.Forms.Button keychain_publickey_status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button keychain_decrypt_btn;
        private System.Windows.Forms.Button keychain_emcrypt_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button keychain_sign_btn;
        private System.Windows.Forms.Button keychain_verify_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem importPublicKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPrivateKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateKeyPairToolStripMenuItem;
    }
}

