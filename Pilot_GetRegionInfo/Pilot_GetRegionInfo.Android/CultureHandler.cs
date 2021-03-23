using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Pilot_GetRegionInfo.Droid;
using Pilot_GetRegionInfo.Interfaces;
using Pilot_GetRegionInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof (CultureHandler))]
namespace Pilot_GetRegionInfo.Droid
{
    public class CultureHandler : ICultureHandler
    {
        public CultureHandlerModel GetCultureHandler()
        {
            var locale = Thread.CurrentThread.CurrentCulture;
            var result = new CultureHandlerModel()
            {
                Languages = locale.TwoLetterISOLanguageName,
                Region = locale.DisplayName
            };
            return result;
        }
    }
}