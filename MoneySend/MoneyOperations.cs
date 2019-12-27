using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySend
{
    class MoneyOperations
    {
        public void Lei_Usd(Money m1)
        {
            m1.Type = "usd"; m1.Count /= 10;
        }
        public void Usd_Lei(Money m1)
        {
            m1.Type="lei";
            m1.Count*=10;
        }
        public void NotConvert(Money m1) { }
        public void Send(Money m1, string bank, Money.MoneyDelegate proc)
        {
            if (proc.Target != null)
            {
                proc(m1);
            }
            Console.WriteLine(m1.Count + " " + m1.Type + " успешно переведены в " + bank);
        }

    }
}
