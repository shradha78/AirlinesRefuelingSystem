using GraphQL.Types;
using Team_Mars_Backend.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Mars_Backend.GraphQL
{
    public class VendorType : ObjectGraphType<VendorTable>
    {
        public VendorType()
        {
            Field(t => t.Vendor_Id);
            Field(t => t.Name);
            Field(t => t.email);
            Field(t => t.Phone_number);
            Field(t => t.Password);
        }
    }
}
