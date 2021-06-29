using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WslPortfowardLauncher
{
    class CoreController
    {
        public List<Portfoward> Portfowards { get; protected set; }
        public void Init()
        {
            this.Portfowards = WslController.GetPortfowards();
        }
        
        public void ApplyPortfoward(List<Portfoward> newPortfowards)
        {
            foreach (var portfoward in this.Portfowards)
            {
                WslController.DeletePortfoward(portfoward);
            }
            foreach (var newPortfoward in newPortfowards)
            {
                WslController.AddPortfoward(newPortfoward);
            }
            MessageBox.Show("更新完了しました");
        }
    }
}
