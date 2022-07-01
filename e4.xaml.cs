﻿using System;
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
    /// Логика взаимодействия для e4.xaml
    /// </summary>
    public partial class e4 : Window
    {
        public e4()
        {
            InitializeComponent();
        }

        DB1Entities db = DB1Entities.GetContext();

        Подразделение p1;

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

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            p1.Код_подразделения = Convert.ToInt32(tt1.Text);
            p1.Наименование_подразделения = Convert.ToString(tt2.Text);
            p1.ФИО_мол = Convert.ToString(tt3.Text);

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
