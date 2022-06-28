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

namespace var3
{
    /// <summary>
    /// Логика взаимодействия для InpectorPage.xaml
    /// </summary>
    public partial class InpectorPage : Page
    {
        vitEntities1 context;
        public InpectorPage()
        {
            InitializeComponent();
            context = new vitEntities1();
            InspectorPage.ItemsSource = context.Inspector.ToList();
        }

        private void GoViolation(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPAg());
        }

        private void GoDrivers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DriversPage());

        }

        private void GoCars(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CarsPage());

        }

        private void GoList(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new ListPage());
        }

        private void GoInspector(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InpectorPage());
        }
    
}
}
