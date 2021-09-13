namespace VhveMatrix.VhveMatrix.Models
{
	public class Data
	{
		public RfChip rfChip { get; set; }
		public Mrz mrz { get; set; }
		public Viz viz { get; set; }
		public Scan scan { get; set; }
		public Infos infos { get; set; }
		public SecurityChecks securityChecks { get; set; }
		public OtherFields otherFields { get; set; }
	}
}