using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using Team_Mars_Backend.Data_Admin.Entity_Admin;


namespace Team_Mars_Backend.GraphQL_Fuel
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType()
        {
            Field(t => t.Order_id);
            Field(t => t.Fuel_Id);
            Field(t => t.Vendor_Id);
            Field(t => t.Fuel_quantity);
            

        }
    }
}
