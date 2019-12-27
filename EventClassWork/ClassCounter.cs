using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClassWork
{
    class EventCount
    {
        //создаем делегат или шаблон делегат
        public delegate void MethodContainer();
        //создаём событие с этим типом делегата
        public event MethodContainer Count;
        //создаем метод запускающий события
        public void onCount()
        {
            for(int i = 0; i < 100; i++)
            {
                // задержка
                // System.Threading.Thread.Sleep(500);
                if (i == 18)
                    Count?.Invoke();
            }
            Console.WriteLine("end!");
        }


    }
}
