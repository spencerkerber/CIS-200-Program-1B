// Spencer Kerber
// CIS 200-10
// Program 1A
// Parcel program continued
// Due 5/31/15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class TwoDayAirPackage: AirPackage
    {
        public enum Delivery { Early, Saver };  // Holds delivery type

        // Preconditions: None
        // Postconditions: The two day air package is created with the specified values for
        //                 origin address, destination address, length, width, height, weight, and delivery type
        public TwoDayAirPackage(Address theOriginAddress, Address theDestinationAddress, double theLength,
            double theWidth, double theHeight, double theWeight, Delivery DeliveryType)
            : base(theOriginAddress, theDestinationAddress, theLength, theWidth, theHeight, theWeight) { }

        public Delivery DeliveryType
        {
            // Preconditions: None
            // Postconditions: Delivery type is returned 
            get;

            // Preconditions: None
            // Postconditions: Delivery type is set to the specified value
            set;
        }

        // Preconditions: None
        // Postconditions:  Cost is returned 
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .25;    // Dimension coefficient in cost equation
            const double WEIGHT_FACTOR = .25; // Weight coefficient in cost equation         

            double costd = (DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * Weight);
            if (DeliveryType == Delivery.Saver)
                costd = costd - 1.1;
            decimal cost = (decimal)costd;      // Final cost in decimal format        
            return cost;
        }

        // Preconditions: None
        // Postconditions: A string with the package's data has been returned 
        public override string ToString()
        {
            string result;      // String to hold results

            result = string.Format("Two Day Air Package{2}{0}{2}Delivery Type: {1}{2}",
                base.ToString(), DeliveryType, System.Environment.NewLine);

            return result;
        }
    }
}
