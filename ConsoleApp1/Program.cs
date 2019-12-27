using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class KeyEventArgs : EventArgs
    {   //будем  запоимнать и передавать нажатую клавишу(символ)
        public char ch;
    }
    // Объявить класс события, связанного с нажатием клавиш на клавиатуре.
    class KeyEvent
    {   // используем готовый шаблон делегата
        public event EventHandler<KeyEventArgs> KeyPress;
        // Этот метод вызывается при нажатии клавиши.
        public void OnKeyPress(char key)
        {
            KeyEventArgs k = new KeyEventArgs();
            if (KeyPress != null)
            {
                k.ch = key;
                KeyPress(this, k);
            }
        }
    }

    class Program
    {
        
        static void testEventKey()
        {
            KeyEvent kevt = new KeyEvent();
            ConsoleKeyInfo key;
            int count = 0;
            // Использовать лямбда-выражение для отображения факта нажатия клавиши.
            kevt.KeyPress += (sender, e) => Console.WriteLine(
                                       " Получено сообщение о нажатии клавиши: " + e.ch);
            // Использовать лямбда-выражение для подсчета нажатых клавиш.
            kevt.KeyPress += (sender, е) => count++; // count — это внешняя переменная

            Console.WriteLine("Введите несколько символов. По завершении введите точку.");
            do
            {
                key = Console.ReadKey();
                kevt.OnKeyPress(key.KeyChar);
            } while (key.KeyChar != '.');
            Console.WriteLine("Было нажато " + count + " клавиш.");
        }

        static void Main(string[] args)
        {
            testEventKey();
            Console.ReadKey();
        }
    }
}
