using PGPKeys____Pretty_Good_Privacy_utility._Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class Dashboard_Controller
    {

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

    }
}
