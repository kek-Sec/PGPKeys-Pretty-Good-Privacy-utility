using PGPKeys____Pretty_Good_Privacy_utility._Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class Dashboard_Controller
    {
        List<String> log = new List<String>();
        SelectKey_form select_key_form;
        PGPService pgp = new PGPService();
        HashingService hs = new HashingService();
        VersionControlService vcs = new VersionControlService();

        public void GetVersion(Label version_label)
        {
            version_label.Text = "Version: " + vcs.current_version;
        }

        /// <summary>
        /// Calls the hashing service to verify the given hash
        /// </summary>
        /// <param name="input">The input hash</param>
        public void CheckFileHash(TextBox input, RichTextBox logger)
        {
            var hash = input.Text;
            if ((hash == string.Empty) || (hash is null))
            {
                return;
            }
            string file_hash = hs.VerifyFileHash(hash);
            log.Add("File gave the following hash...");
            log.Add(file_hash);
            logger.Text = String.Join("\n ", log.ToArray());
        }


        public void EncryptClipboard(RichTextBox logger)
        {

            select_key_form = new SelectKey_form();
            select_key_form.Show();
            select_key_form.on_clipboard = true;
            select_key_form.action_type = 1;
            log.Add("Encrypting clipboard...");
            logger.Text = String.Join("\n ", log.ToArray());

        }

        public void DecryptClipboard(RichTextBox logger)
        {
            select_key_form = new SelectKey_form();
            select_key_form.Show();
            select_key_form.action_type = 2;
            select_key_form.on_clipboard = true;
            log.Add("Decrypting clipboard...");
            logger.Text = String.Join("\n ", log.ToArray());
        }
    }
}
