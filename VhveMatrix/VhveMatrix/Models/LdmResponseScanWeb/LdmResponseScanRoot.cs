namespace VhveMatrix.VhveMatrix.Models
{
	// LdmResponseScanRoot myDeserializedClass = JsonConvert.DeserializeObject<LdmResponseScanRoot>(myJsonResponse); 

	public class LdmResponseScanRoot
    {
        public string type { get; set; }
        public string version { get; set; }
        public string clientIp { get; set; }
        public string userName { get; set; }
        public string timeStamp { get; set; }
        public Data data { get; set; }
    }
}