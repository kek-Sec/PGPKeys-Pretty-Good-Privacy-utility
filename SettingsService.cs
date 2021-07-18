using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGPKeys____Pretty_Good_Privacy_utility
{
    class SettingsService
    {
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
