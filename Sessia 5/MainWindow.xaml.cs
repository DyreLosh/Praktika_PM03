using Lesson3.classes;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Lesson3.Модуль_Биллинг;

namespace Lesson3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>\

    
    public partial class MainWindow : Window
    {
        public BitmapImage[] bitmapimages = new BitmapImage[7];
        public int CurrentImageNumber = 1;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new UsersWindow());
            Manager.MainFrame = MainFrame;
            usersBox.SelectedIndex = -1;

            

        }

        public void UsersBox_SelectionChanged(object sender, SelectionChangedEventArgs e) //Выбор роли и смена картинка в зависимости от роли
        {
            for (int i = 0; i < bitmapimages.Length; i++) //Смена иконки пользователя по ролям
            {
                bitmapimages[i] = new BitmapImage(new Uri($"Employees/{usersBox.SelectedIndex + 1}.jpg", UriKind.Relative));
            }
            if (CurrentImageNumber == 7)
            {
               imgEmp.Source = bitmapimages[0];
               CurrentImageNumber = 1;
            }
            else
            {
                imgEmp.Source = bitmapimages[CurrentImageNumber];
                CurrentImageNumber++;
            }

            if (usersBox.SelectedIndex == 0) //Руководитель отдела по работе с клиентами
            {
                support.Visibility = Visibility.Hidden;
                CRM.Visibility = Visibility.Visible;
                actv.Visibility = Visibility.Hidden;
                eqCtrl.Visibility = Visibility.Hidden;
                billing.Visibility = Visibility.Hidden;
                lsBox1.Visibility = Visibility.Visible;
                lsBox2.Visibility = Visibility.Visible;
                lsBox3.Visibility = Visibility.Visible;
                lsBox4.Visibility = Visibility.Hidden;
                lsBox5.Visibility = Visibility.Hidden;
                lsBox6.Visibility = Visibility.Hidden;
                lsBox7.Visibility = Visibility.Hidden;
                lsBox8.Visibility = Visibility.Hidden;
                lsBox9.Visibility = Visibility.Hidden;
                lsBox10.Visibility = Visibility.Hidden;
                lsBox11.Visibility = Visibility.Hidden;
                lsBox12.Visibility = Visibility.Hidden;
            }
            if (usersBox.SelectedIndex == 1) //Руководитель отдела технической поддержки
            {
                support.Visibility = Visibility.Visible;
                CRM.Visibility = Visibility.Visible;
                actv.Visibility = Visibility.Hidden;
                eqCtrl.Visibility = Visibility.Visible;
                billing.Visibility = Visibility.Hidden;
                lsBox1.Visibility = Visibility.Hidden;
                lsBox2.Visibility = Visibility.Hidden;
                lsBox3.Visibility = Visibility.Hidden;
                lsBox4.Visibility = Visibility.Hidden;
                lsBox5.Visibility = Visibility.Hidden;
                lsBox6.Visibility = Visibility.Hidden;
                lsBox7.Visibility = Visibility.Hidden;
                lsBox8.Visibility = Visibility.Hidden;
                lsBox9.Visibility = Visibility.Hidden;
                lsBox10.Visibility = Visibility.Hidden;
                lsBox11.Visibility = Visibility.Visible;
                lsBox12.Visibility = Visibility.Hidden;
            }
            if (usersBox.SelectedIndex == 2) //Специалист ТП (выездной инженер)
            {
                support.Visibility = Visibility.Visible;
                CRM.Visibility = Visibility.Visible;
                actv.Visibility = Visibility.Hidden;
                eqCtrl.Visibility = Visibility.Visible;
                billing.Visibility = Visibility.Hidden;
                lsBox1.Visibility = Visibility.Hidden;
                lsBox2.Visibility = Visibility.Hidden;
                lsBox3.Visibility = Visibility.Hidden;
                lsBox4.Visibility = Visibility.Hidden;
                lsBox5.Visibility = Visibility.Hidden;
                lsBox6.Visibility = Visibility.Hidden;
                lsBox7.Visibility = Visibility.Hidden;
                lsBox8.Visibility = Visibility.Hidden;
                lsBox9.Visibility = Visibility.Hidden;
                lsBox10.Visibility = Visibility.Hidden;
                lsBox11.Visibility = Visibility.Hidden;
                lsBox12.Visibility = Visibility.Visible;
            }
            if (usersBox.SelectedIndex == 3)//Директор по развитию
            {
                support.Visibility = Visibility.Visible;
                CRM.Visibility = Visibility.Visible;
                actv.Visibility = Visibility.Visible;
                eqCtrl.Visibility = Visibility.Visible;
                billing.Visibility = Visibility.Visible;
                lsBox1.Visibility = Visibility.Hidden;
                lsBox2.Visibility = Visibility.Hidden;
                lsBox3.Visibility = Visibility.Hidden;
                lsBox4.Visibility = Visibility.Hidden;
                lsBox5.Visibility = Visibility.Hidden;
                lsBox6.Visibility = Visibility.Hidden;
                lsBox7.Visibility = Visibility.Hidden;
                lsBox8.Visibility = Visibility.Hidden;
                lsBox9.Visibility = Visibility.Hidden;
                lsBox10.Visibility = Visibility.Hidden;
                lsBox11.Visibility = Visibility.Visible;
                lsBox12.Visibility = Visibility.Hidden;
            }
            if (usersBox.SelectedIndex == 4) //Технический департамент
            {
                support.Visibility = Visibility.Hidden;
                CRM.Visibility = Visibility.Visible;
                actv.Visibility = Visibility.Visible;
                eqCtrl.Visibility = Visibility.Visible;
                billing.Visibility = Visibility.Hidden;
                lsBox1.Visibility = Visibility.Hidden;
                lsBox2.Visibility = Visibility.Hidden;
                lsBox3.Visibility = Visibility.Hidden;
                lsBox4.Visibility = Visibility.Hidden;
                lsBox5.Visibility = Visibility.Hidden;
                lsBox6.Visibility = Visibility.Hidden;
                lsBox7.Visibility = Visibility.Hidden;
                lsBox8.Visibility = Visibility.Hidden;
                lsBox9.Visibility = Visibility.Hidden;
                lsBox10.Visibility = Visibility.Hidden;
                lsBox11.Visibility = Visibility.Hidden;
                lsBox12.Visibility = Visibility.Visible;
            }
            if (usersBox.SelectedIndex == 5) //Бухгалтер
            {
                support.Visibility = Visibility.Hidden;
                CRM.Visibility = Visibility.Hidden;
                actv.Visibility = Visibility.Visible;
                eqCtrl.Visibility = Visibility.Hidden;
                billing.Visibility = Visibility.Visible;
                lsBox1.Visibility = Visibility.Hidden;
                lsBox2.Visibility = Visibility.Hidden;
                lsBox3.Visibility = Visibility.Hidden;
                lsBox4.Visibility = Visibility.Hidden;
                lsBox5.Visibility = Visibility.Hidden;
                lsBox6.Visibility = Visibility.Hidden;
                lsBox7.Visibility = Visibility.Hidden;
                lsBox8.Visibility = Visibility.Hidden;
                lsBox9.Visibility = Visibility.Hidden;
                lsBox10.Visibility = Visibility.Hidden;
                lsBox11.Visibility = Visibility.Hidden;
                lsBox12.Visibility = Visibility.Hidden;
            }
            if (usersBox.SelectedIndex == 6) //Менеджер по работе с клиентами
            {
                support.Visibility = Visibility.Hidden;
                CRM.Visibility = Visibility.Visible;
                actv.Visibility = Visibility.Hidden;
                eqCtrl.Visibility = Visibility.Hidden;
                billing.Visibility = Visibility.Hidden;
                lsBox1.Visibility = Visibility.Hidden;
                lsBox2.Visibility = Visibility.Hidden;
                lsBox3.Visibility = Visibility.Hidden;
                lsBox4.Visibility = Visibility.Visible;
                lsBox5.Visibility = Visibility.Visible;
                lsBox6.Visibility = Visibility.Visible;
                lsBox7.Visibility = Visibility.Visible;
                lsBox8.Visibility = Visibility.Visible;
                lsBox9.Visibility = Visibility.Visible;
                lsBox10.Visibility = Visibility.Visible;
                lsBox11.Visibility = Visibility.Hidden;
                lsBox12.Visibility = Visibility.Hidden;
            }
            
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new UsersWindow());
        }

        private void CRM_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CrmWindow());
        }

        private void eqCtrl_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EqManagment());
        }

        private void actv_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void support_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubSupport());
        }

        private void billing_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Billing());
        }
    }
}


       
    

