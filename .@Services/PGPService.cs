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

        #region Decryption
        /// <summary>
        /// Decrypt cypher text 
        /// </summary>
        /// <param name="cyphertext">The cyphertext for decryption</param>
        /// <returns></returns>
        public Task<string> DecryptString(string cyphertext,string private_key,string password)
        {
            EncryptionKeys priv = new EncryptionKeys(private_key, password);
            PGP pgp = new PGP(priv);
            return pgp.DecryptArmoredStringAsync(cyphertext);
        }

        /// <summary>
        /// Decrypt file
        /// </summary>
        /// <param name="filepath">The file for decryption</param>
        /// <returns></returns>
        public Task DecryptFile(string filepath,string private_key,string password)
        {
            EncryptionKeys priv = new EncryptionKeys(private_key, password);
            PGP pgp = new PGP(priv);
            var outputpath = filepath.Remove(filepath.Length - 4);
            return pgp.DecryptFileAsync(filepath, outputpath);
        }
        #endregion

        #region Encryption
        /// <summary>
        /// Encrypts plaintext 
        /// </summary>
        /// <param name="plaintext">The plaintext string to encrypt</param>
        /// <returns></returns>
        public Task<string> EncryptString(string plaintext,string publicKey)
        {
                EncryptionKeys encryptionKeys = new EncryptionKeys(publicKey);
                PGP pgp = new PGP(encryptionKeys);
                return pgp.EncryptArmoredStringAsync(plaintext);
        }

        /// <summary>
        /// Encrypt file
        /// </summary>
        /// <param name="filepath">The file to encrypt</param>
        /// <returns></returns>
        public  Task EncryptFile(string filepath,string publicKey)
        {
            EncryptionKeys encryptionKeys = new EncryptionKeys(publicKey);
            PGP pgp = new PGP(encryptionKeys);
            return pgp.EncryptFileAsync(filepath, filepath + ".pgp");
          
        }
        #endregion

        #region signing
        /// <summary>
        /// Sign a file
        /// </summary>
        /// <param name="filepath">The file to sign</param>
        /// <returns></returns>
        public Task SignFile(string filepath,string publickey)
        {
            EncryptionKeys encryptionKeys = new EncryptionKeys(publickey);
            PGP pgp = new PGP(encryptionKeys);
            // Reference input/output files
            FileInfo inputFile = new FileInfo(filepath);
            FileInfo signedFile = new FileInfo(filepath + ".pgp");

           return pgp.ClearSignFileAsync(inputFile, signedFile);
        }

        /// <summary>
        /// Sign text
        /// </summary>
        /// <param name="plaintext">The string to sign</param>
        /// <returns></returns>
        public Task<String> SignText(string plaintext,string publickey)
        {
            
                EncryptionKeys encryptionKeys = new EncryptionKeys(publickey);
                PGP pgp = new PGP(encryptionKeys);
                return pgp.ClearSignArmoredStringAsync(plaintext);
        }
        #endregion

        #region verify

        /// <summary>
        /// Verify file sign
        /// </summary>
        /// <param name="filepath">The file to verify</param>
        /// <returns>True for verified false for not verified or failed</returns>
        public  Task<bool> VerifyFile(string filepath,string publickey)
        {
            FileInfo inputFile = new FileInfo(filepath);
            EncryptionKeys encryptionKeys = new EncryptionKeys(publickey);
            PGP pgp = new PGP(encryptionKeys);
            return pgp.VerifyClearFileAsync(inputFile);
        }

        /// <summary>
        /// Verify string sign
        /// </summary>
        /// <param name="signed_str">The string to verify</param>
        /// <returns>True for verified false for not verified or failed</returns>
        public Task<bool> VerifyString(string signed_str,string privatekey,string password)
        {
            EncryptionKeys priv = new EncryptionKeys(privatekey, password);
            PGP pgp = new PGP(priv);
            return pgp.VerifyClearArmoredStringAsync(signed_str);
        }
        #endregion
    }
}