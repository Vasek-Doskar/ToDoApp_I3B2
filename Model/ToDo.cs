using System.ComponentModel;

namespace ToDoApp_I3B2.Model
{
    public class ToDo : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Title { get; set; }

        private bool _isDone;

        public ToDo() { }

        public ToDo(int id, string title, bool isDone) : this()
        {
            Id = id;
            Title = title;
            _isDone = isDone;
        }

        public bool IsDone
        {
            get => _isDone;
            set
            {
                _isDone = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsDone)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
