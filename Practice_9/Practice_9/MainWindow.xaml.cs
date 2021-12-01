using System;
using System.Collections.Generic;
using System.Data;
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

namespace Practice_9
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
        private Student[] students = new Student[10];
        public int Counter;

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            students[Counter] = new Student($"{lastName.Text}", $"{street.Text}", int.Parse(houseNumber.Text), int.Parse(apartment.Text));
            Counter++;
            dataGrid.ItemsSource = ToDataTable(students).DefaultView;
        }

        private void FindStudents_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Street == findStreet.Text)
                {
                    counter++;
                }
            }
            result.Text = counter.ToString();
        }

        private static DataTable ToDataTable(Student[] students)
        {
            var res = new DataTable();

            res.Columns.Add("Фамилия", typeof(string));
            res.Columns.Add("Улица", typeof(string));
            res.Columns.Add("Номер_дома", typeof(int));
            res.Columns.Add("Квартира", typeof(int));

            for (int i = 0; i < students.Length; i++)
            {
                var row = res.NewRow();
                row.ItemArray = new object[] { students[i].LastName, students[i].Street, students[i].HouseNumber, students[i].Apartment };
                res.Rows.Add(row);
            }
            return res;
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Золотарев М. А.\n Группа: ИСП-34\n Вариант №13", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
