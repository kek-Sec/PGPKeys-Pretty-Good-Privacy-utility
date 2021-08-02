using PGPKeys____Pretty_Good_Privacy_utility._Services;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class Dashboard_Controller
    {
        SelectKey_form select_key_form;
        PGPService pgp = new PGPService();
        HashingService hs = new HashingService();



        /// <summary>
        /// Calls the hashing service to verify the given hash
        /// </summary>
        /// <param name="input">The input hash</param>
        public void CheckFileHash(TextBox input)
        {
            var hash = input.Text;
            if ((hash == string.Empty) || (hash is null))
            {
                return;
            }
            hs.VerifyFileHash(hash);
        }


        public void EncryptClipboard()
        {
           
            select_key_form = new SelectKey_form();
            select_key_form.Show();
            select_key_form.on_clipboard = true;
            select_key_form.action_type = 1;

        }

        public void DecryptClipboard()
        {
            select_key_form = new SelectKey_form();
            select_key_form.Show();
            select_key_form.action_type = 2;
            select_key_form.on_clipboard = true;
        }
    }
}
