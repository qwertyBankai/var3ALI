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
    /// Логика взаимодействия для maket.xaml
    /// </summary>
    public partial class maket : Page
    {
        public maket(bool isIns)
        {
            InitializeComponent();
            
            if(isIns == false)
            {
                violBtn.Visibility = Visibility.Hidden;
                CarBtn.Visibility = Visibility.Hidden;
                ListBtn.Visibility = Visibility.Hidden;
                InsBtn.Visibility = Visibility.Hidden;
                FormBtn.Visibility = Visibility.Hidden;
            }

            frame.NavigationService.Navigate(new MainPAg());
        }
        public maket()
        {
            InitializeComponent();
            frame.NavigationService.Navigate(new MainPAg());
        }
        private void GoList(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new ListPage());
        }

        private void GoInspector(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new InpectorPage());

        }
        private void GoViolation(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new MainPAg());
        }

        private void GoDrivers(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new DriversPage());
        }

        private void GoCars(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CarsPage());

        }

        private void GoForm(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new FormPage());
        }
    }
}
