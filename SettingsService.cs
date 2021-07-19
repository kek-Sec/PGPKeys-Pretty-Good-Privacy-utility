﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class SettingsService
    {

        /// <summary>
        /// Changes the keys folder directory setting
        /// </summary>
        public void LoadKeysFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    UpdateSetting("keys_folder_path", fbd.SelectedPath);
                    MessageBox.Show("Successfully saved", "Keys directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #region settings
        /// <summary>
        /// Updates System Properties settings
        /// </summary>
        /// <param name="setting">The setting to update.</param>
        /// <param name="value">The value to use for the setting.</param>
        public void UpdateSetting(string setting, string value)
        {
            Properties.Settings.Default[setting] = value;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Gets System Properties setting
        /// </summary>
        /// <param name="setting">The setting to get.</param>
        public string getSetting(string setting)
        {
            return Properties.Settings.Default[setting].ToString();
        }

        #endregion
    }
}
