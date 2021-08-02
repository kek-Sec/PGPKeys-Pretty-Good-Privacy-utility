using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility._Services
{
    class HashingService
    {

        public void VerifyFileHash(string given_hash)
        {
            var filepath = LoadFile();

            var is_md5 = IsMD5(given_hash);

            string file_hash;

            if (is_md5)
            {
                file_hash = CalculateMD5(filepath);
            }
            else
            {
                file_hash = SHA256CheckSum(filepath);
            }

            if (given_hash.Equals(file_hash, StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("Verified!", " hashes match!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Not verified!", " hashes do not match!", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        /// <summary>
        /// Promts the user to select a file
        /// </summary>
        /// <returns>The filepath</returns>
        private string LoadFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                return selectedFileName;
            }
            return null;
        }

        /// <summary>
        /// Simple regex to recognize hash type
        /// </summary>
        /// <param name="input">The hash in string format</param>
        /// <returns>True if hash is md5</returns>
        private bool IsMD5(string input)
        {
            return Regex.IsMatch(input, "^[0-9a-fA-F]{32}$", RegexOptions.Compiled);
        }

        /// <summary>
        /// Calculate the md5 hash of a file
        /// </summary>
        /// <param name="filename">The file</param>
        /// <returns>string formatted md5 hash</returns>
        private string CalculateMD5(string filename)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filename);
            var hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }

        /// <summary>
        /// Get sha256 hash signature from file
        /// </summary>
        /// <param name="filePath">The file path</param>
        /// <returns>hash in string</returns>
        private string SHA256CheckSum(string filePath)
        {
            SHA256 Sha256 = SHA256.Create();
            byte[] hash;
            using FileStream stream = File.OpenRead(filePath);
            hash = Sha256.ComputeHash(stream);
            string result = "";
            foreach (byte b in hash) result += b.ToString("x2");
            return result;
        }
    }
}
