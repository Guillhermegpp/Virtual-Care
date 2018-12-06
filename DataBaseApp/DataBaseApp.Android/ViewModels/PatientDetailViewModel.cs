using System;

using DataBaseApp.Models;
using Xamarin.Forms;

namespace DataBaseApp.ViewModels
{
    public class PatientDetailViewModel : BaseViewModel
    {
        public Patient Item { get; set; }
        public PatientDetailViewModel(Patient item = null)
        {
            Title = item?.Nome;
            Item = item;
        }

    }
}
