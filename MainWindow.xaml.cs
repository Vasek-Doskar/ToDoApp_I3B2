using System.Windows;
using ToDoApp_I3B2.Database;
using ToDoApp_I3B2.Manager;

namespace ToDoApp_I3B2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ToDoManager _manager;
        public MainWindow()
        {
            _manager = new ToDoManager(new ToDoDbContext());

            InitializeComponent(); // od tohoto okamžiku je propojeno GUI (PŘIPOJILO TLAČÍTKO)
            //ToDoListBox.ItemsSource;

        }

       

    }

}
