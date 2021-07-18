using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class KeyChainService
    {
        List<KeyChainObject> keyChainList = new List<KeyChainObject>();


        /// <summary>
        /// Add keychainobject to List
        /// </summary>
        /// <param name="item">Object to add</param>
        public void PushToKeyChain(KeyChainObject item)
        {
            keyChainList.Add(item);
        }

        /// <summary>
        /// Clears the keychain list
        /// </summary>
        public void ClearKeyChain()
        {
            keyChainList.Clear();
        }
        
        public async Task<bool> LoadKeyChain(string folderpath)
        {
            await Task.Run(() => {
                return true;
            });
            return false;
        }
    }


    public class KeyChainObject
    {
        public string public_key { get; set; }
        public string private_key { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}
