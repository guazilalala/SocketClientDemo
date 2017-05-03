using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Ribbon;
using SocketClientDemo.ViewModel;

namespace SocketClientDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        private void testAdd_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Model.Devices device1 = new Model.Devices { DevicesName = "GZ11", IpAddress = "192.168.1.1", IpPort = "6000", Status = 1, Region = "广州", Protocols = "TCP", MACAddress = "11-22-33-44-55" };
            Model.Devices device2 = new Model.Devices { DevicesName = "GZ12", IpAddress = "192.168.1.2", IpPort = "6000", Status = 1, Region = "广州", Protocols = "TCP", MACAddress = "11-22-33-44-55" };
            Model.Devices device3 = new Model.Devices { DevicesName = "GZ13", IpAddress = "192.168.1.3", IpPort = "6000", Status = 1, Region = "广州", Protocols = "TCP", MACAddress = "11-22-33-44-55" };
            Model.Devices device4 = new Model.Devices { DevicesName = "SH11", IpAddress = "192.168.2.1", IpPort = "6000", Status = 1, Region = "上海", Protocols = "TCP", MACAddress = "11-22-33-44-55" };
            Model.Devices device5 = new Model.Devices { DevicesName = "SH12", IpAddress = "192.168.2.2", IpPort = "6000", Status = 1, Region = "上海", Protocols = "TCP", MACAddress = "11-22-33-44-55" };
            Model.Devices device6 = new Model.Devices { DevicesName = "SH13", IpAddress = "192.168.2.3", IpPort = "6000", Status = 1, Region = "上海", Protocols = "TCP", MACAddress = "11-22-33-44-55" };

            Model.DevicesDAL devicesDAL = new Model.DevicesDAL();
            devicesDAL.Add(device1);
            devicesDAL.Add(device2);
            devicesDAL.Add(device3);
            devicesDAL.Add(device4);
            devicesDAL.Add(device5);
            devicesDAL.Add(device6);

        }
    }
}
