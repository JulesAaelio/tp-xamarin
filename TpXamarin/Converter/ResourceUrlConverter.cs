using System;
using System.Globalization;
using Xamarin.Forms;

namespace TpXamarin.Converter
{
    public class ResourceUrlConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"https://api.blog.juleslaurent.fr/{value}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}