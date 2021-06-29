using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WslGuiController.Controllers
{
    using Models;

    class CoreController
    {
        public List<Portfoward> Portfowards { get; protected set; }
        public void FetchData()
        {
            this.Portfowards = WslController.GetPortfowards();
        }
        
        public void ApplyPortfowards(List<Portfoward> newPortfowards)
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
