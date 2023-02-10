using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    public class TestClass
    {
        private string Text { get; set; }
        public TestClass(string text)
        {
            Text = text;
        }

        public void ViewMessage()
        {
            if (Text != null) Console.WriteLine("Есть строка");
        }
        

        ~TestClass()
        {
            Console.WriteLine($"Очистили память: {Text}");
        }
    }
}
