using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;



namespace program{
    public class Program{
        public static void Main(string[] args){
            var taskList = TaskList.Instance;
            taskList.AddTask("Bolinha azul","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha vermelha","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha amarela","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha verde","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha rosa","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha laranja","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha preta","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha branca","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha cinza","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha violeta","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha ciano","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha magenta","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha rosa choque","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha verde-amaralada","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha cinza escuro","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha cinza claro","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha abobora","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha purpura","Isso definitivamente é uma bolinha de golfe");
            taskList.AddTask("Bolinha azul marinho","Isso definitivamente é uma bolinha de golfe");
            taskList.Print();
            Console.WriteLine("                       ");
            Console.WriteLine("                       ");
            Console.WriteLine("                       ");
            Console.WriteLine(taskList.RemoveTask("Bolinha azul"));
            Console.WriteLine(taskList.RemoveTask("Bolinha verde e amarelo"));
            Console.WriteLine("                       ");
            Console.WriteLine("                       ");
            Console.WriteLine("                       ");
            Console.WriteLine(taskList.FinishedTask("Bolinha de golfe"));
            Console.WriteLine(taskList.FinishedTask("Bolinha azul"));
            Console.WriteLine(taskList.FinishedTask("Bolinha amarela"));
            Console.WriteLine(taskList.FinishedTask("Bolinha verde"));
            Console.WriteLine(taskList.FinishedTask("Bolinha rosa"));
            Console.WriteLine("                       ");
            Console.WriteLine("                       ");
            Console.WriteLine("                       ");
            taskList.Print();
        }
    }
}