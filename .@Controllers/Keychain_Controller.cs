using PgpCore;
using PGPKeys____Pretty_Good_Privacy_utility._Forms;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class Keychain_Controller
    {
        SettingsService settings = new SettingsService();
        KeyChainService keychain = new KeyChainService();


        /// <summary>
        /// Show the settings form
        /// </summary>
        public void ShowSettingsForm()
        {
            Settings_form settings = new Settings_form();
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == "Settings")
                {
                    return;
                }
            }
            settings = new Settings_form();
            settings.Show();
        }

        /// <summary>
        /// Calls the loadkeychain routine from the service
        /// </summary>
        /// <param name="keychain_listbox">Listbox to display keychain</param>
        /// <param name="keychain_logger_rtb">Keychain logger for output</param>
        public void LoadKeychain(ListBox keychain_listbox, RichTextBox keychain_logger_rtb)
        {
            var keys_folder = settings.getSetting("keys_folder_path");

            //clear listbox
            keychain_listbox.Items.Clear();

            if (keys_folder == String.Empty)
            {
                settings.LoadKeysFolder();
                keychain.LoadKeyChain(keys_folder);
                //load keychain
                foreach (KeyChainObject k in keychain.keyChainList)
                {
                    keychain_listbox.Items.Add(k.email);
                }
                FormattableString res = $"Added [{this.keychain.keyChainList.Count}] entries!";
                keychain.AddToLogger(res.ToString(), keychain_logger_rtb);
            }
            else
            {
                keychain.LoadKeyChain(keys_folder);

                //load keycain from settings path
                //load keychain
                foreach (KeyChainObject k in keychain.keyChainList)
                {
                    keychain_listbox.Items.Add(k.email);
                }
                FormattableString res = $"Added [{this.keychain.keyChainList.Count}] entries!";
                keychain.AddToLogger(res.ToString(), keychain_logger_rtb);

            }
        }

        /// <summary>
        /// Called when the selected index of the keychain listbox is triggered
        /// </summary>
        /// <param name="selected_key">Selected keychainobject on the main form</param>
        /// <param name="keychain_emcrypt_btn">Encrypt button</param>
        /// <param name="keychain_decrypt_btn">Decrypt button</param>
        /// <param name="keychain_verify_btn">Verify button</param>
        /// <param name="keychain_sign_btn">Sign button</param>
        /// <param name="keychain_listbox">The listbox</param>
        /// <param name="keychain_publickey_status">status button pub key</param>
        /// <param name="keychain_privatekey_status">status button priv key</param>
        public void Listbox_Item_Click(KeyChainObject selected_key, Button keychain_emcrypt_btn, Button keychain_decrypt_btn, Button keychain_verify_btn, Button keychain_sign_btn, ListBox keychain_listbox, Button keychain_publickey_status, Button keychain_privatekey_status)
        {
            var indx = keychain_listbox.SelectedIndex;
            if (indx == -1) { return; }
            //set current key
            selected_key.email = keychain.keyChainList[indx].email;
            selected_key.private_key = keychain.keyChainList[indx].private_key;
            selected_key.public_key = keychain.keyChainList[indx].public_key;


            keychain_publickey_status.BackColor = Color.LightGreen;
            keychain_privatekey_status.BackColor = Color.LightGreen;

            if (selected_key.private_key == null)
            {
                keychain_privatekey_status.BackColor = Color.DarkGray;
                keychain_emcrypt_btn.Enabled = true;
                keychain_decrypt_btn.Enabled = false;
                keychain_verify_btn.Enabled = true;
                keychain_sign_btn.Enabled = false;
            }
            else
            {
                keychain_emcrypt_btn.Enabled = true;
                keychain_decrypt_btn.Enabled = true;
                keychain_verify_btn.Enabled = true;
                keychain_sign_btn.Enabled = true;

            }
        }

        /// <summary>
        /// Encrypt clipboard
        /// </summary>
        /// <param name="keychain_clipboard_rtb">The clipboard</param>
        /// <param name="selected_key">The selected key</param>
        public async Task Encrypt(RichTextBox keychain_clipboard_rtb, KeyChainObject selected_key)
        {
            var pub_key = selected_key.public_key;
            if (pub_key == null) { return; }


            var clipboard = keychain_clipboard_rtb.Text;

            string publicKey = selected_key.public_key;
            EncryptionKeys encryptionKeys = new EncryptionKeys(publicKey);

            // Encrypt
            PGP pgp = new PGP(encryptionKeys);
            string encryptedContent = await pgp.EncryptArmoredStringAsync(clipboard);
            keychain_clipboard_rtb.Text = encryptedContent;

        }
        /// <summary>
        /// Encrypt clipboard
        /// </summary>
        /// <param name="keychain_clipboard_rtb">The clipboard</param>
        /// <param name="selected_key">The selected key</param>
        public async Task Decrypt(RichTextBox keychain_clipboard_rtb, KeyChainObject selected_key, string password)
        {
            var priv_key = selected_key.private_key;
            if (priv_key == null) { return; }

            // Load keys
            string privateKey = priv_key;
            EncryptionKeys encryptionKeys = new EncryptionKeys(privateKey, password);

            PGP pgp = new PGP(encryptionKeys);

            // Decrypt
            keychain_clipboard_rtb.Text = await pgp.DecryptArmoredStringAsync(keychain_clipboard_rtb.Text);
        }

        /// <summary>
        /// Function for verifying string with public key
        /// </summary>
        /// <param name="keychain_clipboard_rtb">The clipboard rich text box</param>
        /// <param name="selected_key">The selected key</param>
        /// <returns>awaitable task</returns>
        public async Task Verify(RichTextBox keychain_clipboard_rtb, KeyChainObject selected_key)
        {
            // Load keys
            string publicKey = selected_key.public_key;
            EncryptionKeys encryptionKeys = new EncryptionKeys(publicKey);

            PGP pgp = new PGP(encryptionKeys);

            // Verify
            bool verified = await pgp.VerifyClearArmoredStringAsync(keychain_clipboard_rtb.Text);

            if (verified)
            {
                MessageBox.Show("Verified!", " Verified with pub key -> " + selected_key.email, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not verified!", " Failed to verify with pub key -> " + selected_key.email, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Function to sign the text in the clipboard
        /// </summary>
        /// <param name="keychain_clipboard_rtb">The clipboard rich text box</param>
        /// <param name="selected_key">The selected key</param>
        /// <returns>awaitable task</returns>
        public async Task Sign(RichTextBox keychain_clipboard_rtb, KeyChainObject selected_key)
        {
            string privateKey = selected_key.private_key;
            Password_box_Form pbf = new Password_box_Form();
            string password = pbf.Show("Input needed!", "insert password..");
            EncryptionKeys encryptionKeys = new EncryptionKeys(privateKey, password);

            PGP pgp = new PGP(encryptionKeys);

            var clipboard = keychain_clipboard_rtb.Text;

            // Sign
            keychain_clipboard_rtb.Text = await pgp.ClearSignArmoredStringAsync(clipboard);
        }
    }
}
