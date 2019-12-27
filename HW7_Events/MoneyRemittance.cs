using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_Events
{
    class MoneyRemittance
    {
        //* слово event при обобщеной форме не обязательно
        public EventHandler<RemittanceEventArgs> RemittanceEvent;
               
        public void onRemittanceEvent(RemittanceEventArgs e)
        {
            RemittanceEvent?.Invoke(this,e);
        }
        
    }
}
