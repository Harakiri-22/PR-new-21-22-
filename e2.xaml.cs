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
using System.Windows.Shapes;

namespace basedata21
{
    /// <summary>
    /// Логика взаимодействия для e2.xaml
    /// </summary>
    public partial class e2 : Window
    {
        public e2()
        {
            InitializeComponent();
        }

        DB1Entities db = DB1Entities.GetContext();
        МОЛ p1;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            p1 = db.МОЛ.Where(p => p.Табельный_номер == Class2.Табельный_номер).FirstOrDefault();

            tt1.Text = Convert.ToString(p1.Табельный_номер);
            tt2.Text = Convert.ToString(p1.ФИО);
            tt3.Text = Convert.ToString(p1.Дата_рождения);
            tt3_Copy1.Text = Convert.ToString(p1.Адрес);
            tt3_Copy.Text = Convert.ToString(p1.Телефон);

        }

        private void bb11_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (tt1.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt2.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt3.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt3_Copy1.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (tt3_Copy.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            МОЛ p1 = new МОЛ();

            p1.Табельный_номер = Convert.ToInt32(tt1.Text);
            p1.ФИО = Convert.ToString(tt2.Text);
            p1.Дата_рождения = Convert.ToDateTime(tt3.Text);
            p1.Адрес = Convert.ToString(tt3_Copy1.Text);
            p1.Телефон = Convert.ToInt32(tt3_Copy.Text);

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
