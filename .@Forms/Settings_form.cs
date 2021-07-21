using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    public partial class Settings_form : Form
    {
        SettingsService settings = new SettingsService();

        public Settings_form()
        {
            InitializeComponent();            
        }

        private void save_keys_path_btn_Click(object sender, EventArgs e)
        {
            settings.LoadKeysFolder();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            settings.LoadKeysFolder();
        }

        private void Settings_form_Load(object sender, EventArgs e)
        {
            try
            {
                //set keys folder directory txt
                settings_key_folder_txt.Text = settings.getSetting("keys_folder_path");

                //setup checkboxes
                to_tray_checkbox.Checked = settings.getSetting("minimize_to_tray", true);
                on_startup_checkbox.Checked = settings.getSetting("on_startup", true);
                on_startup_password_checkbox.Checked = settings.getSetting("Password", true);
                sessioning_checkbox.Checked = settings.getSetting("Sessioning", true);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error on loading settings " + exc.Message);
            }
        }
    }
}
