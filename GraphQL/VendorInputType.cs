using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace Team_Mars_Backend.GraphQL
{
    public class VendorInputType : InputObjectGraphType
    {
        public VendorInputType()
        {
            Name = "vendorInput";
            base.Field<NonNullGraphType<StringGraphType>>("Name");
            base.Field<NonNullGraphType<StringGraphType>>("email");
            base.Field<NonNullGraphType<StringGraphType>>("Password");
            base.Field<NonNullGraphType<LongGraphType>>("Phone_number");
        }
    }
}
