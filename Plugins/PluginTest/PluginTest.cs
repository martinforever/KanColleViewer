using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleWrapper;

namespace PluginTest
{
    [Export(typeof(IToolPlugin))]
    [ExportMetadata("Title", "KanCollePluginTest")]
    [ExportMetadata("Description", "Test")]
    [ExportMetadata("Version", "1.0")]
    [ExportMetadata("Author", "Martin")]
    public class PluginTest : IToolPlugin
    {

        public string ToolName
        {
            get { return "PluginTest"; }
        }

        public object GetSettingsView()
        {
            return null;
        }

        public object GetToolView()
        {
            return new UserControl2();
        }
    }
}