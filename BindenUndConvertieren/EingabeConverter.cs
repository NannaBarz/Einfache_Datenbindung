using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BindenUndConvertieren
{
    public class EingabeConverter : IValueConverter //public damit sie aus dem xaml aufgerufen werden kann und von IValueConverter erben. Schnittstelle implementieren
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //value ist der zu bindende Wert
            string wert = value.ToString();
            switch (wert)
            {
                case "1":
                    return "SEHR GUT";
                case "2":
                    return "GUT";
                case "3":
                    return "BEFRIEDIGEND";
                case "4":
                    return "AUSREICHEND";
                case "5":
                    return "MANGELHAFT";
                case "6":
                    return "UNGENÜGEND";

                default:
                    return "KEINE NOTE";
                   
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string wert = value.ToString();
            switch (wert)
            {
                case "SEHR GUT":
                    return "1";
                case "GUT":
                    return "2";
                case "BEFRIEDIGEND":
                    return "3";
                case "AUSREICHEND":
                    return "4";
                case "MANGELHAFT":
                    return "5";
                case "UNGENÜGEND":
                    return "6";

                default:
                    return "KEINE NOTE";

            }
        }
    }
}
