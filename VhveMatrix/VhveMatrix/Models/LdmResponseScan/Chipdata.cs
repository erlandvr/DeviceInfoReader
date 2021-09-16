namespace FedPol.BorderTask.Mobile.APIContract.Messages.LdmResponseScan
{
    public class Chipdata
    {
        public string docType { get; set; }
        public string docIssuer { get; set; }
        public string docNumber { get; set; }
        public string docExpiry { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string birthDate { get; set; }
        public string nationality { get; set; }
        public string gender { get; set; }
        public string rfidStatus { get; set; }
        public string faceMatch { get; set; }
    }
}