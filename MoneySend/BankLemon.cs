using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySend
{
    class BankLemon
    {
        public static void Handler(string message)
        {
            Console.WriteLine($"Bank Lemon: {message}");
        }
    }
}
