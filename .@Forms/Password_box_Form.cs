using System.Drawing;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility._Forms
{
    class Password_box_Form
    {

        /// <summary>
        /// Password input box
        /// </summary>

        private Form frm;
        public string Show(string prompt, string title)
        {
            frm = new Form();
            FlowLayoutPanel FL = new FlowLayoutPanel();
            Label lbl = new Label();
            TextBox txt = new TextBox();
            Button ok = new Button();
            Button cancel = new Button();

            frm.Font = new Font("Calibri", 11, FontStyle.Bold);
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Width = 200;
            frm.Height = 180;

            frm.Text = title;
            lbl.Text = prompt;
            ok.Text = "Ok";
            cancel.Text = "Cancel";
            txt.PasswordChar = '*';

            ok.FlatStyle = FlatStyle.Flat;
            ok.BackColor = SystemColors.ButtonShadow;
            ok.ForeColor = SystemColors.ButtonHighlight;
            ok.Cursor = Cursors.Hand;

            cancel.FlatStyle = FlatStyle.Flat;
            cancel.BackColor = SystemColors.ButtonShadow;
            cancel.ForeColor = SystemColors.ButtonHighlight;
            cancel.Cursor = Cursors.Hand;

            FL.Left = 0;
            FL.Top = 0;
            FL.Width = frm.Width;
            FL.Height = frm.Height;
            FL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            FL.Padding = new Padding(10);
            FL.FlowDirection = FlowDirection.TopDown;

            ok.Width = FL.Width - 35;
            txt.Width = ok.Width;
            cancel.Width = ok.Width;
            lbl.Width = ok.Width;

            ok.Click += new System.EventHandler(okClick);
            cancel.Click += new System.EventHandler(cancelClick);
            txt.KeyPress += new KeyPressEventHandler(txtEnter);

            FL.Controls.Add(lbl);
            FL.Controls.Add(txt);
            FL.Controls.Add(ok);
            FL.Controls.Add(cancel);
            frm.Controls.Add(FL);

            frm.ShowDialog();
            DialogResult DR = frm.DialogResult;
            frm.Dispose();
            frm = null;
            if (DR == DialogResult.OK)
            {
                return txt.Text;
            }
            else
            {
                return "";
            }
        }
        private void okClick(object sender, System.EventArgs e)
        {
            frm.DialogResult = DialogResult.OK;
            frm.Close();
        }
        private void cancelClick(object sender, System.EventArgs e)
        {
            frm.DialogResult = DialogResult.Cancel;
            frm.Close();
        }
        private void txtEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) { okClick(null, null); }
        }

    }
}
