using System;
using System.Collections;
using System.Collections.Generic;

namespace Explicaciones
{
    using System;
    using System.Collections.Generic;

    // Modelo
    class TaskModel
    {
        public List<string> Tasks { get; } = new List<string>();
    }

    // Vista
    class TaskView
    {
        public void DisplayTasks(List<string> tasks)
        {
            Console.WriteLine("Lista de tareas:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }

    // Controlador
    class TaskController
    {
        private TaskModel model;
        private TaskView view;

        public TaskController(TaskModel model, TaskView view)
        {
            this.model = model;
            this.view = view;
        }

        public void AddTask(string task)
        {
            model.Tasks.Add(task);
        }

        public void ShowTasks()
        {
            view.DisplayTasks(model.Tasks);
        }
    }

    class Program
    {
        static void Main()
        {
            //V1
            // Crear instancias del Modelo, Vista y Controlador
            TaskModel model = new TaskModel();
            TaskView view = new TaskView();
            TaskController controller = new TaskController(model, view);

            // Agregar tareas a través del Controlador
            controller.AddTask("Hacer la compra");
            controller.AddTask("Estudiar para el examen");

            // Mostrar la lista de tareas a través del Controlador
            controller.ShowTasks();




        }
    }


  
}


