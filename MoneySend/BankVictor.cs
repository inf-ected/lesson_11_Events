using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySend
{
    class BankVictor
    {
        public static void Handler(string message) => Console.WriteLine($"Bank Victor: {message}");
    }
}
