using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBaseApp.Droid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ad : ContentPage
    {
        public Ad()
        {
            InitializeComponent();

            BindingContext = this;

            adMobView.AdUnitId = "ca-app-pub-2634258062680705/6399774748";
        }
    }
}