

namespace DataBinding
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;

    public class Convertidores : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var saldo = (decimal)value;
            var color = Color.Green;
            if (saldo < 5000)
            {
                color = Color.Red;
            }
            else if (saldo >= 5000 && saldo <= 10000)
            {
                color = Color.Orange;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
