using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace Team_Mars_Backend.GraphQL
{
    public class VendorPatchType : InputObjectGraphType
    {
        public VendorPatchType()
        {
            Name = "vendorPatch";
            base.Field<NonNullGraphType<StringGraphType>>("Password");
            base.Field<NonNullGraphType<LongGraphType>>("Phone_number");
            base.Field<NonNullGraphType<IntGraphType>>("Vendor_Id");
        }
    }
}
