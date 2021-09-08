using DeviceInfoReader.DeviceInfo.Structs;
using Xamarin.Forms.Internals;

namespace DeviceInfoReader.DeviceInfo.Interfaces
{
	public interface IDeviceServiceAndroid
	{
		string GetDisplayLanguage();
		string GetOSVersion();
		string GetVersionRelease();
		string GetBuildVersionCode();
		DeviceMemoryStruct GetDeviceMemory();
	}
}