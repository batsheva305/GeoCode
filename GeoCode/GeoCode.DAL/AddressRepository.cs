using GeoCode.Interfaces;
using GeoCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeoCode.DAL
{
    public class AddressRepository : IAddressRepository
    {
        public Address GetAddressCoordinates(string address)
        {
            using var db = new AddressesDBContext();
            return db.Addreses.FirstOrDefault(a => a.AddressString.Equals(address));
        }

        public void AddAddress(Address address)
        {
            using var db = new AddressesDBContext();
            db.Addreses.Add(address);
            db.SaveChanges();
        }

        public void UpdateNumberOfHits(string address)
        {
            using var db = new AddressesDBContext();
            var addressToUpdate = db.Addreses.First(a => a.AddressString.Equals(address));
            addressToUpdate.NumberOfHits++;
            db.SaveChangesAsync();
        }

        public IEnumerable<Address> GetPopularSearch(int numberOfPopularSearches)
        {
            using var db = new AddressesDBContext();
            return db.Addreses.OrderByDescending(coordinate => coordinate.NumberOfHits).Take(numberOfPopularSearches).ToList();
        }

    }
}
