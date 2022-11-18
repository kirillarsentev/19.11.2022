using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _19._11._2022.Classes;

namespace _19._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IT компании был задан проект - создать сайт");
            Console.WriteLine("В компании много сотрудников, но работает из них только 10 человек: " + '\n' + "Бигеев Айрат" + '\n' + "Ибрагимов Тимур" + '\n' + "Арсентьев Кирилл" + '\n' + "Ильназ" + '\n' + "Ильдар" + '\n' + "Марат" + '\n' + "Илья" + '\n' + "Данил" + '\n' + "Ягон Дон");
            Console.WriteLine("Кратко опишите проект ");
            string description = Console.ReadLine();
            Console.WriteLine("Введите дедлайн");
            DateTime deadline = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите имя заказчика");
            string customer = Console.ReadLine();
            Console.WriteLine("Вы являетесь ответсвенным за выполнение проекта.Введите ваше имя");
            string teamlead = Console.ReadLine();
            Project project = new Project();
            project.Description = description;
            project.Deadline = deadline;
            project.Customer = customer;
            project.Teamlead = teamlead;

            int num_status = 0;

            project.Status(num_status);

            Tasks task1 = new Tasks();
            task1.Techtask(1);
            Tasks task2 = new Tasks();
            task2.Techtask(2);
            Tasks task3 = new Tasks();
            task3.Techtask(3);
            Tasks task4 = new Tasks();
            task4.Techtask(4);
            Tasks task5 = new Tasks();
            task5.Techtask(5);
            Tasks task6 = new Tasks();
            task6.Techtask(6);
            Tasks task7 = new Tasks();
            task7.Techtask(7);
            Tasks task8 = new Tasks();
            task8.Techtask(8);
            Tasks task9 = new Tasks();
            task9.Techtask(9);
            Tasks task10 = new Tasks();
            task10.Techtask(10);

            Console.WriteLine("Все задачи по проекту назначены.");
            project.Status(num_status+=1);
            int taskcount = 0;


            Employee employee1 = new Employee(task1.executor, "определение целей");
            employee1.Task = task1.description;
            employee1.TaskStatus(0);
            employee1.PrintEmployee();
            employee1.YesorNo();
            if (employee1.count == 1)
            {
              employee1.TaskStatus(2);
                DateTime time = new DateTime(2022, 11, 20);
                Report report1 = new Report();
                report1.time = time;
                report1.name = task1.executor;
                report1.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report1.Rep(task1.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer = Console.ReadLine();
                if (answer == "да" || answer == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee1.TaskStatus(3);
                    taskcount++;    
                }
                else if(answer == "нет" || answer == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {
 
                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }









            Employee employee2 = new Employee(task2.executor, "зарегестрировать домен");
            employee2.Task = task2.description;
            employee2.TaskStatus(0);
            employee2.PrintEmployee();
            employee2.YesorNo();
            if (employee2.count == 1)
            {
                employee2.TaskStatus(2);
                DateTime time2 = new DateTime(2022, 11, 20);
                Report report2 = new Report();
                report2.time = time2;
                report2.name = task2.executor;
                report2.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report2.Rep(task2.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer2 = Console.ReadLine();
                if (answer2 == "да" || answer2 == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee2.TaskStatus(3);
                    taskcount++;
                }
                else if (answer2 == "нет" || answer2 == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }



            Employee employee3 = new Employee(task3.executor, "оформить хостинг");
            employee3.Task = task3.description;
            employee3.TaskStatus(0);
            employee3.PrintEmployee();
            employee3.YesorNo();
            if (employee3.count == 1)
            {
                employee3.TaskStatus(2);
                DateTime time3 = new DateTime(2022, 11, 20);
                Report report3 = new Report();
                report3.time = time3;
                report3.name = task1.executor;
                report3.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report3.Rep(task3.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer3 = Console.ReadLine();
                if (answer3 == "да" || answer3 == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee3.TaskStatus(3);
                    taskcount++;
                }
                else if (answer3 == "нет" || answer3 == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }




            Employee employee4 = new Employee(task4.executor, "купить сертификат");
            employee4.Task = task4.description;
            employee4.TaskStatus(0);
            employee4.PrintEmployee();
            employee4.YesorNo();
            if (employee4.count == 1)
            {
                employee4.TaskStatus(2);
                DateTime time4 = new DateTime(2022, 11, 20);
                Report report1 = new Report();
                report1.time = time4;
                report1.name = task4.executor;
                report1.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report1.Rep(task4.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer4 = Console.ReadLine();
                if (answer4 == "да" || answer4 == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee4.TaskStatus(3);
                    taskcount++;
                }
                else if (answer4 == "нет" || answer4 == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }





            Employee employee5 = new Employee(task5.executor, "продумать прототип");
            employee5.Task = task5.description;
            employee5.TaskStatus(0);
            employee5.PrintEmployee();
            employee5.YesorNo();
            if (employee5.count == 1)
            {
                employee5.TaskStatus(2);
                DateTime time5 = new DateTime(2022, 11, 20);
                Report report5 = new Report();
                report5.time = time5;
                report5.name = task5.executor;
                report5.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report5.Rep(task5.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer5 = Console.ReadLine();
                if (answer5 == "да" || answer5 == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee5.TaskStatus(3);
                    taskcount++;
                }
                else if (answer5 == "нет" || answer5 == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }




            Employee employee6 = new Employee(task6.executor, "продумать структуру сайта");
            employee6.Task = task6.description;
            employee6.TaskStatus(0);
            employee6.PrintEmployee();
            employee6.YesorNo();
            if (employee6.count == 1)
            {
                employee6.TaskStatus(2);
                DateTime time6 = new DateTime(2022, 11, 20);
                Report report6 = new Report();
                report6.time = time6;
                report6.name = task6.executor;
                report6.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report6.Rep(task6.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer6 = Console.ReadLine();
                if (answer6 == "да" || answer6 == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee1.TaskStatus(3);
                    taskcount++;
                }
                else if (answer6 == "нет" || answer6 == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }




            Employee employee7 = new Employee(task7.executor, "оформить дизайн");
            employee7.Task = task7.description;
            employee7.TaskStatus(0);
            employee7.PrintEmployee();
            employee7.YesorNo();
            if (employee7.count == 1)
            {
                employee7.TaskStatus(2);
                DateTime time7 = new DateTime(2022, 11, 20);
                Report report7 = new Report();
                report7.time = time7;
                report7.name = task1.executor;
                report7.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report7.Rep(task7.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer7 = Console.ReadLine();
                if (answer7 == "да" || answer7 == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee7.TaskStatus(3);
                    taskcount++;
                }
                else if (answer7 == "нет" || answer7 == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }



            Employee employee8 = new Employee(task8.executor, "наполненить контентом");
            employee8.Task = task8.description;
            employee8.TaskStatus(0);
            employee8.PrintEmployee();
            employee8.YesorNo();
            if (employee8.count == 1)
            {
                employee8.TaskStatus(2);
                DateTime time8 = new DateTime(2022, 11, 20);
                Report report8 = new Report();
                report8.time = time8;
                report8.name = task8.executor;
                report8.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report8.Rep(task8.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer8 = Console.ReadLine();
                if (answer8 == "да" || answer8 == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee1.TaskStatus(3);
                    taskcount++;
                }
                else if (answer8 == "нет" || answer8 == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }


            Employee employee9 = new Employee(task9.executor, "поиск рекламодателей");
            employee9.Task = task9.description;
            employee9.TaskStatus(0);
            employee9.PrintEmployee();
            employee9.YesorNo();
            if (employee9.count == 1)
            {
                employee9.TaskStatus(2);
                DateTime time9 = new DateTime(2022, 11, 20);
                Report report9 = new Report();
                report9.time = time9;
                report9.name = task9.executor;
                report9.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report9.Rep(task9.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer9 = Console.ReadLine();
                if (answer9 == "да" || answer9 == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee9.TaskStatus(3);
                    taskcount++;
                }
                else if (answer9 == "нет" || answer9 == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }


            Employee employee10 = new Employee(task10.executor, "размещение рекламы");
            employee10.Task = task10.description;
            employee10.TaskStatus(0);
            employee10.PrintEmployee();
            employee10.YesorNo();
            if (employee10.count == 1)
            {
                employee10.TaskStatus(2);
                DateTime time10 = new DateTime(2022, 11, 20);
                Report report10 = new Report();
                report10.time = time10;
                report10.name = task1.executor;
                report10.text = "уцжлолмоцшуотмтцульмлуцтмщзотцущомтмошцутмжмщурмторуцтмщгтмцщуктмшдтмдшцрмр";
                report10.Rep(task10.deadline);
                Thread.Sleep(2000);
                Console.WriteLine("Можно ли считать работу выполненой? да/нет");
                string answer10 = Console.ReadLine();
                if (answer10 == "да" || answer10 == "ДА")
                {
                    Console.WriteLine("Работа прошла проверку");
                    employee10.TaskStatus(3);
                    taskcount++;
                }
                else if (answer10 == "нет" || answer10 == "НЕТ")
                {
                    Console.WriteLine("Работа не прошла проверку");
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Задача не выполнена");
            }



            if(taskcount == 10)
            {
                Console.WriteLine("Все задачи по проекту выполнены");

                project.Status(num_status++);
            }
            else
            {
                Console.WriteLine("Не все задачи по проекту выполнены, поэтому проект нельзя считать закрытым");
            }






































            //Employee employee2 = new Employee(task2.executor, " регистрациz домена");
            //employee2.Task = task2.description;
            //employee2.PrintEmployee();
            //employee2.YesorNo();
            //if (employee2.count == 1)
            //{
            //    employee2.TaskStatus(2);
            //}
            //else
            //{
            //    Console.WriteLine("Задача не выполнена");
            //}

            //Employee employee3 = new Employee(task3.executor, "оформление хостинга");
            //employee3.Task = task3.description;
            //employee3.PrintEmployee();
            //employee3.YesorNo();
            //if (employee3.count == 1)
            //{
            //    employee3.TaskStatus(2);
            //}
            //else
            //{
            //    Console.WriteLine("Задача не выполнена");
            //}


        }
    }
}
