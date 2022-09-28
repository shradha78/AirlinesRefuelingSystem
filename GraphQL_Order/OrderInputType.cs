using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace Team_Mars_Backend.GraphQL_Order
{
    public class OrderInputType :InputObjectGraphType
    {
        public OrderInputType()
        {
            Name = "orderInput";
            base.Field<NonNullGraphType<IntGraphType>>("Order_id");
            base.Field<NonNullGraphType<StringGraphType>>("Fuel_Id");
            base.Field<NonNullGraphType<IntGraphType>>("Vendor_Id");
            base.Field<NonNullGraphType<IntGraphType>>("Quantity");
        }
    }
}
