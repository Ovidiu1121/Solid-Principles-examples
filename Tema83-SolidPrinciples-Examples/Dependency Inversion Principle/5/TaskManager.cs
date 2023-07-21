using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Dependency_Inversion_Principle._5
{
    public class TaskManager
    {
        private readonly ITaskRepository _taskRepository;

        public TaskManager(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void AddTask(string description)
        {
            Task newTask = new Task
            {
                Id = GenerateNewTaskId(),
                Description = description,
                IsCompleted = false
            };

            _taskRepository.AddTask(newTask);
        }

        public List<Task> GetAllTasks()
        {
            return _taskRepository.GetAllTasks();
        }

        public Task GetTaskById(int id)
        {
            return _taskRepository.GetTaskById(id);
        }

        public void UpdateTask(Task task)
        {
            _taskRepository.UpdateTask(task);
        }

        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
        }

        private int GenerateNewTaskId()
        {
            // Simulăm generarea unui nou ID pentru sarcină
            // Într-un sistem real, am folosi un mecanism mai complex de generare a ID-urilor
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}
