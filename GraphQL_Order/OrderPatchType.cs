using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace Team_Mars_Backend.GraphQL_Admin
{
    public class OrderPatchType : InputObjectGraphType
    {
        public OrderPatchType()
        {
            Name = "orderPatch";
            
            base.Field<NonNullGraphType<StringGraphType>>("Fuel_Id");
            base.Field<NonNullGraphType<IntGraphType>>("Vendor_Id");
            base.Field<NonNullGraphType<IntGraphType>>("Fuel_quantity");
            

        }

    }
}
