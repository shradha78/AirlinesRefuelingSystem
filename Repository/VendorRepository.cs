using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Mars_Backend.Data;
using Team_Mars_Backend.Data.Entity;

namespace Team_Mars_Backend.Repository
{
    public class VendorRepository
    {
        public DatabaseContext _vendorContext;
        public VendorRepository(DatabaseContext vendorContext)
        {
            _vendorContext = vendorContext;
        }
        public IEnumerable<VendorTable> GetVendors()
        {
            return _vendorContext.vendorDetails;
        }
        public VendorTable GetVendorWithPhoneNumber(long phoneNumber)
        {
            var vendorFound = _vendorContext.vendorDetails.FirstOrDefault(s => s.Phone_number == phoneNumber);
            return vendorFound;
        }
        public VendorTable GetVendorId(long phoneNumber)
        {
                var vendorFound = _vendorContext.vendorDetails.FirstOrDefault(s => s.Phone_number == phoneNumber);
                return vendorFound;
        }
        public VendorTable CreateVendor(VendorTable vendor)
        {       if (!(_vendorContext.vendorDetails.Any(v => v.Phone_number == vendor.Phone_number)))
            {
                this._vendorContext.vendorDetails.Add(vendor);
                this._vendorContext.SaveChanges();
                return vendor;
            }
            else
            {
                return null;
            }
                

        }

        public VendorTable GetVendorWithID(int id)
        {
            var vendorFound = _vendorContext.vendorDetails.FirstOrDefault(s => s.Vendor_Id == id);
            return vendorFound;
        }
        public VendorTable updateVendorPassword(string password,long phoneNumber,int id)
        {   var vendorFound = _vendorContext.vendorDetails.First(v => v.Phone_number == phoneNumber || v.Vendor_Id == id);
            vendorFound.Password = password;
            this._vendorContext.SaveChanges();
            return vendorFound;
        }


    }


}
