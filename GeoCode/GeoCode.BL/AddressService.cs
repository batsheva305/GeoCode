using GeoCode.Interfaces;
using GeoCode.Models;
using Geocoding.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GoogleMaps.LocationServices;

namespace GeoCode.BL
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly GoogleGeocoder _googleGeocoder;
        private const string API_KEY = "AIzaSyBxvqGxEvb6ZBnyRTM8isBU_6O-MAfuNiQ";

        public AddressService(IAddressRepository coordinateRepository)
        {
            _addressRepository = coordinateRepository;
            _googleGeocoder = new GoogleGeocoder() { ApiKey = API_KEY };
        }

        public Address GetAddressCoordinates(string address)
        {
            var result = _addressRepository.GetAddressCoordinates(address);
            if (result == null)
            {
                result = GetAddressFromGoogleGeocoder(address);
                _addressRepository.AddAddress(result);
            }

            _addressRepository.UpdateNumberOfHits(address);
            return result;
        }

        public IEnumerable<Address> GetPopularSearch(int numberOfPopularSearches)
        {
            return _addressRepository.GetPopularSearch(numberOfPopularSearches);
        }

       
        private  Address GetAddressFromGoogleGeocoder(string address)
        {
            /*var addresses = await _googleGeocoder.GeocodeAsync(address);
            var foundAddress = addresses.First();
            return new Address { AddressString = address, Latitude = foundAddress.Coordinates.Latitude, Longitude = foundAddress.Coordinates.Longitude };
            */

            /*string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(address), API_KEY);

            var request = WebRequest.Create(requestUri);
            var response =  request.GetResponse();
            var xdoc = XDocument.Load(response.GetResponseStream());

            var result = xdoc.Element("GeocodeResponse").Element("result");
            var locationElement = result.Element("geometry").Element("location");
            var lat = double.Parse(locationElement.Element("lat").Value);
            var lng = double.Parse(locationElement.Element("lng").Value);
            return new Address { AddressString = address, Latitude = lat, Longitude = lng };*/

            /*var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);
            var latitude = point.Latitude;
            var longitude = point.Longitude;
            return new Address { AddressString = address, Latitude = latitude, Longitude = longitude };*/

            return new Address { Id = Guid.NewGuid().ToString(), AddressString = address, Latitude = 45.898888, Longitude = 36.484741 };
        }
    }
}
