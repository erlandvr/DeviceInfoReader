using System;
using DeviceInfoReader.DeviceInfo.Interfaces;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace DeviceInfoReader.DeviceInfo.Models
{
	public class DeviceInfo
    {
	    public string Orientation { get; set; }
	    public double WidthPixels { get; set; }
	    public double HeightPixels { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string DeviceName { get; set; }
        public string OSVersion { get; set; }
        public string VersionNumber { get; set; }
        public string VersionName { get; set; }
        public string Platform { get; set; }
        public string Idiom { get; set; }
        public string DeviceType { get; set; }
        public string AppName { get; set; }
        public string PackageName { get; set; }
        public string AppVersion { get; set; }
        public string BuildString { get; set; }
        public string DeviceNetwork { get; set; }
        public string DeviceNetworkType { get; set; }
        public string BatteryStatus { get; set; }
        public string PowerSource { get; set; }
        public string DisplayLanguage { get; set; }
        public string TimeZone { get; set; }
        public TimeSpan UtcOffset { get; set; }
        public double TotalDeviceMemoryInMb { get; set; }
        public double FreeDeviceMemoryInMb { get; set; }
        public string UsedDeviceMemoryInPercentage { get; set; }
        
        // public int VersionMajor { get; set; }
        // public int VersionMinor { get; set; }
        // public int VersionRevision { get; set; }
        // public string JavaTimeZone { get; set; }
        // public int ProcessorCount { get; set; }
        // public string Architecture { get; set; }
        // public string EnvModel { get; set; }
        // public string IPV4Address { get; set; }
        // public string IPV6Address { get; set; }
        // public string MacAdress { get; set; }
        // public long DeviceCpuIdle { get; set; }
    }
}