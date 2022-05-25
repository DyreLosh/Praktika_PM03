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
using Lesson3.classes;

namespace Lesson3
{
    /// <summary>
    /// Логика взаимодействия для CrmWindow.xaml
    /// </summary>
    public partial class CrmWindow : Page
    {
        public CrmWindow()
        {
            InitializeComponent();
            crmGrid.ItemsSource = Lesson3Entities.GetContext().Заявки_CRM.ToList();
        }

        private void addCrm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new addWindow());
        }

        private void Page_IsVisibleChanged(object sender,DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Lesson3Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                crmGrid.ItemsSource = Lesson3Entities.GetContext().Заявки_CRM.ToList();
            }
        }
    }
}
