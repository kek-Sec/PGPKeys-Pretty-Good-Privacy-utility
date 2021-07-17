using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PgpCore;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class PGPService
    {
        PGP pgp = new PGP();

        /// <summary>
        /// Task that generates a new key pair
        /// </summary>
        /// <param name="keys_path">The path for the keys folder</param>
        /// <param name="email">user email</param>
        /// <param name="password">user password</param>
        /// <param name="key_length">pgp key length</param>
        /// <returns>awaitable task</returns>
        public async Task GenerateKey(string keys_path,string email,string password,int key_length)
        {
            await Task.Run(() =>
            {
                try
                {
                    pgp.GenerateKeyAsync(keys_path + "\\" + email + "-public.asc", keys_path + "\\" + email + "-private.asc", email, password, key_length);
                }
                catch(Exception e)
                {
                    //log error
                }
            });
        }

        /// <summary>
        /// Task that loads the public key in the current pgp object
        /// </summary>
        /// <param name="pub_key">public key read from file</param>
        /// <returns>awaitable task</returns>
        public async Task LoadPublicKey(string pub_key)
        {
            await Task.Run(() =>
            {
                EncryptionKeys pub = new EncryptionKeys(pub_key);

                this.pgp = new PGP(pub);
            });
        }
    }
}
