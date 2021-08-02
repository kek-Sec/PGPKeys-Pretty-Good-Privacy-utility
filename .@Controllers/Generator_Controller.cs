using System;
using System.Media;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class Generator_Controller
    {
        GeneratorService generator = new GeneratorService();

        /// <summary>
        /// Called from the 2 radiobuttons on the generator form
        /// </summary>
        /// <param name="keysize">The selected keysize</param>
        /// <param name="other_radiobutton">The not selected radiobutton to set to not checked</param>
        public void SetKeySize(int keysize, RadioButton other_checkbox)
        {
            generator.key_length = keysize;
            other_checkbox.Checked = false;
        }

        /// <summary>
        ///  Generation routine
        /// </summary>
        /// <param name="generator_password_txt">Textbox with the password</param>
        /// <param name="generator_email_txt">Textbox with the email</param>
        /// <param name="generator_output_rtb">Generator logger output</param>
        /// <param name="key_len_2048">Radiobutton for 2048 length</param>
        public async void Generate(TextBox generator_password_txt, TextBox generator_email_txt, RichTextBox generator_output_rtb, RadioButton key_len_2048)
        {
            if (generator_password_txt.Text == default(string)) { return; }
            if (generator_email_txt.Text == default(string)) { return; }


            generator.email = generator_email_txt.Text;
            generator.password = generator_password_txt.Text;
            int key_len = key_len_2048.Checked ? 2048 : 4096;
            generator.key_length = key_len;
            bool gen_status = await generator.GenerateKeyPairAsync();


            string output = gen_status ? "successful!" : "failed!";

            FormattableString logger_output = $"Generating key pair with {generator.key_length.ToString()} length : {output}";

            generator.AddToLogger(logger_output.ToString(), generator_output_rtb);
            SystemSounds.Beep.Play();
        }
    }
}
