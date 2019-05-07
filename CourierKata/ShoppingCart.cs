using System.Collections.Generic;

namespace CourierKata
{
    public class ShoppingCart
    {
        public List<Parcel> ParcelItems { get; set; }

        public double TotalCost(bool speedyDelivery = false)
        {
            double price = 0;

            foreach (var item in ParcelItems)
            {
                price += item.CalculateSubTotal();
            }
            if (speedyDelivery)
            {
                return price * 2;
            }
            return price;
        }

    }
}
