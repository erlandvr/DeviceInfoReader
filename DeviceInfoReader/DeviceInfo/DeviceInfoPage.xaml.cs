using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceInfoReader.DeviceInfo.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeviceInfoReader.DeviceInfo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeviceInfoPage : ContentPage
	{
		private readonly IDeviceServiceAndroid _deviceServiceAndroid = DependencyService.Get<IDeviceServiceAndroid>();
		private readonly IDeviceInfoService _deviceInfoService = new DeviceInfoService();
		
		public DeviceInfoPage()
		{
			InitializeComponent();
			App.Current.MainPage = new NavigationPage();

			var deviceInfo = _deviceInfoService?.GetDeviceInfo();
			ResponseLabel.Text = $"{deviceInfo}";
		}

		// protected override bool OnBackButtonPressed()
		// {
		// 	base.OnBackButtonPressed();
		// 	App.Current.MainPage.Navigation.PopAsync(false);
		// 	return true;
		// }
	}
}