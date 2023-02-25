using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Electronic
{
    internal class Base
    {
        public static void ReadStudents()
        {
            string stu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "studetns.txt");

            StreamReader students = new StreamReader(stu);

            string line = students.ReadLine();
            string[] start = { "ФИО студента", "Год зачисления", "Форма обучения", "Специальность" };
            string table = start[0];
            int i = 0;

            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"----------------",15}----|-{$"---------------",15}-|");
            Console.WriteLine($"|{$"{"№"}",2} | {$"{start[0]}",35}     | {$"{start[1]}",15}     | {$"{start[2]}",15}     | {$"{start[3]}",15} |");
            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"----------------",15}----|-{$"---------------",15}-|");
           
            while (line != null)
            {
                i++;
                string[] splitLine = line.Split(";");
                string fio = splitLine[0];

                Console.WriteLine($"|{$"{i}", 2} | {$"{splitLine[0]}", 35}     | {$"{splitLine[1]}",15}     | {$"{splitLine[2]}",15}     | {$"{splitLine[3]}",15} |" );
                Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"----------------",15}----|-{$"---------------",15}-|");

                line = students.ReadLine();
            }
            students.Close();
        }

        public static void PlusStudents(string[] DataPlus)
        {
            string stu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "studetns.txt");

            StreamWriter students = new StreamWriter(stu, append: true);

            string line = $"{DataPlus[0]};{DataPlus[1]};{DataPlus[2]};{DataPlus[3]}";

            students.WriteLine(line);
            students.Close();
        }

        public static void SearchStudents()
        {
            Console.Clear();
            string stu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "studetns.txt");

            StreamReader students = new StreamReader(stu);

            string line = students.ReadLine();
            int i = 0;
            int a = 0;

            Console.WriteLine("Выберите столбец, по которому вы хотите совершить поиск по справочнику: \n \n 0 - ФИО студента \n 1 - Год зачисления \n 2 - Форма обучения \n 3 - Специальность \n");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите слово для поиска по справочнику: \n");
            string word = Console.ReadLine();
            Console.WriteLine();
            
            Console.Clear();
            Console.WriteLine($"Результаты поиска: \n");
            string[] start = { "ФИО студента", "Год зачисления", "Форма обучения", "Специальность" };
            string table = start[0];

            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"----------------",15}----|-{$"---------------",15}-|");
            Console.WriteLine($"|{$"{"№"}",2} | {$"{start[0]}",35}     | {$"{start[1]}",15}     | {$"{start[2]}",15}     | {$"{start[3]}",15} |");
            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"----------------",15}----|-{$"---------------",15}-|");

            while (line == word || line != null)
            {
                a++;
                string[] splitLine = line.Split(";");
                string search = splitLine[b];
                line = students.ReadLine();

                if (word.Contains(search))
                {
                    Console.WriteLine($"|{$"{a}",2} | {$"{splitLine[0]}",35}     | {$"{splitLine[1]}",15}     | {$"{splitLine[2]}",15}     | {$"{splitLine[3]}",15} |");
                    Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"----------------",15}----|-{$"---------------",15}-|");
                    i = 1;
                }
                else
                {

                }
            }
            if (i == 1)
            {

            }
            else
            {
                Console.WriteLine(" \n Записи с таким содержимым нет \n");
            }
            students.Close();
        }
        public static void ReadGrade()
        {
            string gra = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "grades.txt");

            StreamReader grades = new StreamReader(gra);

            string line = grades.ReadLine();
            string[] start = { "ФИО студента", "Предмет", "Оценка" };
            string table = start[0];
            int i = 0;

            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"---------------",15}-|");
            Console.WriteLine($"|{$"{"№"}",2} | {$"{start[0]}",35}     | {$"{start[1]}",15}     | {$"{start[2]}",15} |");
            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"---------------",15}-|");

            while (line != null)
            {
                i++;
                string[] splitLine = line.Split(";");
                string fio = splitLine[0];

                Console.WriteLine($"|{$"{i}",2} | {$"{splitLine[0]}",35}     | {$"{splitLine[1]}",15}     | {$"{splitLine[2]}",15} |");
                Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"---------------",15}-|");
                line = grades.ReadLine();
            }
            grades.Close();
        }
        public static void PlusGrade(string[] DataPlus)
        {
            string gra = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "grades.txt");

            StreamWriter grades = new StreamWriter(gra, append: true);

            string line = $"{DataPlus[0]};{DataPlus[1]};{DataPlus[2]}";
            grades.WriteLine(line);
            grades.Close();
        }
        public static void SearchGrades()
        {
            Console.Clear();
            string gra = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "grades.txt");
            StreamReader grades = new StreamReader(gra);

            string line = grades.ReadLine();
            Console.WriteLine("Выберите столбец, по которому вы хотите совершить поиск по справочнику: \n \n 0 - ФИО студента \n 1 - Предмет \n 2 - Оценка \n ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите слово для поиска по справочнику: ");
            string word = Console.ReadLine();
            int i = 0;
            int a = 0;
            Console.Clear();
            Console.WriteLine($"Результаты поиска: \n");
            string[] start = { "ФИО студента", "Предмет", "Оценка" };
            string table = start[0];

            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"---------------",15}-|");
            Console.WriteLine($"|{$"{"№"}",2} | {$"{start[0]}",35}     | {$"{start[1]}",15}     | {$"{start[2]}",15} |");
            Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"---------------",15}-|");

            while (line == word || line != null)
            {
                a++;
                string[] splitLine = line.Split(";");
                string search = splitLine[b];
                line = grades.ReadLine();
                if (word.Contains(search))
                {
                    Console.WriteLine($"|{$"{a}",2} | {$"{splitLine[0]}",35}     | {$"{splitLine[1]}",15}     | {$"{splitLine[2]}",15} |");
                    Console.WriteLine($"|{$"{"--"}",2}-|-{$"{"------------------------------------"}",35}----|-{$"----------------",15}----|-{$"---------------",15}-|");
                    i = 1;
                }
                else
                {

                }
            }
            if (i == 1)
            {

            }
            else
            {
                Console.WriteLine("Записи с таким словом нет");
            }
            grades.Close();
        }
        public static void PlusStudentsGrades(string[] DataPlus)
        {
            string stugra = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "studentsgrades.txt");

            StreamWriter studentsgrades = new StreamWriter(stugra, append: true);
            string line = $"{DataPlus[0]};{DataPlus[1]};{DataPlus[2]};{DataPlus[3]}";

            studentsgrades.WriteLine(line);
            studentsgrades.Close();
        }
    }
}
