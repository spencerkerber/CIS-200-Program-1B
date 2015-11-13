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
    public class GroundPackage: Package
    {
        // Preconditions: None
        // Postconditions: The package is created with the specified values for origin address, destination address, 
        //                 length, width, height, and weight
        public GroundPackage(Address theOriginAddress, Address theDestinationAddress, double theLength, double theWidth,
            double theHeight, double theWeight)
            : base(theOriginAddress,theDestinationAddress,theLength,theWidth,theHeight,theWeight) { }

        public int ZoneDistance
        {
            // Precondition:  None
            // Postcondition: The ground package's zone distance is returned.           
            get
            {
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
                int dist;                             // Calculated zone distance

                dist = Math.Abs((OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR));

                return dist;
            }
        }

        // Preconditions: None
        // Postconditions: Cost is returned 
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .20;    // Dimension coefficient in cost equation
            const double WEIGHT_FACTOR = .5;  // Weight coefficient in cost equation

            double costd= (DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * (ZoneDistance + 1) * Weight);
            decimal cost = (decimal)costd;
            return cost;
        }

        // Preconditions: None
        // Postconditions: A string with the package's data has been returned 
        public override string ToString()
        {
            string result;      // String to hold results

            result = string.Format("Ground Package{7}Origin Address: {7}{0}{7}{7}Destination Address: {7}{1}{7}{7}" +
             "Length: {2}{7}Width: {3}{7}Height: {4}{7}Weight: {5}{7}Cost: {6:C}{7}",
                OriginAddress, DestinationAddress, Length, Width, Height, Weight, CalcCost(),
                System.Environment.NewLine);

            return result;
        }
    }
}
