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
    public abstract class AirPackage: Package
    {
        // Preconditions: None
        // Postconditions: The air package is created with the specified values for
        //                 origin address, destination address, length, width, height, and weight
        public AirPackage(Address theOriginAddress, Address theDestinationAddress, double theLength,
            double theWidth, double theHeight, double theWeight)
            : base(theOriginAddress,theDestinationAddress,theLength,theWidth,theHeight,theWeight) { }

        // Preconditions: None
        // Postconditions: Returns heavy status
        public Boolean IsHeavy()
        {
            if (Weight >= 75)
                return true;
            else return false;
        }

        // Preconditions: None
        // Postconditions: Returns large status
        public Boolean IsLarge()
        {
            if ((Length + Width + Height) >= 100)
                return true;
            else return false;
        }

        // Preconditions: None
        // Postconditions:  A string with the package's data has been returned 
        public override string ToString()
        {
            string result;      // String to hold results

            result = string.Format(base.ToString());

            if (IsHeavy())
                result += string.Format("{1}Is Heavy: {0}{1}", IsHeavy(), System.Environment.NewLine);

            if (IsLarge())
                result += string.Format("{1}Is Large: {0}{1}", IsLarge(), System.Environment.NewLine);

            return result;
        }
    }
}
