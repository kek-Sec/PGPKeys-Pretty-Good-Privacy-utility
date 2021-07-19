using System;
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
        Settings_form settings = new Settings_form();
        GeneratorService gen_service;

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

        #region Button events
        private async void generate_button_ClickAsync(object sender, EventArgs e)
        {
            if(generator_password_txt.Text == default(string)) { return; }
            if(generator_email_txt.Text == default(string)) { return; }

            gen_service = new GeneratorService();
            gen_service.email = generator_email_txt.Text;
            gen_service.password = generator_password_txt.Text;

            int key_len = key_len_2048.Checked ? 2048 : 4096;

            gen_service.key_length = key_len;

            bool gen_status = await gen_service.GenerateKeyPairAsync();


            string output = gen_status ? "successful!" : "failed!";

            FormattableString logger_output = $"Generating key pair with {gen_service.key_length.ToString()} length : {output}";

            gen_service.AddToLogger(logger_output.ToString(), generator_output_rtb);
            SystemSounds.Beep.Play();

        }
        #endregion
    }
}
