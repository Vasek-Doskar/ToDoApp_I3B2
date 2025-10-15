using System.Collections.ObjectModel;
using System.Windows;
using ToDoApp_I3B2.Database;
using ToDoApp_I3B2.Manager;
using ToDoApp_I3B2.Model;

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

        }
    }

}
