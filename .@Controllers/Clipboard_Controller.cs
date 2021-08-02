using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility.@Controllers
{
    class Clipboard_Controller
    {
        SelectKey_form select_key_form;

        public void Paste(RichTextBox rtb)
        {
            rtb.Text = Clipboard.GetText();
        }

        public void Copy(RichTextBox rtb)
        {
            Clipboard.SetText(rtb.Text);
        }

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
