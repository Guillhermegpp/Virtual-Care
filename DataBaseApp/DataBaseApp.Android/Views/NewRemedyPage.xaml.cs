using Android;
using Android.App;
using Android.Widget;
using DataBaseApp.Alarmss;
using DataBaseApp.Models;
using DataBaseApp.Services;
using DataBaseApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBaseApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewRemedyPage : ContentPage
	{
        PatientDetailViewModel viewModel; 
        public Remedy Item { get; set; }
        public NewRemedyPage (PatientDetailViewModel viewModel)
        {
            this.viewModel = viewModel;
            InitializeComponent();
            Item = new Remedy
            {
                HoraIntervalo = "",
                RemedioNome = ""
            };
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            Remedy remedio = new Remedy();
            remedio.RemedioNome = nome.Text;
            remedio.HoraRemedio = DateTime.Now + TimeSpan.Parse(hora.Text);
            viewModel.Item.Remedios.Add(remedio);

            for (int c = 0; c < int.Parse(vezes.Text)-1; c++)
            {
                Remedy aux = remedio;
                remedio = new Remedy();
                remedio.RemedioNome = nome.Text;
                remedio.HoraRemedio = aux.HoraRemedio + TimeSpan.Parse(hora.Text);

                viewModel.Item.Remedios.Add(remedio);

            }
            //onReceiverAlarm(remedio.horaRemedio);
            MockDataStore.SaveHistorical();
            await DisplayAlert("Remedio", "Remedio adicionado com sucesso","Concluido");
            await Navigation.PopModalAsync();

        }

        AlarmStorage alarmStorage;
        IAlarmAddListener alarmAddListener;
        AlarmUtil alarmUtil;
        void onReceiverAlarm(DateTime data)
        {
            DateTime alarmTime = alarmUtil.GetNextAlarmTime(data.Hour, data.Minute);
            Alarm alarm = alarmStorage.SaveAlarm(alarmTime.Year, alarmTime.Month, alarmTime.Day,
                                                  alarmTime.Hour, alarmTime.Minute);
            string alarmSavedString = "Alarme configurado para: "  + alarm.Hour + alarm.Minute;
            Toast.MakeText(Android.App.Application.Context, alarmSavedString, ToastLength.Short).Show();

            if (alarmAddListener != null)
                alarmAddListener.OnAlarmAdded(alarm);
        }
    }
    public interface IAlarmAddListener
    {
        void OnAlarmAdded(Alarm alarm);
    }
}