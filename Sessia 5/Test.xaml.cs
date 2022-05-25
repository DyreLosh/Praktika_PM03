using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    class MyViewModel
    {
        public ICollectionView CollectionView { get; set; }
        public ICommand DoubleClickCommand { get; set; }
    }
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        public Test()
        {
            InitializeComponent();
            TestGrid.ItemsSource= Lesson3Entities.GetContext().Абоненты.ToList();

        }

        private void TestGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new Test());
        }
    }
}
