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
using System.Data.Entity;

namespace basedata21
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DB1Entities db = DB1Entities.GetContext();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.Группа_основных_средств.Load();
            grid1.ItemsSource = db.Группа_основных_средств.Local.ToBindingList();
        }

        private void Window_Loaded2(object sender, RoutedEventArgs e)
        {
            db.МОЛ.Load();
            grid2.ItemsSource = db.МОЛ.Local.ToBindingList();
        }

        private void Window_Loaded3(object sender, RoutedEventArgs e)
        {
            db.Основные_средства.Load();
            grid3.ItemsSource = db.Основные_средства.Local.ToBindingList();
        }

        private void Window_Loaded4(object sender, RoutedEventArgs e)
        {
            db.Подразделение.Load();
            grid4.ItemsSource = db.Подразделение.Local.ToBindingList();
        }

        private void a1_Click(object sender, RoutedEventArgs e)
        {
            a1 f = new a1();
            f.ShowDialog();
            grid1.Focus();

            db.Группа_основных_средств.Load();
            grid1.ItemsSource = db.Группа_основных_средств.ToList();
            grid1.ItemsSource = db.Группа_основных_средств.Local.ToBindingList();
        }

        private void a2_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = grid1.SelectedIndex;
            if (indexRow != -1)
            {
                Группа_основных_средств row = (Группа_основных_средств)grid1.Items[indexRow];

                Class1.Код_группы = row.Код_группы;
                Class1.Наименование_группы = row.Наименование_группы;
                Class1.Годовая_норма_амортизации = row.Годовая_норма_амортизации;

                e1 f = new e1();
                f.ShowDialog();

                grid1.Items.Refresh();
                grid1.Focus();
            }
        }

        private void a3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("удалить запись?", "удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Группа_основных_средств row = (Группа_основных_средств)grid1.SelectedItems[0];

                    db.Группа_основных_средств.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("выберите запись");
                }
            }
        }






        private void b1_Click(object sender, RoutedEventArgs e)
        {
            a2 f = new a2();
            f.ShowDialog();
            grid2.Focus();

            db.МОЛ.Load();
            grid2.ItemsSource = db.МОЛ.ToList();
            grid2.ItemsSource = db.МОЛ.Local.ToBindingList();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = grid2.SelectedIndex;
            if (indexRow != -1)
            {
                МОЛ row = (МОЛ)grid2.Items[indexRow];

                Class2.Табельный_номер = row.Табельный_номер;
                Class2.ФИО = row.ФИО;
                Class2.Дата_рождения = row.Дата_рождения;
                Class2.Адрес = row.Адрес;
                Class2.Телефон = row.Телефон;

                e2 f = new e2();
                f.ShowDialog();

                grid2.Items.Refresh();
                grid2.Focus();
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("удалить запись?", "удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    МОЛ row = (МОЛ)grid2.SelectedItems[0];

                    db.МОЛ.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("выберите запись");
                }
            }
        }







        private void c1_Click(object sender, RoutedEventArgs e)
        {
            a3 f = new a3();
            f.ShowDialog();
            grid3.Focus();

            db.Основные_средства.Load();
            grid3.ItemsSource = db.Основные_средства.ToList();
            grid3.ItemsSource = db.Основные_средства.Local.ToBindingList();
        }

        private void c2_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = grid3.SelectedIndex;
            if (indexRow != -1)
            {
                Основные_средства row = (Основные_средства)grid3.Items[indexRow];

                Class3.Инвентарный_номер = row.Инвентарный_номер;
                Class3.Наименование = row.Наименование;
                Class3.Код_группы = row.Код_группы;
                Class3.Первоначальная_стоимость = row.Первоначальная_стоимость;
                Class3.Дата_ввода_в_эксплуатацию = row.Дата_ввода_в_эксплуатацию;
                Class3.Код_подразделения = row.Код_подразделения;

                e3 f = new e3();
                f.ShowDialog();

                grid3.Items.Refresh();
                grid3.Focus();
            }
        }

        private void c3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("удалить запись?", "удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Основные_средства row = (Основные_средства)grid3.SelectedItems[0];

                    db.Основные_средства.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("выберите запись");
                }
            }
        }






        private void d1_Click(object sender, RoutedEventArgs e)
        {
            a4 f = new a4();
            f.ShowDialog();
            grid4.Focus();

            db.Подразделение.Load();
            grid4.ItemsSource = db.Подразделение.ToList();
            grid4.ItemsSource = db.Подразделение.Local.ToBindingList();
        }

        private void d2_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = grid4.SelectedIndex;
            if (indexRow != -1)
            {
                Подразделение row = (Подразделение)grid4.Items[indexRow];

                Class4.Код_подразделения = row.Код_подразделения;
                Class4.Наименование_подразделения = row.Наименование_подразделения;
                Class4.ФИО_мол = row.ФИО_мол;

                e4 f = new e4();
                f.ShowDialog();

                grid4.Items.Refresh();
                grid4.Focus();
            }
        }

        private void d3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("удалить запись?", "удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Подразделение row = (Подразделение)grid4.SelectedItems[0];

                    db.Подразделение.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("выберите запись");
                }
            }
        }
        //DB1Entities


    }
}
