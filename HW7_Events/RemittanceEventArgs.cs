using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Events
{
    public class RemittanceEventArgs: EventArgs
    {

        public readonly string Currency;
        public readonly double MoneyAmount;
        public RemittanceEventArgs(string curr, double ammount)
        {
            Currency=curr; MoneyAmount = ammount;
        }


    }
}
