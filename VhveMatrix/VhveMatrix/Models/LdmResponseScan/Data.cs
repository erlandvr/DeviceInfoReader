namespace FedPol.BorderTask.Mobile.APIContract.Messages.LdmResponseScan
{
    public class Data
    {
        public Rfchip rfChip { get; set; }
        public Mrz mrz { get; set; }
        public Viz viz { get; set; }
        public Scan scan { get; set; }
        public Infos infos { get; set; }
        public Securitychecks securityChecks { get; set; }
        public Otherfields otherFields { get; set; }
    }
}