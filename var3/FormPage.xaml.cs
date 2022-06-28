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
    /// Логика взаимодействия для FormPage.xaml
    /// </summary>
    public partial class FormPage : Page
    {
        vitEntities1 context;
        public FormPage()
        {
            InitializeComponent();
            context = new vitEntities1();
            violCombo.ItemsSource = context.Violation.ToList();
        }

        private void AddNewViol(object sender, RoutedEventArgs e)
        {
            if(context.Driver.Any(x=> x.name == numDriverBox.Text))
            {
                if(context.Car.Any(x=> x.StateNumber == gosBox.Text))
                {
                    int maxId = context.Incident.Max(x=> x.id);
                    Incident incident = new Incident()
                    {
                        id = maxId + 1,
                        idInspector = 1000,
                        idDriver = numDriverBox.Text,
                        idCar = gosBox.Text,
                        date = Convert.ToDateTime(startDateBox.Text),
                        area = areaBox.Text,
                        deprivationLicense = null
                    };
                    context.SaveChanges();
                }
            }
        }

        private void test(object sender, SelectionChangedEventArgs e)
        {
            if (violCombo.SelectedIndex > 0)
            {
                //
                Violation violation = violCombo.SelectedItem as Violation;
                if (violation.deprivationLicense != null || violation.deprivationLicense == "")
                {
                    MessageBox.Show("Диапазон штрафов" + violation.penaltyRange + " " + "Диапазон лишения прав" + violation.deprivationLicense);
                }
                else
                {
                    MessageBox.Show("Диапазон штрафов" + violation.penaltyRange);

                }
            }


        }
    }
}
