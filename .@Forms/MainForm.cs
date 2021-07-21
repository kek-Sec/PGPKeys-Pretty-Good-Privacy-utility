﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    public partial class Main_Form : Form
    {
        Settings_form settings_form = new Settings_form();

        SettingsService settings = new SettingsService();
        GeneratorService gen_service;
        KeyChainService keychain = new KeyChainService();
        KeyChainObject selected_key = new KeyChainObject();

        Generator_Controller gc = new Generator_Controller();

        public Main_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load event called when form is opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Load(object sender, EventArgs e)
        {
        }

        private void keychain_settings_btn_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == "Settings")
                {
                    return;
                }
            }
            settings_form = new Settings_form();
            settings_form.Show();
        }

        #region Button events
        private void generate_button_Click(object sender, EventArgs e)
        {
            gc.Generate(generator_password_txt, generator_email_txt, generator_output_rtb, key_len_2048);
        }
        #endregion

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var keys_folder = settings.getSetting("keys_folder_path");

            //clear listbox
            keychain_listbox.Items.Clear();

            if(keys_folder == String.Empty)
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

        private void load_folder_Click(object sender, EventArgs e)
        {
            settings.LoadKeysFolder();
            //load keychain
        }

        private void keychain_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indx = keychain_listbox.SelectedIndex;
            if (indx == -1) { return; }
            //set current key
            selected_key.email = keychain.keyChainList[indx].email;
            selected_key.private_key = keychain.keyChainList[indx].private_key;
            selected_key.public_key = keychain.keyChainList[indx].public_key;

            if (selected_key.private_key == null)
            {
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

        private void keychain_paste_btn_Click(object sender, EventArgs e)
        {
            keychain_clipboard_rtb.Text = Clipboard.GetText();
        }

        private void keychain_copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(keychain_clipboard_rtb.Text);

        }

        private void key_len_4096_CheckedChanged(object sender, EventArgs e)
        {
            gc.SetKeySize(4096, key_len_2048);
        }

        private void key_len_2048_CheckedChanged(object sender, EventArgs e)
        {
            gc.SetKeySize(2048, key_len_4096);
        }
    }
}
