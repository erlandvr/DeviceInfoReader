using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceInfoReader.DeviceInfo;
using DeviceInfoReader.DeviceInfo.Interfaces;
using Xamarin.Forms;

namespace DeviceInfoReader
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			App.Current.MainPage = new NavigationPage();
		}

		private async void Button_OnClicked(object sender, EventArgs e)
		{
			await App.Current.MainPage.Navigation.PushModalAsync(new DeviceInfoPage());
		}

		protected override bool OnBackButtonPressed() => base.OnBackButtonPressed();
	}
}
