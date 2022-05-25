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

namespace Lesson3.Модуль_Биллинг
{
    /// <summary>
    /// Логика взаимодействия для Billing.xaml
    /// </summary>
    public partial class Billing : Page
    {
        public Billing()
        {
            InitializeComponent();
            Tarifs.ItemsSource = Lesson3Entities.GetContext().Тарифы_абонентов.ToList();
            Plateji.ItemsSource = Lesson3Entities.GetContext().Платежи_абонентов.ToList();
            /*Serv.ItemsSource = Lesson3Entities.GetContext().Заявки_CRM.ToList();
            Serv.SelectedIndex = -1;
            Serv.SelectedValue = "Услуга";
            Serv.DisplayMemberPath = "Услуга";*/
        }
    }
}
