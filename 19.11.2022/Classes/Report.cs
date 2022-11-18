using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._11._2022.Classes
{
    internal class Report
    {
        public string text;
        public DateTime time;
        public string name;


        public void Rep( DateTime deadline)
        {
            if(time > deadline)
            {
                Console.WriteLine("Задача сдана не вовремя");
            }
            else
            {
                Console.Write("Сотрудник " + name + " подготовил отчет по своей работе над задачей : " + '\n' + text);
                Console.WriteLine();
            }
        }
    }
}
