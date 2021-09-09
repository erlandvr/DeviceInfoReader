namespace DeviceInfoReader.DeviceInfo.Structs
{
	public struct DeviceMemoryStruct
	{
		public long TotalBytes; 
		public long FreeBytes;

		public int TotalMegaBytes => (int)TotalBytes / 1024 / 1024;
		public int FreeMegaBytes => (int)FreeBytes / 1024 / 1024;
		public long UsedMegaBytes => TotalMegaBytes - FreeMegaBytes;

		public double UsedPercentage => ((double)UsedMegaBytes / TotalMegaBytes) * 100;
	}
}