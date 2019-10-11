using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace RGB
{
    class Farbmischer : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte rot = System.Convert.ToByte(values[0]);
            byte gruen = System.Convert.ToByte(values[1]);
            byte blau = System.Convert.ToByte(values[2]);

            // Farbe erzeugen
            var c = Color.FromRgb(rot, gruen, blau);

            // Brush erzeugen
            return new SolidColorBrush(c);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
