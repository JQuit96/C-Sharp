using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net;
using System.Device.Location;

/*
Author: Julian D. Quitian
Date: 12/23/2015
*/

/// <summary>
/// Distance estimator between two coordinate points.
/// </summary>
namespace Distance_Between_Two_Cities
{
    /// <summary>
    /// Location object. GeoCoordinate could possibly be added to object class for improvement.
    /// </summary>
    class Location
    {
        string address, requestUri;

        WebRequest request;
        WebResponse response;
        XDocument xdoc;
        XElement result, locationElement, latitude, longitude;

        public Location(string address)
        {
            //Credit to Chris Johnson's code snippet on https://stackoverflow.com/questions/16274508/how-to-call-google-geocoding-service-from-c-sharp-code
            this.address = address;
            requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false", Uri.EscapeDataString(address));
            request = WebRequest.Create(requestUri);
            response = request.GetResponse();
            xdoc = XDocument.Load(response.GetResponseStream());
            result = xdoc.Element("GeocodeResponse").Element("result");
            locationElement = result.Element("geometry").Element("location");
            this.latitude = locationElement.Element("lat");
            this.longitude = locationElement.Element("lng");

        }
        public void setLocation(string address)
        {
            this.address = address;
            requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false", Uri.EscapeDataString(address));
            request = WebRequest.Create(requestUri);
            response = request.GetResponse();
            xdoc = XDocument.Load(response.GetResponseStream());
            result = xdoc.Element("GeocodeResponse").Element("result");
            locationElement = result.Element("geometry").Element("location");
            this.latitude = locationElement.Element("lat");
            this.longitude = locationElement.Element("lng");
        }
        public double getLatitude()
        {
            return Convert.ToDouble(this.latitude.Value);
        }
        public double getLongitutde()
        {
            return Convert.ToDouble(this.longitude.Value);
        }
        public string toString()
        {
            string str;
            str = this.address + " is located at latitude: " + this.latitude.Value + " and longitude: " + this.longitude.Value;
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string address1, address2;  //Addresses input by user
            Location loc1, loc2;        //Location objects where coordinates are first located
            GeoCoordinate geo1, geo2;   //GeoCoordinate objects where coordinates are passed by Location object
            double distance;            //Distance between two coordinates

            Console.WriteLine("Welcome! I will calculate the distance between two addresses for you!\n");
            Console.Write("Please enter first address: ");
            address1 = Console.ReadLine();
            Console.Write("Please enter second address: ");
            address2 = Console.ReadLine();
            Console.WriteLine();
            loc1 = new Location(address1);
            loc2 = new Location(address2);

            Console.WriteLine(loc1.toString());
            Console.WriteLine(loc2.toString());
            Console.WriteLine();

            geo1= new GeoCoordinate(loc1.getLatitude(), loc1.getLongitutde());
            geo2 = new GeoCoordinate(loc2.getLatitude(), loc2.getLongitutde());

            distance = geo1.GetDistanceTo(geo2);

            Console.WriteLine("The distance between " + address1 + " and " + address2 + " is {0} miles.", distance/ 1609.344);

        }
    }
}
