using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGPKeys____Pretty_Good_Privacy_utility._Services
{
    class VersionControlService
    {
        SettingsService settings = new SettingsService();
        public string current_version { get; set; }

        public VersionControlService()
        {
            current_version = settings.getSetting("version");
        }


    }
}
