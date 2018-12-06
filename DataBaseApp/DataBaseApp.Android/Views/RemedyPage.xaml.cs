using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseApp.Models;
using DataBaseApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBaseApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RemedyPage : ContentPage
	{
        private PatientDetailViewModel viewModel;

        public RemedyPage ()
		{
			InitializeComponent ();
		}

        public RemedyPage(Patient patient, PatientDetailViewModel viewModel)
        {
            
            InitializeComponent();
            this.viewModel = viewModel;
            string result = "";
            foreach (Remedy r in patient.Remedios)
            {
                result += r.ToString() + "\n";
            }
            remedios.Text = result;

        }
        public void carregarLabel()
        {
            string result = "";
            foreach (Remedy r in viewModel.Item.Remedios)
            {
                result += r.ToString() + "\n";
            }
            remedios.Text = result;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            carregarLabel();
        }


        async void AddItem_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopModalAsync();
            await Navigation.PushModalAsync(new NavigationPage(new NewRemedyPage(viewModel)));
        }

       
    }
}