using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketClientDemo.ViewModel
{
   public class MainWindowViewModel :ViewModelBase
    {
        public List<Model.Devices> DevicesList;

        public MainWindowViewModel()
        {
            Model.DevicesDAL deviceDAL = new Model.DevicesDAL();
            DevicesList = deviceDAL.GetList();
        }
    }
}
