using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClassWork
{
    /*Предположим, что стоит такая задача: определено три класса. 
Первый класс будет считать до 100, используя цикл. 
Два других класса будут ждать, когда в первом классе счетчик досчитает, например, до 18, 
и после этого каждый выведет в консоль фразу «Пора действовать, ведь уже 18!». 
Проще говоря, при обнаружении значения 18, вызовутся по методу, соответственно
 для каждого класса.
*/
    class Program
    {
        static void Main(string[] args)
        {
            // создаём экземпляры(объекты)
            EventCount Counter = new EventCount();
            Handler_1 Handler1 = new Handler_1();
            Handler_2 Handler2 = new Handler_2();

            //подписка на события
            Counter.Count += Handler1.Mssage;
            Counter.Count += Handler2.Mssage;

            Counter.onCount();

            Console.ReadKey();
        }
    }
}
