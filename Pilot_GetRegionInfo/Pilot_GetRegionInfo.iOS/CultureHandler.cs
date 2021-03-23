using Foundation;
using Pilot_GetRegionInfo.Interfaces;
using Pilot_GetRegionInfo.iOS;
using Pilot_GetRegionInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(CultureHandler))]
namespace Pilot_GetRegionInfo.iOS
{
    public class CultureHandler : ICultureHandler
    {
        public CultureHandlerModel GetCultureHandler()
        {
            var lang = NSLocale.CurrentLocale;
            var result = new CultureHandlerModel()
            {
                Languages = lang.LanguageCode,
                Region = lang.LocaleIdentifier
            };
            return result;
        }
    }
}