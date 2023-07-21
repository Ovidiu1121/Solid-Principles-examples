using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._5
{
    public class InMemoryTaskRepository : ITaskRepository
    {
        private List<Task> _tasks;

        public InMemoryTaskRepository()
        {
            _tasks = new List<Task>();
        }

        public List<Task> GetAllTasks()
        {
            return _tasks;
        }

        public Task GetTaskById(int id)
        {
            return _tasks.Find(task => task.Id == id);
        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        public void UpdateTask(Task task)
        {
            int index = _tasks.FindIndex(t => t.Id == task.Id);
            if (index != -1)
            {
                _tasks[index] = task;
            }
        }

        public void DeleteTask(int id)
        {
            _tasks.RemoveAll(task => task.Id == id);
        }
    }
}
