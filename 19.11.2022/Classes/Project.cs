using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._11._2022.Classes
{
    internal class Project
    {

        private string description;
        private DateTime deadline;
        private string customer;
        private string teamlead;
        private string[] status = new string[3] { "Проект", "Исполнение", "Закрыт" };
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public string Teamlead
        {
            get { return teamlead; }
            set { teamlead = value; }
        }


        public void Status(int num)
        {
            Console.WriteLine("Статус проекта : " + status[num]);
        }



    }
}
