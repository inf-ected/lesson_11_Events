using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChange
{
    /*Создадим класс Product, реагирующий на изменение цены и генерирующий событие.
Создадим класс аргументов события*/
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs(decimal lastPrice,decimal newPrice)
        {
            LastPrice = lastPrice; NewPrice = newPrice;
        }
    }
    public class Product
    {
        string name;
        decimal price;
        public Product(string name) => this.name = name;
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        protected void OnPriceChanged(PriceChangedEventArgs e)
        {
            // if (PriceChanged != null) PriceChanged(this, e);
            PriceChanged?.Invoke(this, e);

        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));

            }
        }
    }


    class Program
    {
        static void product_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            Console.WriteLine($"old Price {e.LastPrice}");
            if (e.LastPrice > 0 && (e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
            {
                Console.WriteLine("Alert, 10% product price increase!");
            }
            else Console.WriteLine("price changed! new price {0}", e.NewPrice);
        }
        static void testProductEvent()
        {
            Product prod1 = new Product("BMV");
            // Зарегистрировать с событием PriceChanged
            prod1.Price = 25000M;
            prod1.PriceChanged += product_PriceChanged;
            prod1.Price = 45000M;
            prod1.Price = 21000M;
            //Console.ReadLine();
        }

        static void Main(string[] args)
        {
            testProductEvent();
            Console.ReadKey();
        }
    }
}
