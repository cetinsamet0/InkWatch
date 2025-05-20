using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkWatch
{
    public class AppConfig
    {
        public ConnectionInfo ConnectionInfo { get; set; }
        public AppSettings AppSettings { get; set; }
    }
    public class ConnectionInfo
    {
        public string ipadress { get; set; }
        public string port { get; set; }
    }

    public class AppSettings
    {
        public bool HideAllApps { get; set; } 
    }
}
