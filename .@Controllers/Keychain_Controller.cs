﻿using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void Listbox_Item_Click(KeyChainObject selected_key,Button keychain_emcrypt_btn,Button keychain_decrypt_btn,Button keychain_verify_btn,Button keychain_sign_btn,ListBox keychain_listbox,Button keychain_publickey_status,Button keychain_privatekey_status)
        {
            var indx = keychain_listbox.SelectedIndex;
            if (indx == -1) { return; }
            //set current key
            selected_key.email = keychain.keyChainList[indx].email;
            selected_key.private_key = keychain.keyChainList[indx].private_key;
            selected_key.public_key = keychain.keyChainList[indx].public_key;


            keychain_publickey_status.BackColor = Color.LightGreen;
            keychain_privatekey_status.BackColor = Color.LightGreen;

            if (selected_key.private_key == null)
            {
                keychain_privatekey_status.BackColor = Color.DarkGray;
                keychain_emcrypt_btn.Enabled = true;
                keychain_decrypt_btn.Enabled = false;
                keychain_verify_btn.Enabled = true;
                keychain_sign_btn.Enabled = false;
            }
            else
            {
                keychain_emcrypt_btn.Enabled = true;
                keychain_decrypt_btn.Enabled = true;
                keychain_verify_btn.Enabled = true;
                keychain_sign_btn.Enabled = true;

            }
        }
    }
}
