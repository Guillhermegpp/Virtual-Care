using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DataBaseApp.Models;
using DataBaseApp.ViewModels;

namespace DataBaseApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PatientDetailPage : ContentPage
	{
        PatientDetailViewModel viewModel;

        public PatientDetailPage(PatientDetailViewModel viewModel)
        {
            InitializeComponent();
            string result = "";
            foreach (Remedy r in viewModel.Item.Remedios)
            {
                result += r.ToString() + "\n";
            }
            BindingContext = this.viewModel = viewModel;
            //remedios.Text = result;

        }


        public PatientDetailPage()
        {
            InitializeComponent();
            

            var item = new Patient
            {
                Nome = "Nome",
                dataNascimento = "Data de Nascimento",
                tipoSangue = "Tipo Sanguineo",
                Peso = "Peso",
                Altura = "Altura"
            };

            viewModel = new PatientDetailViewModel(item);
            BindingContext = viewModel;
        }
        //async void AddItem_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new NewRemedyPage(viewModel)));
        //}
        async void Remedy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new RemedyPage(viewModel.Item, viewModel)));
        }

    }
}