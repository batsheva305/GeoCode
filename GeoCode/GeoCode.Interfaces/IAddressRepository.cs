using GeoCode.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoCode.Interfaces
{
    public interface IAddressRepository
    {
        Address GetAddressCoordinates(string address);
        void AddAddress(Address address);
        void UpdateNumberOfHits(string address);
        IEnumerable<Address> GetPopularSearch(int numberOfPopularSearches);
    }
}
