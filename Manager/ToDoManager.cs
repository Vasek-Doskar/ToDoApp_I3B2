using ToDoApp_I3B2.Database;
using ToDoApp_I3B2.Model;

namespace ToDoApp_I3B2.Manager
{
    public class ToDoManager
    {
        private readonly ToDoDbContext _dbContext;

        public ToDoManager(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(ToDo todo)
        {
            _dbContext.Add(todo);
            _dbContext.SaveChanges();
        }

        public void Remove(ToDo todo)
        {
            _dbContext.Remove(todo);
            _dbContext.SaveChanges();
        }

        public void Update(ToDo todo)
        {
            _dbContext.Update(todo);
            _dbContext.SaveChanges();
        }
        
        public ToDo GetById(int id)
        {
            ToDo? todo = _dbContext.Find<ToDo>(id);
            if(todo == null) 
                throw new Exception("Hledaný prvek není v DB");
            return todo;
        }

        public IList<ToDo> GetAll() => _dbContext.ToDos.ToList();
    }
}
