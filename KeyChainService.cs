using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class KeyChainService
    {
        List<KeyChainObject> keyChainList;


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
            await Task.Run(async () =>
            {
                if (!Directory.Exists(folderpath)) { return false; }

                List<String> private_keys = await DiscoverPrivateKeys(folderpath);
                List<String> public_keys = await DiscoverPublicKeys(folderpath);

                List<String> private_keys_clean = new List<String>();
                List<String> public_keys_clean = new List<String>();

                //Create new keychain list
                keyChainList = new List<KeyChainObject>();

                //cleanup filenames
                for(int i=0;i<private_keys.Count;i++)
                {
                    private_keys_clean.Add(private_keys[i].Split('-')[0]);
                }
                for(int j=0;j<public_keys.Count;j++)
                {
                    public_keys_clean.Add(public_keys[j].Split('-')[0]);
                }

                //Create keychain objects
                

                return true;
            });
            return false;
        }

        private async Task<List<KeyChainObject>> MakeKeychain(List<string> public_keys_paths,List<string> private_keys_paths,List<string> public_keys_clean,List<string> private_keys_clean)
        {
            await Task.Run(async () => 
            {
                List<KeyChainObject> keychain = new List<KeyChainObject>();


            });
            return null;
        }

        /// <summary>
        /// Find all private key files in a directory
        /// </summary>
        /// <param name="folderpath">The folder to check</param>
        /// <returns>List of private key file paths</returns>
        private async Task<List<String>> DiscoverPrivateKeys(string folderpath)
        {
            await Task.Run(() =>
            {
                string[] lines;
                List<String> to_return = new List<String>();

                string[] filePaths = Directory.GetFiles(folderpath+"\\", "*.asc",SearchOption.TopDirectoryOnly);
                foreach(string file in filePaths)
                {
                    lines = File.ReadAllLines(file);
                    if(lines[0] == "-----BEGIN PGP PRIVATE KEY BLOCK-----")
                    {
                        to_return.Add(file);
                    }
                }

                return to_return;
            });
            return null;
        }

        /// <summary>
        /// Find all public  key files in a directory
        /// </summary>
        /// <param name="folderpath">The folder to check</param>
        /// <returns>List of public key file paths</returns>
        private async Task<List<String>> DiscoverPublicKeys(string folderpath)
        {
            await Task.Run(() =>
            {
                string[] lines;
                List<String> to_return = new List<String>();

                string[] filePaths = Directory.GetFiles(folderpath + "\\", "*.asc", SearchOption.TopDirectoryOnly);
                foreach (string file in filePaths)
                {
                    lines = File.ReadAllLines(file);
                    if (lines[0] == "-----BEGIN PGP PUBLIC KEY BLOCK-----")
                    {
                        to_return.Add(file);
                    }
                }

                return to_return;
            });
            return null;
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
