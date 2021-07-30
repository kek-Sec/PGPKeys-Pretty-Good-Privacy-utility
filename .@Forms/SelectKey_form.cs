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
using PGPKeys____Pretty_Good_Privacy_utility._Controllers;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    public partial class SelectKey_form : Form
    {
        SelectKey_Controller sc = new SelectKey_Controller();
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
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            kcs.LoadKeyChain(settings.getSetting("keys_folder_path"));
            keychain = kcs.keyChainList;

            if(!keychain.Any()) { select_key_listbox.Items.Add("No keys found!"); }
            else
            {
                foreach (KeyChainObject key_set in keychain)
                {
                    select_key_listbox.Items.Add(key_set.email);
                }
            }



        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private async void select_key_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = select_key_listbox.SelectedIndex;
            if(index == -1) { return; }
            selected_key = keychain[index];
            Clipboard.SetText(await sc.resolveActionAsync(action_type, Clipboard.GetText(), selected_key));
        }
    }

}
