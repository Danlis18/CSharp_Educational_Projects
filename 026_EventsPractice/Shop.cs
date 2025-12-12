using System;
namespace _026_EventsPractice
{
    class Shop
    {
        public string ShopName { get; set; }

        public void OnBuy(object sender, BuyEventArgs e)
        {
            if (e.Age >= 18)
            {
                Console.WriteLine("Sale completed.");
            }
            else
            {
                Console.WriteLine("Sale denied. Buyer is underage.");
            }

        }
    }
}
