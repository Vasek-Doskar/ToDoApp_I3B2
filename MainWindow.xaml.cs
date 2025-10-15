using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using ToDoApp_I3B2.Database;
using ToDoApp_I3B2.Manager;
using ToDoApp_I3B2.Model;
using ToDoApp_I3B2.Windows;

namespace ToDoApp_I3B2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ToDoManager _manager;
        public ObservableCollection<ToDo> Todos { get; set; } // automaticky se refreshující kolekce
        public MainWindow()
        {
            _manager = new ToDoManager(new ToDoDbContext());
            Todos = new ObservableCollection<ToDo>(_manager.GetAll());
            InitializeComponent(); // od tohoto okamžiku je propojeno GUI (PŘIPOJILO TLAČÍTKO)
            ToDoListBox.ItemsSource = Todos;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox cbox && cbox.DataContext is ToDo todo) 
            {
                todo.IsDone = cbox.IsChecked == true;
                _manager.Update(todo);
            }
        }

        private void AddNew(object sender, RoutedEventArgs e)
        {
            NewTodoWindow newTodoWindow = new(_manager);
            newTodoWindow.Closed += (s, e) =>
            {
                Todos.Clear();
                _manager.GetAll().ToList().ForEach(todo => Todos.Add(todo));
            };

            newTodoWindow.ShowDialog();
        }
        private void RemoveSelectedTodo(object sender, RoutedEventArgs e)
        {
           
        }

    }

}
