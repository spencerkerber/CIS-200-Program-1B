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
    public abstract class Package: Parcel
    {
        private double _length;     // Length
	    private double _width;      // Width      
	    private double _height;     // Height
	    private double _weight;     // Weight

        // Preconditions: None
        // Postconditions: The package is created with the specified values for origin address, destination address, 
        //                 length, width, height, and weight
        public Package(Address theOriginAddress, Address theDestinationAddress, 
            double theLength, double theWidth, double theHeight, double theWeight)
            : base(theOriginAddress, theDestinationAddress)
        {
            Length = theLength;
            Width = theWidth;
            Height = theHeight;
            Weight = theWeight;
        }

	    public double Length
	    {
            // Preconditions: None 
            // Postconditions: Length is returned 
		    get
		    {
			    return _length;
		    }
            // Preconditions: None 
            // Postconditions: Length is set to the designated value
		    set
		    {
                if (value > 0)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException("Length: ", Length, " Length must be greater than 0");
		    }
	    }

	    public double Width
	    {
            // Preconditions: None 
            // Postconditions: Width is returned 
		    get
		    {
			    return _width;
		    }
            // Preconditions: None 
            // Postconditions: Width is set to the designated value
		    set
		    {
			    if(value > 0)
				    _width=value;
                else
                    throw new ArgumentOutOfRangeException("Width: ", Width, " Width must be greater than 0");
		    }
	    }

	    public double Height
	    {
            // Preconditions: None 
            // Postconditions: Height is returned 
		    get
		    {
             return _height;
		    }
            // Preconditions: None 
            // Postconditions: Height is set to the designated value
		    set
		    {
			    if(value> 0)
				    _height=value;
                else
                    throw new ArgumentOutOfRangeException("Height: ", Height, " Height must be greater than 0");
		    }
	    }
	    public double Weight
	    {
            // Preconditions: None 
            // Postconditions: Weight is returned 
		    get
		    {
			    return _weight;
		    }
            // Preconditions: None 
            // Postconditions: Weight is set to the designated value
		    set
		    {
			    if(value > 0)
				    _weight=value;
                else
                    throw new ArgumentOutOfRangeException("Weight: ", Weight, " Weight must be greater than 0");
		    }
	    }

        // Preconditions: None
        // Postconditions: A string with the package's data has been returned 
	    public override string ToString()
	    {
		    string result;      // String to hold results
	
		    result = string.Format("Origin Address: {6}{0}{6}{6}Destination Address: {6}{1}{6}{6}"+
             "Length: {2}{6}Width: {3}{6}Height: {4}{6}Weight: {5}{6}",
			    OriginAddress, DestinationAddress, Length, Width, Height, Weight,
			    System.Environment.NewLine);
	
		    return result;
	    }
    
    }
}
