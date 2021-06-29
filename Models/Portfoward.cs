using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WslGuiController.Models
{
    public class Portfoward
    {
        public int WindowsPort;
        public string WslIp;
        public int WslPort;

        public Portfoward()
        {
        }

        public Portfoward(int windowsPort, string wslIpAddr, int wslPort)
        {
            this.WindowsPort = windowsPort;
            this.WslIp = wslIpAddr;
            this.WslPort = wslPort;
        }
    }
}
