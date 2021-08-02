using PgpCore;
using PGPKeys____Pretty_Good_Privacy_utility._Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility._Services
{
    class SelectKeyService
    {
        PGPService pgp = new PGPService();


        /// <summary>
        /// Encrypt input async
        /// </summary>
        /// <param name="keyset">The keyset used</param>
        /// <param name="plaintext">The text to encrypt</param>
        /// <returns>awaitable string</returns>
        public async Task<string> EncryptAsync(KeyChainObject keyset, string plaintext)
        {
            var pub_key = keyset.public_key;
            if (pub_key == null) { return null; }

            // Encrypt

            string encryptedContent = await pgp.EncryptString(plaintext, pub_key);
            return encryptedContent;
        }



        /// <summary>
        /// Sign string async
        /// </summary>
        /// <param name="keyset">The selected key</param>
        /// <param name="plaintext">The plaintext</param>
        /// <returns></returns>
        public async Task<string> SignAsync(KeyChainObject keyset, string plaintext)
        {
            Password_box_Form pbf = new Password_box_Form();
            string password = pbf.Show("Input needed!", "insert password..");
            var privateKey = keyset.private_key;
            if (privateKey is null) { return null; }

            EncryptionKeys encryptionKeys = new EncryptionKeys(privateKey, password);

            PGP pgp = new PGP(encryptionKeys);


            // Sign
            return await pgp.ClearSignArmoredStringAsync(plaintext);
        }

        /// <summary>
        /// Verify string async
        /// </summary>
        /// <param name="keyset">The selected key</param>
        /// <param name="plaintext">The plaintext</param>
        /// <returns></returns>
        public async Task<string> VerifyAsync(KeyChainObject keyset, string plaintext)
        {
            var pub = keyset.public_key;
            if (pub is null) { return null; }

            EncryptionKeys encryptionKeys = new EncryptionKeys(pub);

            PGP pgp = new PGP(encryptionKeys);


            // Sign
            if (await pgp.VerifyArmoredStringAsync(plaintext))
            {
                MessageBox.Show("Verified!", " It's a match!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return plaintext;
            }
            MessageBox.Show("Not verified!", " It's NOT a match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return plaintext;
        }

        /// <summary>
        /// Decrypt input async
        /// </summary>
        /// <param name="keyset">The keyset used</param>
        /// <param name="encrypted">The encrypted text</param>
        /// <returns>awaitable String</returns>
        public async Task<string> DecryptAsync(KeyChainObject keyset, string encrypted)
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
            catch (Exception e)
            {
                //to-do write to logger
                MessageBox.Show("Failed to encrypt -> " + e.Message);
                return Clipboard.GetText();
            }

        }
    }
}
