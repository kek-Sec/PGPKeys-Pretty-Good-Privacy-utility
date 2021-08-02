using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using PGPKeys____Pretty_Good_Privacy_utility._Controllers;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    public partial class SelectKey_form : Form
    {
        SettingsService settings = new SettingsService();
        KeyChainService kcs = new KeyChainService();

        SelectKey_Controller sc = new SelectKey_Controller();

        public KeyChainObject selected_key;

        /// <summary>
        /// Action types
        /// 1 -> Encrypt
        /// 2 -> Decrypt
        /// </summary>
        public int action_type;

        public bool on_clipboard;

        public string input;

        List<KeyChainObject> keychain = new List<KeyChainObject>();

        #region top view hook
        /// <summary>
        /// System hook to stay on top
        /// </summary>
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        #endregion



        public SelectKey_form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load event responsible for filling the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectKey_form_Load(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            kcs.LoadKeyChain(settings.getSetting("keys_folder_path"));
            keychain = kcs.keyChainList;

            if (!keychain.Any()) { select_key_listbox.Items.Add("No keys found!"); } //to-do handle this
            else
            {
                foreach (KeyChainObject key_set in keychain)
                {
                    select_key_listbox.Items.Add(key_set.email);
                }
            }



        }

        /// <summary>
        /// Called when a list item is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void select_key_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = select_key_listbox.SelectedIndex;
            if (index == -1) { return; }
            selected_key = keychain[index];
            if (on_clipboard)
            {
                Clipboard.SetText(await sc.resolveActionAsync(action_type, Clipboard.GetText(), selected_key));
            }
            else
            {
                Main_Form.clipboard_content = await sc.resolveActionAsync(action_type, input, selected_key);
                Main_Form.kill_timer = true;
            }
            SystemSounds.Beep.Play();
            this.Close();
        }
    }

}
