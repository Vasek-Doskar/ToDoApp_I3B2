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
using ToDoApp_I3B2.Manager;
using ToDoApp_I3B2.Model;

namespace ToDoApp_I3B2.Windows
{
    /// <summary>
    /// Interakční logika pro NewTodoWindow.xaml
    /// </summary>
    public partial class NewTodoWindow : Window
    {
        private readonly ToDoManager _manager;
        public NewTodoWindow(ToDoManager manager)
        {
            _manager = manager;
            InitializeComponent();
        }

        private void SaveTodo(object sender, RoutedEventArgs e)
        {
            string title = TitleInput.Text;
            bool isDone = IsDoneInput.IsChecked == true;
            if (title != string.Empty) 
            { 
                ToDo todo = new ToDo() { IsDone = isDone, Title=title };
                _manager.Add(todo);
                Close();
            }
        }

        private void CancelWindow(object sender, RoutedEventArgs e) => Close();

    }
}
