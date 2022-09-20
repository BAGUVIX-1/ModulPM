using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulPM
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!"); //Вывод в консоль Hello world
            /// Плюс
            /// баллы
            /// =)
        }
    }
    class PlusBally // Создание класса Плюс Баллы
    {
        public void SayBally()
        {
            //Это метод
            Console.WriteLine(17+29); 
            ///Вывод сообщения плюс баллы, ну почти
            ///А это вызов метода
            SayBally();
        }
        
    }

}