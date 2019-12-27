using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySend
{/*Задание 1.
Написать программу, в которой пересылаются деньги  различным (минимум трем) банкам
(класс Money: количество денег, тип валюты).  Создавать классы типа Bank не надо.
При успешной пересылке денег выдать соответствующее сообщение.
Деньги различным банкам и в различной валюте пересылать одним и тем же
методом Send(Money,"bank", delegate), в качестве 3-го параметра использовать делегат.

Задание 2.
Создать  класс Bank. Создать 3 банка.
Пересылать всем банкам уведомление о курсе доллара. Использовать Delegate и Event.

Задание 2.
Создать  класс Bank. Создать 3 банка.
Пересылать каждому банку уведомление о пересылке одной из 2-х валют. 
Использовать Delegate и Event.

/* Задача. Обработка событий делегаты.
 * 1. Создать класс BankMessageSender, содержащий событие, посылающее
 * банкам сообщение о курсе доллара. Класс содержит соответствующий делегат.
 * 2. Создать 3 класса - различные банки.
 * 3. В Main() подписать банки на получение события.
 * 4. Запустиь событие. На мониторе должны увидеть строки, в которых банки
 * сообщают полученный курс валют.
 * 
 * */
       
    class Program
    {
        static void Main(string[] args)
        {
            //Money m = new Money(456, "lei");
            //MoneyOperations oper = new MoneyOperations();

            //Money.MoneyDelegate del = new Money.MoneyDelegate(oper.Lei_Usd);
            //oper.Send(m, "Victoria Bank", del);
            ////****************

            //m = new Money(100, "usd");
            //del = new Money.MoneyDelegate(oper.Usd_Lei);
            //oper.Send(m, "EximBank", del);

            ////***********************
            //m = new Money(52345, "lei");
            //del = new Money.MoneyDelegate(oper.NotConvert);
            //oper.Send(m, "FinComBank", del);
            //****************************************************///

            BankMessageSenderHandler objectWithEvent = new BankMessageSenderHandler();

            objectWithEvent.SomeEvent += BankVictor.Handler;
            objectWithEvent.SomeEvent += BankLion.Handler;
            objectWithEvent.SomeEvent += BankLemon.Handler;

            objectWithEvent.OnSomeEvent("Vot vam kurs dollara - 12.00");
            objectWithEvent.SomeEvent -= BankLion.Handler;
            objectWithEvent.OnSomeEvent("Vot vam kurs dollara - 17.55");


            Console.ReadKey();




        }
    }
}
