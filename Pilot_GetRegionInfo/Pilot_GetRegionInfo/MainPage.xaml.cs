using Pilot_GetRegionInfo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Pilot_GetRegionInfo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var x = CultureInfo.CurrentCulture;
            var service = DependencyService.Get<ICultureHandler>();
            var result = service.GetCultureHandler();

            Device.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert("Region and Languages", $"Region : {result.Region} \nLanguages : {result.Languages}", "Ok");
            });
        }
    }
}
