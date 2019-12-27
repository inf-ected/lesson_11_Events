using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySend
{
    class Money
    {
        private double count;
        private string type;

        public Money(double m,string name)
        {
            count = m; type = name;
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Count
        {
            get { return count; }
            set { count = value; }
        }


        public delegate void MoneyDelegate(Money m1);
    }
}
