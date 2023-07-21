using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._5
{
    public interface ITaskRepository
    {
        List<Task> GetAllTasks();
        Task GetTaskById(int id);
        void AddTask(Task task);
        void UpdateTask(Task task);
        void DeleteTask(int id);
    }
}
