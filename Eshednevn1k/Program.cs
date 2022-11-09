using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshednevnik
{
    internal class Program
    {
        static DateTime date = DateTime.Now;
        static string data = date.ToShortDateString();
        static ConsoleKeyInfo clavisha = Console.ReadKey();
        static int position = 1;
        static void Main()
        {
            data = date.ToShortDateString();
            Strelki();
        }
        static void Strelki()
        {
            data = date.ToShortDateString();
            Console.WriteLine("Выбрана дата: " + data);
            Console.WriteLine("------------------------");
            position = 2;
            PereclDat();
            do
            {
                string del = new string(' ', 2);
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                    if (position == 0)
                        position = 1;
                }
                else if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                }
                Console.Write(del);
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                clavisha = Console.ReadKey();
                if (clavisha.Key == ConsoleKey.Escape)
                {
                    break;
                }
                if (clavisha.Key == ConsoleKey.LeftArrow)
                {
                    IzmData();
                }
                if (clavisha.Key == ConsoleKey.RightArrow)
                {
                    IzmData();
                }
            } while (clavisha.Key != ConsoleKey.Enter);
        }
        static void PereclDat()
        {
            if (data == "09.11.2022")
            {
                switch (position)
                {
                    case 2:
                        Zametka1();
                        if (clavisha.Key == ConsoleKey.Enter)
                        {
                            if (position == 2)
                                Opis1_1();
                            else if (position == 3)
                                Opis1_2();
                        }
                        break;
                }
            }

        }
        static void IzmData()
        {

            if (clavisha.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                date = date.AddDays(-1);
                string data = date.ToShortDateString();
                Main();
            }
            if (clavisha.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                date = date.AddDays(1);
                string data = date.ToShortDateString();
                Main();
            }
        }
        static void Zametka1()
        {
            List<string> zametka = new List<string>();
            zametka.Add("  1)Сделать проверочную по С#");
            zametka.Add("  2)Сходить в зал");
            foreach (string item in zametka)
                Console.WriteLine(item);
        }
        static void Opis1_1()
        {
            List<string> opisanie = new List<string>();
            opisanie.Add("Сделать проверочную по C#");
            opisanie.Add("--------------------------");
            opisanie.Add("Описание: Написать код для проверочной");
            opisanie.Add("Дата: 26.10.2022 17:00");
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
        static void Opis1_2()
        {
            Console.Clear();
            List<string> opisanie = new List<string>();
            opisanie.Add("Сходить в зал");
            opisanie.Add("--------------------------");
            opisanie.Add("Описание: Провести тренировку по программе");
            opisanie.Add("Дата: 26.10.2022 21:00");
            foreach (string item in opisanie)
                Console.WriteLine(item);
        }
    }
}