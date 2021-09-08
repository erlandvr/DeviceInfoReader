using Android.Content;
using Android.OS;
using Android.Views;
using DeviceInfoReader.DeviceInfo.Interfaces;
using DeviceInfoReader.DeviceInfo.Structs;
using DeviceInfoReader.Droid.DeviceInfo;
using Java.Interop;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(DeviceInfoService))]
namespace DeviceInfoReader.Droid.DeviceInfo
{
	public class DeviceInfoService : IDeviceServiceAndroid
	{
		public string GetDisplayLanguage()
		{
			return "";
		}

		public string GetOSVersion()
		{
			return Build.VERSION.SdkInt.ToString();
		}
		
		public string GetVersionRelease()
		{
			return Build.VERSION.Release;
		}

		public string GetBuildVersionCode()
		{
			return Build.VERSION.Incremental;
		}

		public DeviceMemoryStruct GetDeviceMemory()
		{
			return new DeviceMemoryStruct()
			{
				TotalBytes = Environment.RootDirectory.TotalSpace,
				FreeBytes = Environment.RootDirectory.TotalSpace
			};
		}
	}
}