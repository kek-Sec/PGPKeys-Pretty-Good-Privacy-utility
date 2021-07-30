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

        public void Paste(RichTextBox rtb)
        {
            rtb.Text = Clipboard.GetText();
        }

        public void Copy(RichTextBox rtb)
        {
            Clipboard.SetText(rtb.Text);
        }
    }
}
