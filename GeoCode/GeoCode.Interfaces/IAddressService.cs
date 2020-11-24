using GeoCode.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeoCode.Interfaces
{
    public interface IAddressService
    {
        Address GetAddressCoordinates(string address);
        IEnumerable<Address> GetPopularSearch(int numberOfPopularSearches);
    }
}
