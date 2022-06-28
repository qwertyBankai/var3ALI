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
    /// Логика взаимодействия для HistoryDriverCars.xaml
    /// </summary>
    public partial class HistoryDriverCars : Page
    {
        vitEntities1 context;
        public HistoryDriverCars(vitEntities1 context, DriversCars driversCars)
        {
            InitializeComponent();
            this.context = context;

            One.Content = driversCars.FioDriver;
            Two.Content = driversCars.dateStartHaving;
            Three.Content = driversCars.dateEndhaving;
        }
    }
}
