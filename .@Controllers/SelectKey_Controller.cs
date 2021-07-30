using PgpCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGPKeys____Pretty_Good_Privacy_utility._Controllers
{
    class SelectKey_Controller
    {
        /// <summary>
        /// [1] --> Enrcypt
        /// [2] --> Decrypt
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
                    
            }
        }

        private async Task<string> EncryptAsync(KeyChainObject keyset,string plaintext)
        {
            var pub_key = keyset.public_key;
            if (pub_key == null) { return null; }

            EncryptionKeys encryptionKeys = new EncryptionKeys(pub_key);

            // Encrypt
            PGP pgp = new PGP(encryptionKeys);
            string encryptedContent = await pgp.EncryptArmoredStringAsync(plaintext);
            return encryptedContent;
        }

        private async Task<string> DecryptAsync(KeyChainObject keyset, string encrypted)
        {
            var priv_key = keyset.private_key;
            if (priv_key == null) { return null; }

            // Load keys
            string privateKey = priv_key;
            EncryptionKeys encryptionKeys = new EncryptionKeys(privateKey, password);

            PGP pgp = new PGP(encryptionKeys);

            // Decrypt
            keychain_clipboard_rtb.Text = await pgp.DecryptArmoredStringAsync(keychain_clipboard_rtb.Text);
        }
    }
}
