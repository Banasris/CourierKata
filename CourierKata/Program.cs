using System;
using System.Collections.Generic;

namespace CourierKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Parcel p1 = new Parcel("Small", 3.00, 1);
            Parcel p2 = new Parcel("Heavy", 50.00, 50);
          
            ShoppingCart cart = new ShoppingCart();
            cart.ParcelItems = new List<Parcel>();
            var speedyDelivery = false;
            cart.ParcelItems.Add(p1);
            cart.ParcelItems.Add(p2);
            
            cart.TotalCost(speedyDelivery);
           
            foreach (var item in cart.ParcelItems)
            {
                Console.WriteLine(item);
            }
            if (speedyDelivery)
            {
                Console.WriteLine($"Total cost of the parcel including speedy delivery is: {cart.TotalCost(speedyDelivery)}");
            }
            else
            {
                Console.WriteLine($"Total cost of the parcel is: {cart.TotalCost()}");
            }

        }
    }
}
