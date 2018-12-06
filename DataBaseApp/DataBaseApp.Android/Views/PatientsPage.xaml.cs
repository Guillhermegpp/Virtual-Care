using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DataBaseApp.Models;
using DataBaseApp.Views;
using DataBaseApp.ViewModels;
using DataBaseApp.Droid.Views;

namespace DataBaseApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PatientsPage : ContentPage
	{
        PatientsViewModel viewModel;

        public PatientsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PatientsViewModel();
        }
        static Patient patient = null;
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Patient;
            if (item == null)
                return;
            patient = item;
            await Navigation.PushAsync(new PatientDetailPage(new PatientDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewPatientPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Ad());
        }
    }
}