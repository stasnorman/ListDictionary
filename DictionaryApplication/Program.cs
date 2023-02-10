using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace DictionaryApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            #region LIST

            //List<string> name = new List<string>();

            //name.Add("Нaталья");
            //name.Add("Иван");
            //name.Add("Пётр");

            //name.Insert(1,"Анна");  // Наталья, Анна, Иван, Пётр
            //name.Remove("Нaталья"); // Анна, Иван, Пётр
            //name.RemoveAt(1);       // Анна, Пётр


            //foreach (string item in name)
            //{
            //    WriteLine(item);
            //}

            WriteLine();
            #endregion

            //Dictionary
            #region Dictionary

            Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
            
            countryCapitals.Add("Москва", "Россия");
            countryCapitals.Add("Минск", "Беларусь");
            countryCapitals.Add("Анкара", "Турция");
            countryCapitals.Add("Берн", "Швейцария");


            foreach (var item in countryCapitals.Values)
            {
                WriteLine($"Страна {item}");
            }
            WriteLine();

            foreach (var item in countryCapitals.Keys)
            {
                WriteLine($"Столица {item}");
            }
            WriteLine();

            foreach (var item in countryCapitals)
            {
                WriteLine($"Страна {item.Value}, столица {item.Key} ");
            }
            WriteLine();

            if (countryCapitals.ContainsKey("Москва2")) Console.WriteLine("Найден!");

          
            #endregion

            ReadKey();
        }

        public static void Data()
        {
            TestClass data = new TestClass("Я - строка");
        }
    }
}
