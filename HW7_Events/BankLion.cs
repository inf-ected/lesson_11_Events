using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Events
{
    class BankLion
    {
        public static void Handler(object sender, RemittanceEventArgs e)
        {
            Console.WriteLine($"Bank Lion: recived money. currency {e.Currency}, Ammount: {e.MoneyAmount}");
        }
    }
}
