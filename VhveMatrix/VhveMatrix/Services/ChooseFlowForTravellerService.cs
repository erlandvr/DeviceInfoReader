using VhveMatrix.VhveMatrix.Enums;
using Xamarin.Forms;

namespace VhveMatrix.VhveMatrix.Services
{
	public class ChooseFlowForTravellerService
	{
		public static TravellerFlow GetFlowForTravellerType(TravellerTypeIdentifier travellerTypeIdentifier) => travellerTypeIdentifier switch
		{
			TravellerTypeIdentifier.EU_Citizen => TravellerFlow.EU_CitizenFlow,
			TravellerTypeIdentifier.TCN_VH_Residence_permit => TravellerFlow.TCN_ResidencePermitFlow,
			TravellerTypeIdentifier.No_travel_document => TravellerFlow.DefaultFlow,
			TravellerTypeIdentifier.Auto => TravellerFlow.TCN_VisaHolderFlow,
			TravellerTypeIdentifier.TCN_VE_Default => TravellerFlow.TCN_VisaExemptFlow,
			TravellerTypeIdentifier.TCN_VE_Member_of_family => TravellerFlow.TCN_VisaExemptFlow,
			TravellerTypeIdentifier.TCN_VE_Right_of_free_movement => TravellerFlow.TCN_VisaExemptFlow,
			TravellerTypeIdentifier.TCN_VH_Default => TravellerFlow.TCN_VisaHolderFlow
		};
	}
}