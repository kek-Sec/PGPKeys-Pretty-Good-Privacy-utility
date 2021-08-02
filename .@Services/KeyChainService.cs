using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class KeyChainService
    {
        public List<KeyChainObject> keyChainList;
        List<string> logger_output = new List<string>();

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

        /// <summary>
        /// Entry function for the loading of the keychain
        /// </summary>
        /// <param name="folderpath">The folder where the keys are placed</param>
        /// <returns></returns>
        public void LoadKeyChain(string folderpath)
        {

            if (!Directory.Exists(folderpath))
            {
                return;
            }

            List<String> private_keys = DiscoverPrivateKeys(folderpath);
            List<String> public_keys = DiscoverPublicKeys(folderpath);

            List<String> private_keys_clean;
            List<String> public_keys_clean;

            //Create new keychain list
            keyChainList = new List<KeyChainObject>();

            //cleanup filenames
            private_keys_clean = getEmailFromText(private_keys);
            public_keys_clean = getEmailFromText(public_keys);

            //Create keychain objects
            keyChainList = MakeKeychain(public_keys, private_keys, public_keys_clean, private_keys_clean);


        }

        /// <summary>
        /// Function to build the KeyChain
        /// </summary>
        /// <param name="public_keys_paths">the paths for the public keys</param>
        /// <param name="private_keys_paths">the paths for the private keys</param>
        /// <param name="public_keys_clean">clear filenames from the public keys</param>
        /// <param name="private_keys_clean">clear filenames from the private keys</param>
        /// <returns>Keychain list</returns>
        private List<KeyChainObject> MakeKeychain(List<string> public_keys_paths, List<string> private_keys_paths, List<string> public_keys_clean, List<string> private_keys_clean)
        {

            List<KeyChainObject> keychain = new List<KeyChainObject>();
            KeyChainObject keyset;

            for (int i = 0; i < public_keys_clean.Count; i++)
            {
                keyset = new KeyChainObject
                {
                    email = public_keys_clean[i],
                    public_key = File.ReadAllText(public_keys_paths[i])
                };

                //loop private keys
                for (int j = 0; j < private_keys_clean.Count; j++)
                {
                    if (private_keys_clean[j] == keyset.email)
                    {
                        keyset.private_key = File.ReadAllText(private_keys_paths[j]);
                        break;
                    }
                }
                keychain.Add(keyset);
            }
            return keychain;

        }

        /// <summary>
        /// Find all private key files in a directory
        /// </summary>
        /// <param name="folderpath">The folder to check</param>
        /// <returns>List of private key file paths</returns>
        private List<string> DiscoverPrivateKeys(string folderpath)
        {

            string[] lines;
            List<String> to_return = new List<String>();
            string[] filePaths = Directory.GetFiles(folderpath, "*.asc");
            foreach (string file in filePaths)
            {
                lines = File.ReadAllLines(file);
                if (lines[0] == "-----BEGIN PGP PRIVATE KEY BLOCK-----")
                {
                    to_return.Add(file);
                }
            }
            return to_return;
        }

        /// <summary>
        /// Find all public  key files in a directory
        /// </summary>
        /// <param name="folderpath">The folder to check</param>
        /// <returns>List of public key file paths</returns>
        private List<String> DiscoverPublicKeys(string folderpath)
        {
            string[] lines;
            List<String> to_return = new List<String>();

            string[] filePaths = Directory.GetFiles(folderpath, "*.asc", SearchOption.TopDirectoryOnly);
            foreach (string file in filePaths)
            {
                lines = File.ReadAllLines(file);
                if (lines[0] == "-----BEGIN PGP PUBLIC KEY BLOCK-----")
                {
                    to_return.Add(file);
                }
            }

            return to_return;
        }

        /// <summary>
        /// Receive filepath starting with email and return only the email part
        /// </summary>
        /// <param name="fuzzy_text">The list containing the filenames</param>
        /// <returns>List of cleared names</returns>
        private List<string> getEmailFromText(List<string> fuzzy_text)
        {
            List<string> ret = new List<string>();
            for (int i = 0; i < fuzzy_text.Count; i++)
            {
                //loop for number of /

                var temp = fuzzy_text[i].Split('-')[0];
                int count = temp.Count(f => f == '\\');
                for (int k = 0; k < count; k++)
                {
                    temp = temp.Substring(temp.IndexOf('\\') + 1);
                }

                ret.Add(temp);
            }
            return ret;
        }

        #region keychain logger

        /// <summary>
        /// Writes output to logger
        /// </summary>
        /// <param name="s">The string to write</param>
        /// <param name="logger">The logger output rich text box</param>
        public void AddToLogger(string s, RichTextBox logger)
        {
            logger.Clear();
            logger_output.Add(s);
            logger.Text = String.Join("\n", logger_output.ToArray());
        }

        #endregion
    }

    public class KeyChainObject
    {
        public string public_key
        {
            get;
            set;
        }
        public string private_key
        {
            get;
            set;
        }
        public string email
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }

    }
}