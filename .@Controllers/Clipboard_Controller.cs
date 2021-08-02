using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility.@Controllers
{
    class Clipboard_Controller
    {
        SelectKey_form select_key_form;


        /// <summary>
        /// Paste to the rtb
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        public void Paste(RichTextBox rtb)
        {
            rtb.Text = Clipboard.GetText();
        }

        /// <summary>
        /// Copy from the rtb
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        public void Copy(RichTextBox rtb)
        {
            Clipboard.SetText(rtb.Text);
        }

        /// <summary>
        /// Enrcypt the clipboard rich text box content
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        /// <param name="clipboard_timer">The timer used to refresh the rtb</param>
        public void Encrypt(RichTextBox rtb,Timer clipboard_timer)
        {
            Main_Form.kill_timer = false;
            clipboard_timer.Start();
            select_key_form = new SelectKey_form();
            select_key_form.Show();
            select_key_form.action_type = 1;
            select_key_form.on_clipboard = false;
            select_key_form.input = rtb.Text;
        }

        /// <summary>
        /// Decrpyt the clipboard rich text box content
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        /// <param name="clipboard_timer">The timer used to refresh the rtb</param>
        public void Decrypt(RichTextBox rtb,Timer clipboard_timer)
        {
            Main_Form.kill_timer = false;
            clipboard_timer.Start();
            select_key_form = new SelectKey_form();
            select_key_form.input = rtb.Text;
            select_key_form.Show();
            select_key_form.action_type = 2;
            select_key_form.on_clipboard = false;
        }
    }
}
