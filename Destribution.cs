using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WslPortfowardLauncher
{
    public class Destribution
    {
        public string Name;
        public string HostIp;

        public Destribution(string name, string hostIp)
        {
            this.Name = name;
            this.HostIp = hostIp;
        }
    }
}
