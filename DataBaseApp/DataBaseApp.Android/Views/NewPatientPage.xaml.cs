using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DataBaseApp.Services;
using DataBaseApp.Models;

namespace DataBaseApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPatientPage : ContentPage
    {
        public Patient Item { get; set; }

        public NewPatientPage()
        {

            InitializeComponent();

            Item = new Patient
            {
                Nome = "",
                dataNascimento = "",
                tipoSangue = "",
                Peso = "",
                Altura = ""
            };
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await DisplayAlert("Remedio", "Paciente adicionado com sucesso", "Concluido");
            await Navigation.PopModalAsync();
        }
    }
}