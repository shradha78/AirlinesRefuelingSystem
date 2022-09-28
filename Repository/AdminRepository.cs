using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Mars_Backend.Data;
using Team_Mars_Backend.Data_Admin;
using Team_Mars_Backend.Data_Admin.Entity_Admin;

namespace Team_Mars_Backend.Repository
{
    public class AdminRepository
    {
        public DatabaseContext _adminContext;
        public AdminRepository(DatabaseContext adminContext)
        {
            _adminContext = adminContext;
        }
        public IEnumerable<AdminTable> GetAdmins()
        {
            return _adminContext.adminDetails;
        }
        public AdminTable GetAdminWithPhoneNumber(long phoneNumber)
        {
            var adminFound = _adminContext.adminDetails.FirstOrDefault(s => s.Phone_number == phoneNumber);
            return adminFound;
        }
  
        public AdminTable GetAdminWithID(string id)
        {
            var adminFound = _adminContext.adminDetails.FirstOrDefault(s => s.Admin_Id == id);
            return adminFound;
        }
        public AdminTable updateAdminPassword(string password, long phoneNumber, string id)
        {
            var adminFound = _adminContext.adminDetails.First(a => a.Phone_number == phoneNumber || a.Admin_Id == id);
            adminFound.Password = password;
            this._adminContext.SaveChanges();
            return adminFound;
        }


    }


}

