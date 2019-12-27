using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Events
{
    /*
     Задача. Обработка событий, делегаты.
+ 1. Создать класс Money;
+ 2. Создать 2 класса: BankLimon, BankLion.
+ 3. В программе дожно быть событие перевода (каждому индивидуальное)
   банкам денег (Remittance). Банки должны выводить
   на консоль сообщение о получении денег.
+ 4. Для передачи параметров использовать класс наследник EventArgs

+ В данном проекте создается класс RemittanceEventArgs
производный от класса EventArgs. 

+ В классе RemittanceEventArgs добавляются поля: Currency,
MoneyAmount.

+ Затем объявляется делегат RemittanceEventHandler, ,
принимающий два параметра, требующиеся для среды .NET Framework. 
Первый параметр содержит ссылку на объект, формирующий событие,
а второй параметр – ссылку на объект класса EventArgs 
или производного от него класса (RemittanceEventArgs). 

Обработчики событий Handler, определяемые в классах 
BankLimon и BankLion, принимают параметры тех же самых типов.

В классе MoneyRemittance объявляется событие RemittanceEvent
типа RemittanceEventHandler. Это событие запускается в 
методе OnRemittanceEvent() с  помощью делегата RemittanceEventHandler, 
которому в качестве первого аргумента передается ссылка this, 
а вторым аргументом служит экземпляр объекта типа RemittanceEventArgs. 
Таким образом, делегату типа RemittanceEventHandler передаются 
надлежащие аргументы в соответствии с требованиями совместимости 
со средой .NET.


         */

    public delegate void RemittanceEventHandler(object sender, RemittanceEventArgs e);


    class Program
    {
        static void Main(string[] args)
        {
            // Создем объект с Событием
            MoneyRemittance objectWithEvent = new MoneyRemittance();
            // описываем список вызовов на эвент
            objectWithEvent.RemittanceEvent += BankLimon.Handler;
            objectWithEvent.RemittanceEvent += BankLion.Handler;
            // вызываем событие
            objectWithEvent.onRemittanceEvent(new RemittanceEventArgs("USD", 1000.99));


            // пример с лямбдой
            RemittanceEventHandler x = (obj, e) => Console.WriteLine(
                "Внимание отсылается Сумма {0}, Валюта {1}",
                e.MoneyAmount,
                e.Currency);
            x+= BankLimon.Handler; 
            x+= BankLion.Handler;
            // вызов
            x.Invoke(new object(),new RemittanceEventArgs("EUR",555.44));

            Console.ReadKey();
        }
    }


    //class ExamEventArgs : EventArgs
    //{
    //    public string Task { get; set; }
    //}
    //class Teacher
    //{
    //    public EventHandler<ExamEventArgs> examEvent;
    //    public void Exam(ExamEventArgs task)
    //    {
    //        if (examEvent != null)
    //        {
    //            examEvent(this, task);
    //        }
    //    }
    //}



}
