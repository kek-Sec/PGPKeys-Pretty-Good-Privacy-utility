using PgpCore;
using PGPKeys____Pretty_Good_Privacy_utility.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    public partial class Main_Form : Form
    {

        SettingsService settings = new SettingsService();
        KeyChainObject selected_key = new KeyChainObject();

        Clipboard_Controller cc = new Clipboard_Controller();
        Dashboard_Controller dc = new Dashboard_Controller();
        Keychain_Controller kc = new Keychain_Controller();
        Generator_Controller gc = new Generator_Controller();

        public static string clipboard_content = " ";
        public static string clipboard_input = " ";
        public static bool kill_timer = false;

        public Main_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load event called when form is opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Load(object sender, EventArgs e)
        {
            dc.GetVersion(dashboard_version_label);
            dashboard_logger_rtb.ReadOnly = true;
            keychain_logger_rtb.ReadOnly = true;
            generator_output_rtb.ReadOnly = true;
        }

        private void keychain_settings_btn_Click(object sender, EventArgs e)
        {
            kc.ShowSettingsForm();
        }

        #region Button events
        private void generate_button_Click(object sender, EventArgs e)
        {
            gc.Generate(generator_password_txt, generator_email_txt, generator_output_rtb, key_len_2048);
        }
        #endregion

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kc.LoadKeychain(keychain_listbox, keychain_logger_rtb);

            
        }

        private void load_folder_Click(object sender, EventArgs e)
        {
            settings.LoadKeysFolder();
            //load keychain
        }

        private void keychain_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kc.Listbox_Item_Click(selected_key, keychain_emcrypt_btn, keychain_decrypt_btn, keychain_verify_btn, keychain_sign_btn, keychain_listbox,keychain_publickey_status,keychain_privatekey_status);

        }

        private void keychain_paste_btn_Click(object sender, EventArgs e)
        {
            keychain_clipboard_rtb.Text = Clipboard.GetText();
        }

        private void keychain_copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(keychain_clipboard_rtb.Text);

        }

        private void key_len_4096_CheckedChanged(object sender, EventArgs e)
        {
            gc.SetKeySize(4096, key_len_2048);
        }

        private void key_len_2048_CheckedChanged(object sender, EventArgs e)
        {
            gc.SetKeySize(2048, key_len_4096);
        }

        private void keychain_add_btn_Click(object sender, EventArgs e)
        {
            //go to generator
            MainForm_tabControl.SelectedIndex = 2;
        }

        private async void keychain_emcrypt_btn_Click(object sender, EventArgs e)
        {
           await kc.Encrypt(keychain_clipboard_rtb, selected_key,keychain_logger_rtb);
        }

        private void verify_hash_button_Click(object sender, EventArgs e)
        {
            dc.CheckFileHash(hash_textbox,dashboard_logger_rtb);
        }

        private void dashboard_encrypt_button_Click(object sender, EventArgs e)
        {
            dc.EncryptClipboard(dashboard_logger_rtb);
        }

        private void dashboard_decrypt_button_Click(object sender, EventArgs e)
        {
            dc.DecryptClipboard(dashboard_logger_rtb);
        }

        private async void keychain_verify_btn_Click(object sender, EventArgs e)
        {
            await kc.Verify(keychain_clipboard_rtb, selected_key);
        }

        private async void keychain_sign_btn_Click(object sender, EventArgs e)
        {
            await kc.Sign(keychain_clipboard_rtb, selected_key, keychain_logger_rtb);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc.Paste(clipboard_rtb);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc.Copy(clipboard_rtb);
        }

        private void encryptWithPublicKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc.Encrypt(clipboard_rtb,clipboard_timer);

        }


        private void clipboard_timer_Tick(object sender, EventArgs e)
        {
            clipboard_rtb.Text = clipboard_content;
            if(kill_timer) { clipboard_timer.Stop(); }
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            clipboard_timer.Stop();
            var to_tray = settings.getSetting("minimize_to_tray", true);
            if(to_tray) { e.Cancel = true; this.WindowState = FormWindowState.Minimized; }
        }

        private void encryptWithPrivateKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc.Decrypt(clipboard_rtb,clipboard_timer);

        }

        private void importPublicKeyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cc.ImportPublicKey(clipboard_rtb);
        }

        private void importPrivateKeyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cc.ImportPrivateKey(clipboard_rtb);
        }

        private void verifyClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cc.Verify(clipboard_rtb, clipboard_timer);
        }

        private void Main_Form_Resize(object sender, EventArgs e)
        {
            var to_tray = settings.getSetting("minimize_to_tray", true);
            if (this.WindowState == FormWindowState.Minimized && to_tray)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000);
                this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
                this.notifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.MenuExit_Click);
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
