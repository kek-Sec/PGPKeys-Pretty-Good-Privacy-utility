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


namespace PGPKeys____Pretty_Good_Privacy_utility
{
    public partial class SelectKey_form : Form
    {
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
            List<KeyChainObject> keychain = kcs.keyChainList;

            foreach(KeyChainObject key_set in keychain)
            {
                select_key_listbox.Items.Add(key_set.email);
            }

            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    }

}
