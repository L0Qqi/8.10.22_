using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _8._10._22
{
    internal class Program
    {
        static void Task2(int[] first_team, int[] second_team)
        {
            int cnt1 = 0;
            int cnt2 = 0;
            for (int i = 0; i < first_team.Length; i++)
            {
                if ((int)first_team[i] == 5)
                {
                    cnt1++;
                }
            }
            for (int j = 0; j < second_team.Length; j++)
            {
                if (second_team[j] == 5)
                {
                    cnt2++;
                }
            }
            if (cnt1 == cnt2)
            {
                Console.WriteLine("Drinks All Round!Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }
        }
        struct citizen
        {
            public string name;
            public int pasport;
            public int number_problem;
            public string problem;
            public int scandal;
            public int mind;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Студенты");
            string[] stud1 = { "Salimov", "Radmir", "2004", "Math", "71" };
            string[] stud2 = { "Zarechniy", "Maxim", "2004", "Math", "90" };
            string[] stud3 = { "Poletaev", "Nikita", "2004", "Russian", "78" };
            string[] stud4 = { "Arsentev", "Kirill", "2004", "Russian", "54" };
            string[] stud5 = { "Zigansin", "Halil", "2004", "Informatics", "74" };
            string[] stud6 = { "Pervushin", "Artem", "2004", "Math", "92" };
            string[] stud7 = { "Valiyarova", "Alina", "2004", "English", "97" };
            string[] stud8 = { "Voronko", "Diana", "2005", "Russian", "68" };
            string[] stud9 = { "Spak", "Vitaliy", "2004", "Informatics", "85" };
            string[] stud10 = { "Yakupova", "Aliya", "2004", "English", "88" };
            var student = new Dictionary<int, string[]>();
            {

            };
            student.Add(1, stud1);
            student.Add(2, stud2);
            student.Add(3, stud3);
            student.Add(4, stud4);
            student.Add(5, stud5);
            student.Add(6, stud6);
            student.Add(7, stud7);
            student.Add(8, stud8);
            student.Add(9, stud9);
            student.Add(10, stud10);

            Console.WriteLine($"Меню:" + '\n' + "Введите номер действия, которое хотите совершить:" + '\n' + "1 - Новый студент " + '\n' + "2 - Удалить" + '\n' + "3 - Сортировать");
            string operation = Console.ReadLine();
            if (operation == "1")
            {
                Console.WriteLine("Введите данные: Фамилию, Имя, Год рождения, Предмет, Количество баллов");
                string[] newstud = new string[5];
                for (int i = 0; i < newstud.Length; i++)
                {
                    newstud[i] = Console.ReadLine();
                }
                student.Add(11, newstud);
                foreach (var peoples in student)
                {
                    Console.WriteLine($"{peoples.Value[0]} {peoples.Value[1]} {peoples.Value[2]} {peoples.Value[3]} {peoples.Value[4]}");
                }
            }
            else if (operation == "2")
            {
                Console.WriteLine("Введите имя студента: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите фамилию студента: ");
                string surname = Console.ReadLine();

                for (int i = 1; i <= student.Count; i++)
                {
                    if (student[i][0] == surname && student[i][1] == name)
                    {
                        student.Remove(i);
                    }
                }
                foreach (var peoples in student)
                {
                    Console.WriteLine($"{peoples.Value[0]} {peoples.Value[1]} {peoples.Value[2]} {peoples.Value[3]} {peoples.Value[4]}");
                }
            }
            else if (operation == "3")
            {
                string[] sort;
                for (int i = 1; i <= student.Count; i++)
                {
                    for (int j = i + 1; j <= student.Count; j++)
                    {
                        if (Convert.ToInt32(student[i][4]) > Convert.ToInt32(student[j][4]))
                        {
                            sort = student[i];
                            student[i] = student[j];
                            student[j] = sort;
                        }
                    }
                }
                foreach (var peoples in student)
                {
                    Console.WriteLine($"{peoples.Value[0]} {peoples.Value[1]} {peoples.Value[2]} {peoples.Value[3]} {peoples.Value[4]}");
                }
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 2. Викинги и пиво");
            int[] first_team = new int[] { 1, 5, 6, 5, 5, 7, 8 };
            int[] second_team = new int[] { 1, 5, 6, 5, 5, 6, 9 };
            Task2(first_team, second_team);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 3. ЖЭК");
            Console.WriteLine("Окно 1 - оплата" + '\n' + "Окно 2 - подключение" + '\n' + " Окно 3 - отопление");
            Console.WriteLine("Заполните форму клиента");
            citizen Client = new citizen();
            Console.WriteLine("Введите имя");
            Client.name = Console.ReadLine();
            Console.WriteLine("Введите номер паспорта");
            Client.pasport = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер проблемы от 1 до 3");
            Client.number_problem = int.Parse(Console.ReadLine());
            Console.WriteLine("Опишите проблему");
            Client.problem = Console.ReadLine();
            Console.WriteLine("Введите уровень скандальности. 10 - скандальный урод, 0 - паинька");
            Client.scandal = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень развития. 1 - умный, 0 - отсталый");
            Client.mind = int.Parse(Console.ReadLine());

            var massiv = Client.problem.Split();

            foreach (var word1 in massiv)
            {
                if (word1 == "оплата" || word1 == "Оплата" || word1 == "ОПЛАТА")
                {
                    Console.WriteLine("Вам в 1 окно");
                    break;
                }
                else if (word1 == "подключение" || word1 == "Подключение" || word1 == "ПОДКЛЮЧЕНИЕ")
                {
                    Console.WriteLine("Вам во 2 окно");
                    break;
                }
                else if (word1 == "отопление" || word1 == "Отопление" || word1 == "ОТОПЛЕНИЕ")
                {
                    Console.WriteLine("Вам в 3 окно");
                    break;
                }

            }

            if (Client.scandal >= 5)
            {
                Console.WriteLine("Сколько человек из очереди длиной 15 обгонит скандалист?");
                int peoplecount = int.Parse(Console.ReadLine());
                if (peoplecount > 10 || peoplecount < 0)
                {
                    Console.WriteLine("Указано неверное количество людей в очереди");
                }
                else
                {

                    if (Client.mind == 0)
                    {
                        Random random = new Random();
                        int room;
                        room = random.Next(1, 3);
                        Console.WriteLine(Client.name + " обогнал " + peoplecount + " человек , поэтому теперь он " + (15 - peoplecount) + " в очереди " + '\n' +
                     " ,но " + Client.name + " тупой " + " и вместо нужного окна встал в " + room + " окно");
                    }

                    else
                    {
                        Console.WriteLine(Client.name + " обогнал " + peoplecount + " человек , поэтому теперь он " + (15 - peoplecount) + " в очереди " + '\n');
                    }
                }
            }
            else
            {
                if (Client.mind == 0)
                {
                    Random random = new Random();
                    int room;
                    room = random.Next(1, 3);
                    Console.WriteLine(Client.name + " - паинька , но тупой , поэтому вместо своего окна встал в " + room + " окно");
                }
                else
                {
                    Console.WriteLine(Client.name + "не тупой, поэтому встал в " + Client.number_problem + " окно");
                }
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 4. Обход графа");
            Random rand = new Random();
            Queue<int> q = new Queue<int>();    //Это очередь, хранящая номера вершин
            string exit = "";
            int u;
            u = rand.Next(3, 5);
            bool[] used = new bool[u + 1];  //массив отмечающий посещённые вершины
            int[][] g = new int[u + 1][];   //массив содержащий записи смежных вершин

            for (int i = 0; i < u + 1; i++)
            {
                g[i] = new int[u + 1];
                Console.Write("\n({0}) вершина -->[", i + 1);
                for (int j = 0; j < u + 1; j++)
                {
                    g[i][j] = rand.Next(0, 2);
                }
                g[i][i] = 0;
                foreach (var item in g[i])
                {
                    Console.Write(" {0}", item);
                }
                Console.Write("]\n");
            }
            used[u] = true;     //массив, хранящий состояние вершины(посещали мы её или нет)

            q.Enqueue(u);
            Console.WriteLine("Начинаем обход с {0} вершины", u + 1);
            while (q.Count != 0)
            {
                u = q.Peek();
                q.Dequeue();
                Console.WriteLine("Перешли к узлу {0}", u + 1);

                for (int i = 0; i < g.Length; i++)
                {
                    if (Convert.ToBoolean(g[u][i]))
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            q.Enqueue(i);
                            Console.WriteLine("Добавили в очередь узел {0}", i + 1);
                        }
                    }
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
