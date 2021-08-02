using PgpCore;
using PGPKeys____Pretty_Good_Privacy_utility._Forms;
using PGPKeys____Pretty_Good_Privacy_utility._Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility._Controllers
{
    class SelectKey_Controller
    {

        SelectKeyService sks = new SelectKeyService();


        /// <summary>
        /// [1] --> Enrcypt
        /// [2] --> Decrypt
        /// [3] --> Sign
        /// </summary>
        /// <param name="action">Action id</param>
        /// <param name="text">The text to act upon</param>
        /// <param name="keyset">The keyset to use</param>
        public async Task<string> resolveActionAsync(int action, string text, KeyChainObject keyset)
        {
            switch (action)
            {
                case 1:
                    return await sks.EncryptAsync(keyset, text);
                case 2:
                    return await sks.DecryptAsync(keyset, text);
                case 3:
                    return await sks.SignAsync(keyset, text);
                default:
                    return null;
            }
        }




    }
}
