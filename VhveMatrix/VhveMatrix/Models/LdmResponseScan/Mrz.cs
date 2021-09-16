namespace FedPol.BorderTask.Mobile.APIContract.Messages.LdmResponseScan
{
    public class Mrz
    {
        public string rawMrz { get; set; }
        public string mrzStatus { get; set; }
        public string docType { get; set; }
        public string docTypeStatus { get; set; }
        public string docIssuer { get; set; }
        public string docIssuerStatus { get; set; }
        public string docNumber { get; set; }
        public string docNumberStatus { get; set; }
        public string docNumberCheckSum { get; set; }
        public string docNumberExpectedCheckSum { get; set; }
        public string docExpiry { get; set; }
        public string docExpiryStatus { get; set; }
        public string docExpiryCheckSum { get; set; }
        public string docExpiryExpectedCheckSum { get; set; }
        public string lastName { get; set; }
        public string lastNameStatus { get; set; }
        public string firstName { get; set; }
        public string firstNameStatus { get; set; }
        public string birthDate { get; set; }
        public string birthDateStatus { get; set; }
        public string birthDateCheckSum { get; set; }
        public string birthDateExpectedCheckSum { get; set; }
        public string nationality { get; set; }
        public string nationalityStatus { get; set; }
        public string gender { get; set; }
        public string genderStatus { get; set; }
        public string optionalData1 { get; set; }
        public string optionalData2 { get; set; }
    }
}