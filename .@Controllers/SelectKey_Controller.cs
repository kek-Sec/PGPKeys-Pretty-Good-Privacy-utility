using PgpCore;
using PGPKeys____Pretty_Good_Privacy_utility._Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility._Controllers
{
    class SelectKey_Controller
    {

        PGPService pgp = new PGPService();

        /// <summary>
        /// [1] --> Enrcypt
        /// [2] --> Decrypt
        /// [3] --> Sign
        /// </summary>
        /// <param name="action">Action id</param>
        /// <param name="text">The text to act upon</param>
        /// <param name="keyset">The keyset to use</param>
        public async Task<string> resolveActionAsync(int action,string text,KeyChainObject keyset)
        {
            switch (action)
            {
                case 1:
                    return await EncryptAsync(keyset, text);
                case 2:
                    return await DecryptAsync(keyset, text);
                case 3:
                    return await SignAsync(keyset, text);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Encrypt input async
        /// </summary>
        /// <param name="keyset">The keyset used</param>
        /// <param name="plaintext">The text to encrypt</param>
        /// <returns>awaitable string</returns>
        private async Task<string> EncryptAsync(KeyChainObject keyset,string plaintext)
        {
            var pub_key = keyset.public_key;
            if (pub_key == null) { return null; }

            // Encrypt

            string encryptedContent = await pgp.EncryptString(plaintext, pub_key);
            return encryptedContent;
        }

        /// <summary>
        /// Decrypt input async
        /// </summary>
        /// <param name="keyset">The keyset used</param>
        /// <param name="encrypted">The encrypted text</param>
        /// <returns>awaitable String</returns>
        private async Task<string> DecryptAsync(KeyChainObject keyset, string encrypted)
        {
            var priv_key = keyset.private_key;
            if (priv_key == null) { return null; }

            try
            {
                // Load keys
                string privateKey = priv_key;
                Password_box_Form pb = new Password_box_Form();
                string password = pb.Show("Insert key password", "Input needed!");



                // Decrypt
                return await pgp.DecryptString(encrypted, priv_key, password);
            }
            catch(Exception e)
            {
                //to-do write to logger
                MessageBox.Show("Failed to encrypt -> " + e.Message);
                return Clipboard.GetText();
            }
           
        }

        /// <summary>
        /// Sign string async
        /// </summary>
        /// <param name="keyset">The selected key</param>
        /// <param name="plaintext">The plaintext</param>
        /// <returns></returns>
        private async Task<string> SignAsync(KeyChainObject keyset,string plaintext)
        {
            Password_box_Form pbf = new Password_box_Form();
            string password = pbf.Show("Input needed!", "insert password..");
            var privateKey = keyset.private_key;
            if(privateKey is null) { return null; }

            EncryptionKeys encryptionKeys = new EncryptionKeys(privateKey, password);

            PGP pgp = new PGP(encryptionKeys);


            // Sign
            return await pgp.ClearSignArmoredStringAsync(plaintext);
        }
    }
}
