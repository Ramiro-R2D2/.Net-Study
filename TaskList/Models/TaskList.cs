using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models;

public class TaskList
{
    private static TaskList instance;
    private TaskList(){} //Padrão Singleton
        public static TaskList Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new TaskList(); // Cria a instância única na primeira chamada
            }

            return instance;
        }
    }
    private List<Task> tasks = new List<Task>();
    public void AddTask(String Title, String Description){
        tasks.Add(new Task(Title, Description));
    }
    public void Print(){
        foreach(var task in tasks){
            Console.WriteLine(task.Title);
        }
    }
    public String RemoveTask(String Title){
        String tempTask;
        foreach(var task in tasks){
            if(task.Title.Equals(Title)){
                tempTask = task.Title;
                tasks.Remove(task);
                return $"The task with Title:{tempTask} is finished";
            }
        }
        return $"Task with title: {Title} not found";
    }
    public String FinishedTask(String Title){
        String tempTask;
        foreach(var task in tasks){
            if(task.Title.Equals(Title)){
                tempTask = task.Title;
                tasks.Remove(task);
                return $"The task with Title:{tempTask} is finished";
            }
        }
        return $"Task with title: {Title} not found";
    }
    // AddTask, PrintTask, RemoveTask and FinishedTask

}
