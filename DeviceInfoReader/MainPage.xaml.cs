using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceInfoReader.DeviceInfo;
using DeviceInfoReader.DeviceInfo.Interfaces;
using Xamarin.Forms;

namespace DeviceInfoReader
{
	public partial class MainPage : ContentPage
	{
		private readonly IDeviceServiceAndroid _deviceServiceAndroid = DependencyService.Get<IDeviceServiceAndroid>();
		private readonly IDeviceInfoService _deviceInfoService = new DeviceInfoService();

		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_OnClicked(object sender, EventArgs e)
		{
			var deviceInfo = _deviceInfoService?.GetDeviceInfo();
			(sender as Button).Text = $"Congrats on pressing a button";
			ResponseLabel.Text = $"{deviceInfo}";
		}
	}
}
