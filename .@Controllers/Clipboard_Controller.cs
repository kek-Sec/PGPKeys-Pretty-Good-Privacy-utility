using PGPKeys____Pretty_Good_Privacy_utility._Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility.@Controllers
{
    class Clipboard_Controller
    {
        SelectKey_form select_key_form;
        SettingsService settings = new SettingsService();
        ClipboardService cs = new ClipboardService();

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

        public void Verify(RichTextBox rtb, Timer clipboard_timer)
        {
            cs.Verify(rtb, clipboard_timer);
        }

        /// <summary>
        /// Enrcypt the clipboard rich text box content
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        /// <param name="clipboard_timer">The timer used to refresh the rtb</param>
        public void Encrypt(RichTextBox rtb, Timer clipboard_timer)
        {
            cs.Encrypt(rtb, clipboard_timer);
        }

        /// <summary>
        /// Decrpyt the clipboard rich text box content
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        /// <param name="clipboard_timer">The timer used to refresh the rtb</param>
        public void Decrypt(RichTextBox rtb, Timer clipboard_timer)
        {
            cs.Decrypt(rtb, clipboard_timer);
        }

        /// <summary>
        /// Create a new public key file
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        public void ImportPrivateKey(RichTextBox rtb)
        {
            cs.ImportPrivateKey(rtb);
        }

        /// <summary>
        /// Creates a new private key file
        /// </summary>
        /// <param name="rtb">The input rich text box</param>
        public void ImportPublicKey(RichTextBox rtb)
        {
            cs.ImportPublicKey(rtb);
        }
    }
}
