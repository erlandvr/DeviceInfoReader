using System;
using System.Globalization;
using System.Linq;
using System.Text;
using DeviceInfoReader.DeviceInfo.Interfaces;
using DeviceInfoReader.DeviceInfo.Models;
using DeviceInfoReader.DeviceInfo.Structs;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Essentials;
using device =  Xamarin.Essentials.DeviceInfo;


namespace DeviceInfoReader.DeviceInfo
{
	public class DeviceInfoService : IDeviceInfoService
	{
		private Models.DeviceInfo _deviceInfo;
		private readonly IDeviceServiceAndroid _deviceInfoServiceAndroid = DependencyService.Get<IDeviceServiceAndroid>();

		private DisplayInfo _display = DeviceDisplay.MainDisplayInfo;
		private DeviceMemoryStruct _deviceMemory;

		public DeviceInfoService()
		{
			_deviceInfo = new Models.DeviceInfo();
			_deviceMemory = _deviceInfoServiceAndroid.GetDeviceMemory();
		}
		public string GetDeviceInfo()
		{
			var d = _deviceInfo;
			
			//time and language
			d.DisplayLanguage = CultureInfo.CurrentUICulture.ThreeLetterISOLanguageName;
			d.TimeZone = TimeZoneInfo.Local.StandardName;
			d.UtcOffset = TimeZoneInfo.Local.BaseUtcOffset;
			
			//Device a application info
			d.Orientation = GetOrientation();
			d.WidthPixels = _display.Width;
			d.HeightPixels = _display.Height;

			d.Model = device.Model;
			d.Manufacturer = device.Manufacturer;
			d.DeviceName = device.Name;
			d.Platform = device.Platform;
			d.Idiom = device.Idiom;
			d.DeviceType = device.DeviceType;

			d.AppName = AppInfo.Name;
			d.PackageName = AppInfo.PackageName;
			d.AppVersion = AppInfo.VersionString;
			d.BuildString = AppInfo.BuildString;
			
			d.OSVersion = _deviceInfoServiceAndroid.GetOSVersion();
			d.VersionNumber = _deviceInfoServiceAndroid.GetVersionRelease();
			d.VersionName = _deviceInfoServiceAndroid.GetBuildVersionCode();
			
			//Network Connectivity
			d.DeviceNetwork = Connectivity.NetworkAccess.ToString();
			d.DeviceNetworkType = CheckForConnectionProfile();
			
			//Battery status
			d.BatteryStatus = GetBatteryChargeLevel();
			d.PowerSource = GetPowerSource();
			
			//Storage memory
			d.TotalDeviceMemoryInMb = GetTotalMemory();
			d.FreeDevcieMemoryInMb = GetFreeMemory();
			d.AvailableDeviceMemory = GetAvailablePhysicalMemoryInBytes();
			d.UsedDeviceMemoryInPercentage = GetUsedMemoryPercentage();
			
			//Cpu usage?

			return JsonConvert.SerializeObject(d);
		}

		private string GetOrientation()
		{
			switch (_display.Orientation)
			{
				case DisplayOrientation.Portrait:
					return "Portrait";
				case DisplayOrientation.Landscape:
					return "Landscape";
				default: return "Unknown";
			}
		}

		private string CheckForConnectionProfile()
		{
			var profiles = Connectivity.ConnectionProfiles;

			if (profiles == null)
			{
				return null;
			}

			if (profiles.Contains(ConnectionProfile.WiFi))
			{
				return "WiFi";
			}
			
			if (profiles.Contains(ConnectionProfile.Cellular))
			{
				return "Cellular";
			}
			
			return "No Internet Connection Found";
		}

		private string GetBatteryChargeLevel()
		{
			return $"{Battery.ChargeLevel * 100} %";
		}

		private string GetPowerSource()
		{
			switch (Battery.PowerSource)
			{
				case BatteryPowerSource.Battery:
					return "Battery";
				case BatteryPowerSource.AC:
					return "AC";
				case BatteryPowerSource.Usb:
					return "USB";
				case BatteryPowerSource.Wireless:
					return "Wireless charging";
				default: return "Unknown";
			}
		}

		private double GetTotalMemory()
		{
			return _deviceMemory.TotalMegaBytes;
		}

		private double GetFreeMemory()
		{
			return _deviceMemory.FreeMegaBytes;
		}

		private long GetAvailablePhysicalMemoryInBytes()
		{
			return _deviceMemory.AvailableBytes;
		}

		private string GetUsedMemoryPercentage()
		{
			return $"{_deviceMemory.UsedPercentage}%";
		}
	}
}