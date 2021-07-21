using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class Keychain_Controller
    {
        SettingsService settings = new SettingsService();
        KeyChainService keychain = new KeyChainService();
        KeyChainObject keychain_object = new KeyChainObject();


        /// <summary>
        /// Show the settings form
        /// </summary>
        public void ShowSettingsForm()
        {
            Settings_form settings = new Settings_form();
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == "Settings")
                {
                    return;
                }
            }
            settings = new Settings_form();
            settings.Show();
        }

        /// <summary>
        /// Calls the loadkeychain routine from the service
        /// </summary>
        /// <param name="keychain_listbox">Listbox to display keychain</param>
        /// <param name="keychain_logger_rtb">Keychain logger for output</param>
        public void LoadKeychain(ListBox keychain_listbox, RichTextBox keychain_logger_rtb)
        {
            var keys_folder = settings.getSetting("keys_folder_path");

            //clear listbox
            keychain_listbox.Items.Clear();

            if (keys_folder == String.Empty)
            {
                settings.LoadKeysFolder();
                keychain.LoadKeyChain(keys_folder);
                //load keychain
                foreach (KeyChainObject k in keychain.keyChainList)
                {
                    keychain_listbox.Items.Add(k.email);
                }
                FormattableString res = $"Added [{this.keychain.keyChainList.Count}] entries!";
                keychain.AddToLogger(res.ToString(), keychain_logger_rtb);
            }
            else
            {
                keychain.LoadKeyChain(keys_folder);

                //load keycain from settings path
                //load keychain
                foreach (KeyChainObject k in keychain.keyChainList)
                {
                    keychain_listbox.Items.Add(k.email);
                }
                FormattableString res = $"Added [{this.keychain.keyChainList.Count}] entries!";
                keychain.AddToLogger(res.ToString(), keychain_logger_rtb);

            }
        }
    }
}
