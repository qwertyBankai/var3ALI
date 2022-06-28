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
    /// Логика взаимодействия для ListElementPage.xaml
    /// </summary>
    public partial class ListElementPage : Page
    {
        vitEntities1 context;
        public ListElementPage(vitEntities1 context, Violation violation)
        {
            InitializeComponent();
            this.context = context;
            ViolationTable.ItemsSource = context.Violation.ToList().Where(x => x.id == violation.id).ToList();
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
