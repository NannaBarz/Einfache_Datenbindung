using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace BindenUndConvertieren
{
    public class ZahlConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int wert;
            var erg = Int32.TryParse(value.ToString(), out wert);

            if (!erg) return Brushes.Magenta;

            if (wert == 0) return Brushes.Gainsboro;

            if (wert > 0) return Brushes.LightGreen;

            else return Brushes.Red;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
