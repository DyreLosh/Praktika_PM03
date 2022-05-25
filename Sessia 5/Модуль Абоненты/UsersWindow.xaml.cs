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
    /// Логика взаимодействия для UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Page
    {
        public UsersWindow()
        {
            InitializeComponent();
            usersGrid.ItemsSource = Lesson3Entities.GetContext().Абоненты.ToList();
        }

        private void checkActiv_Checked(object sender, RoutedEventArgs e)
        {
                  
        }
    }
}

