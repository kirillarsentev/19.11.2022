using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19._11._2022.Classes
{
    internal class Employee
    {
        private string name;
        private string task;
        private string duty;
        public int count;
        public string[] status = new string[4] { "назначена", "в работе", "на проверке", "выполнена" };


        public Employee(string name, string duty)
        {
            this.name = name;
            this.duty = duty;

        }

        public string Task
        {
            get { return task; }
            set { task = value; }
        }
        public void PrintEmployee()
        {
            Console.WriteLine("Сотруднику : " + name + " который отвечает за : " + duty + " назначили задачу : " + task );


        }
        public void TaskStatus(int num)
        {
            Console.WriteLine("Статус задачи : " + status[num]);
            

        }

        public void YesorNo()
        {

                if(task.Contains(duty))
                {
                Console.WriteLine("Задача назначена правильно, сотрудник выполняет работу");

                TaskStatus(1);
                count++;
                Thread.Sleep(4000);
                Console.WriteLine("Сотруник выполнил работу и отправил на проверку");
                ;

                }
                else
                {
                Console.WriteLine("Задача назначена неправильно");
                Console.WriteLine("Сотрудник " + name + " отказался от выполнения данной задачи");
                
                }
 
        }

    }
}
