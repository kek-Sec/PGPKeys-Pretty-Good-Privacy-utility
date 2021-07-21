
namespace PGPKeys____Pretty_Good_Privacy_utility
{
    partial class Settings_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.save_keys_path_btn = new System.Windows.Forms.Button();
            this.settings_key_folder_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sessioning_checkbox = new System.Windows.Forms.CheckBox();
            this.on_startup_password_checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.on_startup_checkbox = new System.Windows.Forms.CheckBox();
            this.to_tray_checkbox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 336);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabel1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(401, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 74);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Software info";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 49);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check for updates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version: 1.0.0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.save_keys_path_btn);
            this.groupBox4.Controls.Add(this.settings_key_folder_txt);
            this.groupBox4.Location = new System.Drawing.Point(3, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 201);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filepaths";
            // 
            // save_keys_path_btn
            // 
            this.save_keys_path_btn.BackgroundImage = global::PGPKeys____Pretty_Good_Privacy_utility.Properties.Resources.save_512x512_17843841;
            this.save_keys_path_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_keys_path_btn.Location = new System.Drawing.Point(48, 24);
            this.save_keys_path_btn.Name = "save_keys_path_btn";
            this.save_keys_path_btn.Size = new System.Drawing.Size(134, 138);
            this.save_keys_path_btn.TabIndex = 6;
            this.save_keys_path_btn.Text = "Keys path";
            this.save_keys_path_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.save_keys_path_btn.UseVisualStyleBackColor = true;
            this.save_keys_path_btn.Click += new System.EventHandler(this.save_keys_path_btn_Click);
            // 
            // settings_key_folder_txt
            // 
            this.settings_key_folder_txt.Location = new System.Drawing.Point(0, 168);
            this.settings_key_folder_txt.Name = "settings_key_folder_txt";
            this.settings_key_folder_txt.Size = new System.Drawing.Size(240, 27);
            this.settings_key_folder_txt.TabIndex = 5;
            this.settings_key_folder_txt.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sessioning_checkbox);
            this.groupBox2.Controls.Add(this.on_startup_password_checkbox);
            this.groupBox2.Location = new System.Drawing.Point(249, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Security Settings";
            // 
            // sessioning_checkbox
            // 
            this.sessioning_checkbox.AutoSize = true;
            this.sessioning_checkbox.Location = new System.Drawing.Point(6, 80);
            this.sessioning_checkbox.Name = "sessioning_checkbox";
            this.sessioning_checkbox.Size = new System.Drawing.Size(187, 24);
            this.sessioning_checkbox.TabIndex = 1;
            this.sessioning_checkbox.Text = "No password sessioning";
            this.sessioning_checkbox.UseVisualStyleBackColor = true;
            // 
            // on_startup_password_checkbox
            // 
            this.on_startup_password_checkbox.AutoSize = true;
            this.on_startup_password_checkbox.Location = new System.Drawing.Point(7, 50);
            this.on_startup_password_checkbox.Name = "on_startup_password_checkbox";
            this.on_startup_password_checkbox.Size = new System.Drawing.Size(161, 24);
            this.on_startup_password_checkbox.TabIndex = 0;
            this.on_startup_password_checkbox.Text = "Password on startup";
            this.on_startup_password_checkbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.on_startup_checkbox);
            this.groupBox1.Controls.Add(this.to_tray_checkbox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Settings";
            // 
            // on_startup_checkbox
            // 
            this.on_startup_checkbox.AutoSize = true;
            this.on_startup_checkbox.Location = new System.Drawing.Point(6, 80);
            this.on_startup_checkbox.Name = "on_startup_checkbox";
            this.on_startup_checkbox.Size = new System.Drawing.Size(192, 24);
            this.on_startup_checkbox.TabIndex = 1;
            this.on_startup_checkbox.Text = "Start on windows startup";
            this.on_startup_checkbox.UseVisualStyleBackColor = true;
            // 
            // to_tray_checkbox
            // 
            this.to_tray_checkbox.AutoSize = true;
            this.to_tray_checkbox.Location = new System.Drawing.Point(7, 50);
            this.to_tray_checkbox.Name = "to_tray_checkbox";
            this.to_tray_checkbox.Size = new System.Drawing.Size(226, 24);
            this.to_tray_checkbox.TabIndex = 0;
            this.to_tray_checkbox.Text = "Minimize to tray when closing";
            this.to_tray_checkbox.UseVisualStyleBackColor = true;
            // 
            // Settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 339);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Settings_form";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_form_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox to_tray_checkbox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button save_keys_path_btn;
        private System.Windows.Forms.TextBox settings_key_folder_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox sessioning_checkbox;
        private System.Windows.Forms.CheckBox on_startup_password_checkbox;
        private System.Windows.Forms.CheckBox on_startup_checkbox;
    }
}

