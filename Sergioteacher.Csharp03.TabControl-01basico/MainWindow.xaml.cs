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

namespace Sergioteacher.Csharp03.TabControl_01basico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void T01_GotFocus(object sender, RoutedEventArgs e)
        {
            this.MsmDebug.Text = " Activo el tab 01";
        }

        
        private void T02_GotFocus(object sender, RoutedEventArgs e)
        {
            MsmDebug.Text = " Activo el tab 02";
        }

        private void T03_GotFocus(object sender, RoutedEventArgs e)
        {
            MsmDebug.Text = " Activo el tab 03";
        }
    }
}
