using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySend
{
    class BankLion
    {
        public static void Handler(string message)
        {
            Console.WriteLine($"Bank Lion: {message}");
        }
    }
}
