using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySend
{
    delegate void BankMessageSender(string message);

    class BankMessageSenderHandler
    {
        public event BankMessageSender SomeEvent;
        public void OnSomeEvent(string massege)
        {
            SomeEvent?.Invoke(massege);
            Console.WriteLine("Return from BankMessageSenderHandler - переход в MAIN ");
        }
    }
}
