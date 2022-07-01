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
    /// Логика взаимодействия для e3.xaml
    /// </summary>
    public partial class e3 : Window
    {
        public e3()
        {
            InitializeComponent();
        }

        DB1Entities db = DB1Entities.GetContext();
        Основные_средства p1;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            p1 = db.Основные_средства.Where(p => p.Инвентарный_номер == Class3.Инвентарный_номер).FirstOrDefault();

            tt1.Text = Convert.ToString(p1.Инвентарный_номер);
            tt2.Text = Convert.ToString(p1.Наименование);
            tt3.Text = Convert.ToString(p1.Код_группы);
            tt3_Copy1.Text = Convert.ToString(p1.Первоначальная_стоимость);
            tt3_Copy.Text = Convert.ToString(p1.Дата_ввода_в_эксплуатацию);
            tt3_Copy2.Text = Convert.ToString(p1.Код_подразделения);

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
            if (tt3_Copy2.Text.Length == 0)
            {
                errors.AppendLine("error");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            p1.Инвентарный_номер = Convert.ToInt32(tt1.Text);
            p1.Наименование = Convert.ToString(tt2.Text);
            p1.Код_группы = Convert.ToInt32(tt3.Text);
            p1.Первоначальная_стоимость = Convert.ToInt32(tt3_Copy1.Text);
            p1.Дата_ввода_в_эксплуатацию = Convert.ToDateTime(tt3_Copy.Text);
            p1.Код_подразделения = Convert.ToInt32(tt3_Copy2.Text);

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
