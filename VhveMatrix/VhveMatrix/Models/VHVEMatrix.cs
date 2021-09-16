using System;

namespace VHVEMatrix.VHVEMatrix.Models
{
	public class VHVEMatrix
	{
		[SQLite.PrimaryKey()]
		public string CouKey { get; set; }
		public string CouTextBE { get; set; }
		public string CouCouDeactivate { get; set; } //maybe it should be DateTime
		public string COUIsEu { get; set; }
		public string CouIsShengen { get; set; }
		public string CoulcaoCode { get; set; }
		public string MtxCouCountry { get; set; }
		public string MtxTravellerType { get; set; }
		public string MtxWarning { get; set; }
		
		public static VHVEMatrix FromCsv(string csvLine)
		{
			string[] values = csvLine.Split(';');
			VHVEMatrix VHVEMatrix = new VHVEMatrix();
			VHVEMatrix.CouKey = Convert.ToString(values[0]);
			VHVEMatrix.CouTextBE = Convert.ToString(values[1]);
			VHVEMatrix.CouCouDeactivate = Convert.ToString(values[2]);
			VHVEMatrix.COUIsEu = Convert.ToString(values[3]);
			VHVEMatrix.CouIsShengen = Convert.ToString(values[4]);
			VHVEMatrix.CoulcaoCode = Convert.ToString(values[5]);
			VHVEMatrix.MtxCouCountry = Convert.ToString(values[6]);
			VHVEMatrix.MtxTravellerType = Convert.ToString(values[7]);
			VHVEMatrix.MtxWarning = Convert.ToString(values[8]);
			return VHVEMatrix;
		}
	}
}