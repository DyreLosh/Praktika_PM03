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
    /// Логика взаимодействия для addWindow.xaml
    /// </summary>
    public partial class addWindow : Page
    {

        private Заявки_CRM Zayvka_CRM = new Заявки_CRM();
        public addWindow()
        {
            InitializeComponent();
            DataContext = Zayvka_CRM;
            LSBox.ItemsSource = Lesson3Entities.GetContext().Абоненты.ToList();

            LSBox.SelectedIndex = 0;
            LSBox.DisplayMemberPath = "Лицевой_счет";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

           if (LSBox.SelectedIndex < 1)
                errors.AppendLine("Укажите лицевой счет абонента");  
            if (string.IsNullOrWhiteSpace( Zayvka_CRM.Услуга))
                errors.AppendLine("Укажите услугу");
          if (string.IsNullOrWhiteSpace(Zayvka_CRM.Вид_услуги))
               errors.AppendLine("Укажите вид услуги");
            if (string.IsNullOrWhiteSpace(Zayvka_CRM.Тип_услуги))
                errors.AppendLine("Укажите тип услуги");
            if (string.IsNullOrWhiteSpace(Zayvka_CRM.Статус))
               errors.AppendLine("Укажите статус заявки");
           if (string.IsNullOrWhiteSpace(Zayvka_CRM.Тип_проблема))
                errors.AppendLine("Укажите тип проблемы");
         
            if(errors.Length>0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if( Zayvka_CRM.номер_заявки != null)
               Lesson3Entities.GetContext().Заявки_CRM.Add(Zayvka_CRM);

            try
            {
                Lesson3Entities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
