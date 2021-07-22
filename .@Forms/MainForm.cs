using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    public partial class Main_Form : Form
    {
        Settings_form settings_form = new Settings_form();

        SettingsService settings = new SettingsService();
        KeyChainService keychain = new KeyChainService();
        KeyChainObject selected_key = new KeyChainObject();

        Keychain_Controller kc = new Keychain_Controller();
        Generator_Controller gc = new Generator_Controller();

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
            kc.Listbox_Item_Click(selected_key, keychain_emcrypt_btn, keychain_decrypt_btn, keychain_verify_btn, keychain_sign_btn, keychain_listbox);

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
    }
}
