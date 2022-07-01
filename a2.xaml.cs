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
    /// Логика взаимодействия для a2.xaml
    /// </summary>
    public partial class a2 : Window
    {
        public a2()
        {
            InitializeComponent();
        }

        DB1Entities db = DB1Entities.GetContext();

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
                db.МОЛ.Add(p1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
