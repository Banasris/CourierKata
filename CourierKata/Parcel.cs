using System;

namespace CourierKata
{
    public class Parcel
    {
        public string Type { get; set; }
        public double Cost { get; set; }
        public double Weight { get; set; }
        public Parcel(string type, double cost, double weight)
        {
            Type = type;
            Cost = cost;
            Weight = weight;
        }

        public double CalculateSubTotal()
        {
            double cost = 0.0;
            double deliveryCost = 0.0;
            int weightLimit = 0;
            switch (Type)
            {
                case "Small":
                    deliveryCost = 3.00;
                    weightLimit = 1;
                    cost = CalculateCostPerWeight(deliveryCost, weightLimit);
                    break;
                case "Medium":
                    deliveryCost = 8.00;
                    weightLimit = 3;
                    cost = CalculateCostPerWeight(deliveryCost, weightLimit);
                    break;
                case "Large":
                    deliveryCost = 15.00;
                    weightLimit = 6;
                    cost = CalculateCostPerWeight(deliveryCost, weightLimit);
                    break;
                case "XL":
                    deliveryCost = 25.00;
                    weightLimit = 10;
                    cost = CalculateCostPerWeight(deliveryCost, weightLimit);
                    break;
                case "Heavy":
                    deliveryCost = 50.00;
                    weightLimit = 50;
                    cost = CalculateCostPerWeight(deliveryCost, weightLimit);
                    break;
                default:
                    throw new InvalidOperationException("unknown item type");
            }
            return cost;

        }

        private double CalculateCostPerWeight(double deliveryCost, int weightLimit)
        {
            double cost = 0.0;
            int i = 0;
            if (Weight == weightLimit)
                cost = deliveryCost;
            else
                for (cost = deliveryCost, i = weightLimit; i < Weight; i++)
                {
                    cost = cost + 2.00;
                }

            return cost;
        }

        public override string ToString()
        {
            return "Parcel Type: " + Type + "," + 
                " Individual delivery cost: " + Cost + "," +
                " Weight: " + Weight + "kg";
        }
    }
}
