using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Events
{
    class BankLimon
    {

       

        public static void Handler(object sender, RemittanceEventArgs e)
        {
            Console.WriteLine($"Bank Lemon: recived money. currency {e.Currency}, Ammount: {e.MoneyAmount}");
        }
    }
}
