using System;
using System.Globalization;
using Xamarin.Forms;

namespace Tobinco.Converters
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "Black";
            var contnet = value.ToString();

            if (contnet == "True")
            {
                return Application.Current.Resources["ThemeBlueColor"];
            }
            else
            {
                return "Black";
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
