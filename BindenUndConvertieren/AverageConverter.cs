using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BindenUndConvertieren
{
    public class AverageConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            //druchschnitt der werte bilden
            double average = 0.0;
            foreach (var item in values)
            {
                double d;
                Double.TryParse(item.ToString(), out d);
                average += d;
            }
            return average / values.Length;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
