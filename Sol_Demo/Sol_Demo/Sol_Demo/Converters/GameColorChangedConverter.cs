using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Sol_Demo.Converters
{
    public class GameColorChangedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var platformName = value as string;

            if (platformName == "Sony")
            {
                return Color.Orange;
            }
            else if (platformName == "Android")
            {
                return Color.WhiteSmoke;
            }
            else if (platformName == "XBox")
            {
                return Color.Green;
            }

            return Color.Orange;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}