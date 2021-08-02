using System;
using System.IO;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility.@Controllers
{
    class Clipboard_Controller
    {
        SelectKey_form select_key_form;
        SettingsService settings = new SettingsService();

        /// <summary>
        /// Paste to the rtb
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        public void Paste(RichTextBox rtb)
        {
            rtb.Text = Clipboard.GetText();
        }

        /// <summary>
        /// Copy from the rtb
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        public void Copy(RichTextBox rtb)
        {
            Clipboard.SetText(rtb.Text);
        }

        /// <summary>
        /// Enrcypt the clipboard rich text box content
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        /// <param name="clipboard_timer">The timer used to refresh the rtb</param>
        public void Encrypt(RichTextBox rtb, Timer clipboard_timer)
        {
            Main_Form.kill_timer = false;
            clipboard_timer.Start();
            select_key_form = new SelectKey_form();
            select_key_form.Show();
            select_key_form.action_type = 1;
            select_key_form.on_clipboard = false;
            select_key_form.input = rtb.Text;
        }

        /// <summary>
        /// Decrpyt the clipboard rich text box content
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        /// <param name="clipboard_timer">The timer used to refresh the rtb</param>
        public void Decrypt(RichTextBox rtb, Timer clipboard_timer)
        {
            Main_Form.kill_timer = false;
            clipboard_timer.Start();
            select_key_form = new SelectKey_form();
            select_key_form.input = rtb.Text;
            select_key_form.Show();
            select_key_form.action_type = 2;
            select_key_form.on_clipboard = false;
        }

        /// <summary>
        /// Create a new public key file
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        public void ImportPrivateKey(RichTextBox rtb)
        {
            //make sure input is privatekey
            var input = rtb.Text;

            if (!input.StartsWith("-----BEGIN PGP PRIVATE KEY BLOCK-----"))
            {
                MessageBox.Show("Input does not match private key format..");
                return;
            }

            var keys_folder = settings.getSetting("keys_folder_path");

            try
            {
                var filename = DateTime.Now.ToString("MM-dd-mm-ss") + "-private.asc";
                File.WriteAllText(keys_folder + "\\" + filename, input);
                MessageBox.Show("Private key imported at: \n " + filename);
                rtb.Text = " ";

            }
            catch (Exception e)
            {
                return;
            }
        }

        /// <summary>
        /// Creates a new private key file
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        public void ImportPublicKey(RichTextBox rtb)
        {
            //make sure input is publickey
            var input = rtb.Text;

            if (!input.StartsWith("-----BEGIN PGP PUBLIC KEY BLOCK-----"))
            {
                MessageBox.Show("Input does not match public key format..");
                return;
            }

            var keys_folder = settings.getSetting("keys_folder_path");

            try
            {
                var filename = DateTime.Now.ToString("MM-dd-mm-ss") + "-public.asc";
                File.WriteAllText(keys_folder + "\\" + filename, input);
                MessageBox.Show("Public key imported at: \n " + filename);
                rtb.Text = " ";
            }
            catch (Exception e)
            {
                return;
            }
        }
    }
}
