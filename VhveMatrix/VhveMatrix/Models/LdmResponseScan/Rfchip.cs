namespace FedPol.BorderTask.Mobile.APIContract.Messages.LdmResponseScan
{
    public class Rfchip
    {
        public string rawMrz { get; set; }
        public Chipdata chipData { get; set; }
        public Chipphoto chipPhoto { get; set; }
    }
}