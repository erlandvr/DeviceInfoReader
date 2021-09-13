namespace VhveMatrix.VhveMatrix.Models.TravellerFlow.Flows
{
	public class TCN_VisaHolderFlow :BaseFlow
	{
		private FacialIdentificationStep _facialIdentificationStep;
		private FingerPrintIdentificationStep _fingerPrintIdentificationStep;
		private ScanVisaStep _scanVisaStep;
	}
}