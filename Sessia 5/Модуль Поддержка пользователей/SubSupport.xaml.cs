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

namespace Lesson3
{
    /// <summary>
    /// Логика взаимодействия для SubSupport.xaml
    /// </summary>
    public partial class SubSupport : Page
    {
        public SubSupport()
        {
            InitializeComponent();
            ComboUsers.ItemsSource = Lesson3Entities.GetContext().Абоненты.ToList();
            ComboUsers.SelectedIndex = -1;
            ComboUsers.SelectedValue ="ФИО";
            ComboUsers.DisplayMemberPath = "ФИО";
        }
    }
}
