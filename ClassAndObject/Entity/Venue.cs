using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Entity
{
    public class Venue
    {
        private string venueName;
        public string VenueName
        {
            get { return venueName; }
            set { venueName = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Venue(string venueName, string address)
        {
            VenueName = venueName;
            Address = address;
        }

        public void DisplayVenueDetails()
        {
            Console.WriteLine($"Venue Name: {VenueName}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}
