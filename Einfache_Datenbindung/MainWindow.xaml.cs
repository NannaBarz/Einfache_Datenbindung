using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Einfache_Datenbindung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Combobox befüllen
            var sortlist = Fonts.SystemFontFamilies.OrderBy(f => f.ToString());

            var y = from x in Fonts.SystemFontFamilies
                    orderby x.ToString()
                    select x.ToString();

            cboFamilx.ItemsSource = y;

            var props = typeof(Brushes).GetProperties();//alle Props von brushes in props ablegen
            var names = from n in props                 //die namen der Properties von props in names speichern
                        select n.Name;

            cboBrushes.ItemsSource = names;


        }

        private void CboFamilx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CboBrushes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
