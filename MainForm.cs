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
    public partial class Main_Form : Form
    {
        Settings_form settings = new Settings_form();
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
            settings.Show();
        }
    }
}
