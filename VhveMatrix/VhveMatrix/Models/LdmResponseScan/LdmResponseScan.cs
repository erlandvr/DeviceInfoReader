namespace FedPol.BorderTask.Mobile.APIContract.Messages.LdmResponseScan
{
    public class LdmResponseScan
    {
        public string type { get; set; }
        public string version { get; set; }
        public string clientIp { get; set; }
        public string userName { get; set; }
        public string timeStamp { get; set; }

        public string wizardCurrentState { get; set; }
        public Data data { get; set; }
    }
}