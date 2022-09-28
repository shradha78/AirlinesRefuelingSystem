using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using Team_Mars_Backend.Data_Admin.Entity_Admin;

namespace Team_Mars_Backend.GraphQL_Admin
{
    public class AdminType: ObjectGraphType<AdminTable>
    {
        public AdminType()
        {
            Field(t => t.Admin_Id);
            Field(t => t.email);
            Field(t => t.Company_Name);
            Field(t => t.Phone_number);
            Field(t => t.Password);
        }
    }
}
