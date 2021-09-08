namespace DeviceInfoReader.DeviceInfo.Structs
{
	public struct DeviceMemoryStruct
	{
		public long TotalBytes;
		public long FreeBytes;
		public long AvailableBytes => TotalBytes - FreeBytes;

		public int TotalMegaBytes => (int)TotalBytes / 1024 / 1024;
		public int TotalGigaBytes => (int)TotalBytes / 1024 / 1024;

		public int FreeMegaBytes => (int)FreeBytes / 1024 / 1024;
		public int FreeGigaBytes => (int)FreeBytes / 1024 / 1024;

		public int UsedPercentage => (int)FreeBytes / (int)TotalBytes * 100;
	}
}