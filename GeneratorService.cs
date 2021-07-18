using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class GeneratorService
    {

        PGPService pgp = new PGPService();

        public int key_length { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<string> logger_output = new List<string>();

        /// <summary>
        /// Verify that all required variables have been initialized
        /// </summary>
        /// <returns>True if its verified</returns>
        private bool verify()
        {
            if(key_length != default(int) && email != null && password != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Main function that calls the pgp service and does the generation
        /// </summary>
        /// <returns>True if no error occurs</returns>
        public async Task<bool> GenerateKeyPairAsync()
        {
            try
            {
                await pgp.GenerateKey("c:\\keys", email, password, key_length);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        #region generator logger

        /// <summary>
        /// Writes output to logger
        /// </summary>
        /// <param name="s">The string to write</param>
        /// <param name="logger">The logger output rich text box</param>
        public void AddToLogger(string s,RichTextBox logger)
        {
            logger.Clear();
            logger_output.Add(s);
            logger.Text = String.Join("\n", logger_output.ToArray());
        }

        #endregion
    }
}
