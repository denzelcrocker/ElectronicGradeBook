using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Electronic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mini_reset = true;
            bool reset = true;
            bool big_reset = true;
            string outt = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "out.txt");
            Trace.Listeners.Add(new TextWriterTraceListener(outt));
            Trace.AutoFlush = true;
            Trace.Indent();
            string choise;
            string[] students = { " Введите ФИО студента: ", "\n Введите год зачисления: ", "\n Выберите форму обучения: ", "\n Введите специальность: " };
            string[] StudentsData = new string[4];
            string[] grades = { " Введите ФИО студента: ", "\n Введите предмет: ", "\n Введите оценку: " };
            string[] GradeData = new string[4];

            while (big_reset == true)
            {
                Console.Clear();
                Console.WriteLine("ЭЛЕКТРОННЫЙ ЖУРНАЛ \n");
                Console.WriteLine("Выберите справочник, с которым вы будете работать:\n \n 1 - Студенты \n 2 - Журнал успеваемости \n 3 - Выйти из программы \n");

                switch (Console.ReadLine())
                {
                    case "1":
                        reset = true;

                        Console.Clear();
                        Console.WriteLine("Справочник: Студенты");
                        Console.WriteLine();
                        Console.WriteLine("Выберите действие: \n \n 1 - Добавить запись \n 2 - Просмотреть записи \n 3 - Поиск по справочнику \n");
                        Console.WriteLine("Enter --> Назад \n");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Clear();
                                while (reset == true)
                                {
                                    for (int i = 0; i < students.Length; i++)
                                    {
                                        Console.WriteLine(students[i]);
                                        StudentsData[i] = Console.ReadLine();
                                    }

                                    Base.PlusStudents(StudentsData);
                                    Base.PlusStudentsGrades(StudentsData);
                                    Debug.WriteLine("\n Запсись добавлена.\n");
                                    Trace.WriteLine("\n Запсись добавлена.\n");

                                    mini_reset = true;
                                    while (mini_reset == true)
                                    {
                                        Console.WriteLine("\n Хотите добавить еще одну запись? да/нет \n");
                                        choise = Console.ReadLine();
                                        Console.WriteLine();

                                        if (choise == "да")
                                        {
                                            reset = true;
                                            mini_reset = false;
                                            Console.Clear();
                                            Debug.WriteLine("\n Пользователь решил добавить еще одну запись.\n");
                                            Trace.WriteLine("\n Пользователь решил добавить еще одну запись.\n");
                                        }
                                        else if (choise == "нет")
                                        {
                                            reset = false;
                                            mini_reset = false;
                                            Debug.WriteLine("\n Пользователь решил не добавлять запись.\n");
                                            Trace.WriteLine("\n Пользователь решил не добавлять запись.\n");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n Вы ввели неверную команду!!! \n");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            reset = false;
                                            Debug.WriteLine("\n Пользователь ввел неверную команду.\n");
                                            Trace.WriteLine("\n Пользователь ввел неверную команду.\n");
                                        }
                                    }
                                }
                                break;
                            case "2":
                                try
                                {
                                    Console.Clear();
                                    reset = true;
                                    Console.WriteLine("\n Записи справочника Студенты \n");
                                    Base.ReadStudents();
                                    Debug.WriteLine("\n Пользователь открыл записи справочника Студенты.\n");
                                    Trace.WriteLine("\n Пользователь открыл записи справочника Студенты.\n");
                                    Console.WriteLine("\n 1 - выход в главное меню \n");

                                    while (reset == true)
                                    {
                                        choise = Console.ReadLine();
                                        if (choise == "1")
                                        {
                                            reset = false;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n Вы ввели неверную команду!!! \n");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Debug.WriteLine("\n Пользователь ввел неверную команду.\n");
                                            Trace.WriteLine("\n Пользователь ввел неверную команду.\n");
                                            Console.WriteLine("1 - выход в главное меню \n");
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n Ошибка!!! Нет записей!!! \n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                }
                                break;
                            case "3":
                                Base.SearchStudents();
                                Console.WriteLine("\n 1 - выход в главное меню \n");

                                while (reset == true)
                                {
                                    choise = Console.ReadLine();
                                    if (choise == "1")
                                    {
                                        reset = false;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n Вы ввели неверную команду!!! \n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Debug.WriteLine("\n Пользователь ввел неверную команду.\n");
                                        Trace.WriteLine("\n Пользователь ввел неверную команду.\n");
                                        Console.WriteLine("\n 1 - выход в главное меню \n");
                                    }
                                }
                                break;
                        }
                        break;
                    case "2":
                        reset = true;
                        Console.Clear();
                        Console.WriteLine("Справочник: Журнал успеваемости \n");
                        Console.WriteLine("Выберите действие: \n \n 1 - Добавить запись \n 2 - Просмтреть записи \n 3 - Поиск по справочнику \n");
                        Console.WriteLine("Enter --> Назад \n");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Clear();

                                while (reset == true)
                                {
                                    int a = 0;
                                    for (int i = 0; i < grades.Length; i++)
                                    {
                                        Console.WriteLine(grades[i]);
                                        GradeData[i] = Console.ReadLine();
                                        string stugra = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "studentsgrades.txt");

                                        StreamReader studentslist = new StreamReader(stugra);
                                        string line = studentslist.ReadLine();

                                        if (i == 0)
                                        {
                                            while (line != null)
                                            {
                                                string[] splitLine = line.Split(";");
                                                string search = splitLine[0];
                                                line = studentslist.ReadLine();
                                                if (GradeData[i].Contains(search))
                                                {
                                                    a = 1;
                                                }
                                                else
                                                {

                                                }
                                            }
                                        }
                                        else 
                                        {
                                            
                                        }
                                    }

                                    if (a == 1)
                                    {
                                        Base.PlusGrade(GradeData);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" \n Такого студента не существует \n ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    mini_reset = true;

                                    while (mini_reset == true)
                                    {
                                        Console.WriteLine("\n Хотите добавить еще одну запись? да/нет \n");
                                        choise = Console.ReadLine();
                                        Console.WriteLine();

                                        if (choise == "да")
                                        {
                                            reset = true;
                                            mini_reset = false;
                                            Debug.WriteLine("\n Пользователь решил добавить еще одну запись.\n");
                                            Trace.WriteLine("\n Пользователь решил добавить еще одну запись.\n");
                                            Console.Clear();

                                        }
                                        else if (choise == "нет")
                                        {
                                            reset = false;
                                            mini_reset = false;
                                            Debug.WriteLine("\n Пользователь решил не добавлять еще одну запись.\n");
                                            Trace.WriteLine("\n Пользователь решил не добавлять еще одну запись.\n");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n Вы ввели неверную команду!!! \n");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Debug.WriteLine("\n Пользователь ввел неверную команду.\n");
                                            Trace.WriteLine("\n Пользователь ввел неверную команду.\n");
                                            reset = false;
                                        }
                                    }
                                }
                                break;
                            case "2":
                                try
                                {
                                    reset = true;
                                    Console.Clear();
                                    Console.WriteLine("\n Записи справочника Журнал успеваемости \n");
                                    Debug.WriteLine("\n Пользователь открыл записи справочника Журнал успеваемости.\n");
                                    Trace.WriteLine("\n Пользователь открыл записи справочника Журнал успеваемости.\n");
                                    Base.ReadGrade();
                                    Console.WriteLine("\n 1 - выход в главное меню \n");

                                    while (reset == true)
                                    {
                                        choise = Console.ReadLine();

                                        if (choise == "1")
                                        {
                                            reset = false;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n Вы ввели неверную команду!!! \n");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Debug.WriteLine("\n Пользователь ввел неверную команду.\n");
                                            Trace.WriteLine("\n Пользователь ввел неверную команду.\n");
                                            Console.WriteLine("1 - выход в главное меню \n");
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n Ошибка!!! Нет записей!!! \n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ReadLine();
                                }
                                break;
                            case "3":
                                Base.SearchGrades();
                                Console.WriteLine("\n 1 - выход в главное меню \n");

                                while (reset == true)
                                {
                                    choise = Console.ReadLine();
                                    if (choise == "1")
                                    {
                                        reset = false;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n Вы ввели неверную команду!!! \n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Debug.WriteLine("\n Пользователь ввел неверную команду.\n");
                                        Trace.WriteLine("\n Пользователь ввел неверную команду.\n");
                                        Console.WriteLine("\n 1 - выход в главное меню \n");
                                    }
                                }
                                break;
                        }
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                }
            }
            Trace.Unindent();
            Trace.Flush();
            Console.ReadKey();
        }
    }
}