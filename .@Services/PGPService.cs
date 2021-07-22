using System;
using System.Collections.Generic;
using System.IO;
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
        public async Task GenerateKey(string keys_path, string email, string password, int key_length)
        {
            await Task.Run(() => {
                try
                {
                    pgp.GenerateKeyAsync(keys_path + "\\" + email + "-public.asc", keys_path + "\\" + email + "-private.asc", email, password, key_length);
                }
                catch (Exception e)
                {
                    //log error
                }
            });
        }


        /// <summary>
        /// Loads private key
        /// </summary>
        /// <param name="private_key">Private key file content</param>
        /// <param name="password">password for the key</param>
        /// <returns></returns>
        public async Task LoadPrivateKey(string private_key, string password)
        {
            await Task.Run(() => {
                FileInfo privateKey = new FileInfo(private_key);
                EncryptionKeys pub = new EncryptionKeys(privateKey, password);

                this.pgp = new PGP(pub);
            });
        }

        #region Decryption
        /// <summary>
        /// Decrypt cypher text 
        /// </summary>
        /// <param name="cyphertext">The cyphertext for decryption</param>
        /// <returns></returns>
        public async Task<String> DecryptString(string cyphertext)
        {
            await Task.Run(() => {
                return pgp.DecryptArmoredStringAsync(cyphertext);
            });
            return null;
        }

        /// <summary>
        /// Decrypt file
        /// </summary>
        /// <param name="filepath">The file for decryption</param>
        /// <returns></returns>
        public async Task DecryptFile(string filepath)
        {
            await Task.Run(() => {
                var outputpath = filepath.Remove(filepath.Length - 4);
                pgp.DecryptFileAsync(filepath, outputpath);
            });
        }
        #endregion

        #region Encryption
        /// <summary>
        /// Encrypts plaintext 
        /// </summary>
        /// <param name="plaintext">The plaintext string to encrypt</param>
        /// <returns></returns>
        public async Task<string> EncryptString(string plaintext,string publicKey)
        {
            await Task.Run(() => {
                EncryptionKeys encryptionKeys = new EncryptionKeys(publicKey);
                PGP pgp = new PGP(encryptionKeys);
                return pgp.EncryptArmoredStringAsync(plaintext);
            });
            return null;
        }

        /// <summary>
        /// Encrypt file
        /// </summary>
        /// <param name="filepath">The file to encrypt</param>
        /// <returns></returns>
        public async Task<string> EncryptFile(string filepath)
        {
            await Task.Run(() => {
                return pgp.EncryptFileAsync(filepath, filepath + ".pgp");
            });
            return null;
        }
        #endregion

        #region signing
        /// <summary>
        /// Sign a file
        /// </summary>
        /// <param name="filepath">The file to sign</param>
        /// <returns></returns>
        public async Task SignFile(string filepath)
        {
            await Task.Run(() => {
                // Reference input/output files
                FileInfo inputFile = new FileInfo(filepath);
                FileInfo signedFile = new FileInfo(filepath + ".pgp");

                pgp.ClearSignFileAsync(inputFile, signedFile);
            });
        }

        /// <summary>
        /// Sign text
        /// </summary>
        /// <param name="plaintext">The string to sign</param>
        /// <returns></returns>
        public async Task<String> SignText(string plaintext)
        {
            await Task.Run(() => {
                return pgp.ClearSignArmoredStringAsync(plaintext);
            });
            return null;
        }
        #endregion

        #region verify

        /// <summary>
        /// Verify file sign
        /// </summary>
        /// <param name="filepath">The file to verify</param>
        /// <returns>True for verified false for not verified or failed</returns>
        public async Task<bool> VerifyFile(string filepath)
        {
            await Task.Run(() => {
                FileInfo inputFile = new FileInfo(filepath);

                return pgp.VerifyClearFileAsync(inputFile);
            });
            return false;
        }

        /// <summary>
        /// Verify string sign
        /// </summary>
        /// <param name="signed_str">The string to verify</param>
        /// <returns>True for verified false for not verified or failed</returns>
        public async Task<bool> VerifyString(string signed_str)
        {
            await Task.Run(() => {
                return pgp.VerifyClearArmoredStringAsync(signed_str);
            });
            return false;
        }
        #endregion
    }
}