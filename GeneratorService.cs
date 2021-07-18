using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class GeneratorService
    {

        PGPService pgp = new PGPService();

        public int key_length { get; set; }
        public string email { get; set; }
        public string password { get; set; }


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
    }
}
