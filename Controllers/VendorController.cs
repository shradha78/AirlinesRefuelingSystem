using Microsoft.AspNetCore.Mvc;
using Team_Mars_Backend.Data;
using Team_Mars_Backend.Data.Entity;
using Team_Mars_Backend.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Mars_Backend.Controller
{
    [Route("vendors/[controller]")]
    [ApiController]

    public class VendorController : ControllerBase
    {
        public VendorRepository _repo;

        public VendorController(VendorRepository _repo)
        {
            this._repo = _repo;
        }

        [HttpGet]
        public IEnumerable<VendorTable> Get()
        {
            return _repo.GetVendors();
        }

        [HttpGet("{phonenumber}")]
        public VendorTable GetWithPhoneNumber(long phonenumber)
        {
            return _repo.GetVendorWithPhoneNumber(phonenumber);
        }

        [HttpGet ("{vendor_Id}")]
        public VendorTable GetWithId(int id)
        {
            return _repo.GetVendorWithID(id);
        }

        [HttpPost]
        public VendorTable Post(VendorTable vendor)
        {
            return _repo.CreateVendor(vendor);
        }

        [HttpPatch("{password},{Phone_number},{Vendor_Id}")]
        public VendorTable Patch(string password, long phoneNumber, int id)
        {
            return _repo.updateVendorPassword(password,  phoneNumber,  id);
        }



    }
}
