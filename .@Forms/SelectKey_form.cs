using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    public partial class SelectKey_form : Form
    {
        PGPService pgp = new PGPService();
        public KeyChainObject selected_key;

        /// <summary>
        /// Action types
        /// 1 -> Encrypt
        /// 2 -> Decrypt
        /// </summary>
        public int action_type;

        List<KeyChainObject> keychain = new List<KeyChainObject>();

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        SettingsService settings = new SettingsService();
        KeyChainService kcs = new KeyChainService();

        public SelectKey_form()
        {
            InitializeComponent();            
        }

        private void SelectKey_form_Load(object sender, EventArgs e)
        {
            kcs.LoadKeyChain(settings.getSetting("keys_folder_path"));
             keychain = kcs.keyChainList;

            foreach(KeyChainObject key_set in keychain)
            {
                select_key_listbox.Items.Add(key_set.email);
            }

            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private async void select_key_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = select_key_listbox.SelectedIndex;
            if(index == -1) { return; }
            selected_key = keychain[index];
            if(action_type == 1)
            {
                string encrypted = await pgp.EncryptString(Clipboard.GetText(), selected_key.public_key);
                MessageBox.Show(encrypted);
                SystemSounds.Beep.Play();
                this.Close();
            }
            else if(action_type == 2)
            {
               //implement decryption
            }
        }
    }

}
