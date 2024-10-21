//Михайлова Виктория. ИСП-232о. Лаб 3
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ветвление_на_свою_тему
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы хотите научиться танцевать и вам нужно выбрать студию танца.У вас есть три варианта:Ритм, Стиль, Юность");
            Console.WriteLine("Какую студию вы выберете?");
            string studia = Console.ReadLine();
            if (studia == "Ритм")
            {
                Console.WriteLine("Супер!");
                Console.WriteLine("В этой студии преподают народный и классический танец. Какой выберете?");
                string style = Console.ReadLine();
                if (style == "Народный танец")
                {
                    Console.WriteLine("Вы выбрали:Народный танец.Программа обучения:2 года");
                }
                else if (style == "Классический танец") 
                {
                    Console.WriteLine("Вы выбрали:Классический танец.Программа обучения:1,5 года");
                }
                else
                {
                    Console.WriteLine("Выберите другую студию");
                }


            }
            else if (studia == "Стиль")
            {
                Console.WriteLine("Великолепно!");
                Console.WriteLine("В этой студии преподают джаз и бальные танцы. Какое направление выберете?");
                string style= Console.ReadLine();
                if(style == "Джаз")
                {
                    Console.WriteLine("Вы выбрали:Джаз.Программа обучения: 1 год");
                }
                else if (style =="Бальные танцы")
                {
                    Console.WriteLine("Вы выбрали:Бальные танцы.Программа обучения: 3 года");
                }
                else
                {
                    Console.WriteLine("Выберете другую студию");
                }

            }
            else if (studia == "Юность")
            {
                Console.WriteLine("Отличный выбор!");
                Console.WriteLine("В этой студии преподают контемп и эстрадные танцы. Какое направление выберете?");
                string style = Console.ReadLine();
                if (style == "Контемп")
                {
                    Console.WriteLine("Вы выбрали:Контемп.Программа обучения: 6 месяцев");
                }
                else if (style == "Эстрадные танцы")
                {
                    Console.WriteLine("Вы выбрали:Эстрадные танцы.Программа обучения: 3 года");
                }
                else
                {
                    Console.WriteLine("Выберете другую студию");
                }
            }



        }
    }
}
