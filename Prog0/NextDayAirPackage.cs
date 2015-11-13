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
    public class NextDayAirPackage: AirPackage
    {
        // Preconditions: None
        // Postconditions: The next day air package is created with the specified values for
        //                 origin address, destination address, length, width, height, weight, and express fee
        public NextDayAirPackage(Address theOriginAddress, Address theDestinationAddress, double theLength,
          double theWidth, double theHeight, double theWeight, double ExpressFee=1)
            : base(theOriginAddress, theDestinationAddress, theLength, theWidth, theHeight, theWeight) { }

        public double ExpressFee
        {
            // Preconditions: None
            // Postconditions: Express fee is returned 
            get
            {
                return 1;
            }
        }

        // Preconditions: None
        // Postconditions: Cost is returned 
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .40;    // Dimension coefficient in cost equation
            const double WEIGHT_FACTOR = .3;  // Weight coefficient in cost equation
            double weightCharge = .25 * Weight;                 // Weight Charge
            double sizeCharge = .25*(Length + Width + Height);  // Size Charge
            
            double costd = (DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * Weight + ExpressFee);
            if (IsHeavy())
                costd = costd + weightCharge;
            if (IsLarge())
                costd = costd + sizeCharge;
            
            decimal cost = (decimal)costd;
            return cost;
        }

        // Preconditions: None
        // Postconditions: A string with the package's data has been returned 
        public override string ToString()
        {
            string result;      // String to hold results

            result = string.Format("Next Day Air Package{2}{0}{2}Express Fee: {1}{2}",
                base.ToString(), ExpressFee, System.Environment.NewLine);

            return result;
        }
    }
}
