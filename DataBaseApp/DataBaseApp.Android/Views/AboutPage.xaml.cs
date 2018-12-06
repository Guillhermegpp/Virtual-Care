using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBaseApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();

            BindingContext = this;

            adMobView.AdUnitId = "ca-app-pub-2634258062680705/6399774748";
        }
	}
}