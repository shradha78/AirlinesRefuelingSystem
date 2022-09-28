using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team_Mars_Backend.Data_Admin.Entity_Admin;
using Team_Mars_Backend.Repository;

namespace Team_Mars_Backend.Controllers
{
    [Route("admin/[controller]")]
    [ApiController]
    public class AdminController: ControllerBase
    {
        public AdminRepository _repo;

        public AdminController(AdminRepository _repo)
        {
            this._repo = _repo;
        }

        [HttpGet]
        public IEnumerable<AdminTable> Get()
        {
            return _repo.GetAdmins();
        }

        [HttpGet("{phone_number}")]
        public AdminTable GetWithPhoneNumber(long phonenumber)
        {
            return _repo.GetAdminWithPhoneNumber(phonenumber);
        }

        [HttpGet("{Admin_Id}")]
        public AdminTable GetWithId(string id)
        {
            return _repo.GetAdminWithID(id);
        }


        [HttpPatch("{password},{Phone_number},{Vendor_Id}")]
        public AdminTable Patch(string password, long phoneNumber, string id)
        {
            return _repo.updateAdminPassword(password, phoneNumber, id);
        }

    }
}
