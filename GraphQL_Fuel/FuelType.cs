using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using Team_Mars_Backend.Data_Admin.Entity_Admin;


namespace Team_Mars_Backend.GraphQL_Fuel
{
    public class FuelType : ObjectGraphType<FuelTable>
    {
        public FuelType()
        {
            Field(t => t.Fuel_Id);
            Field(t => t.Fuel_Name);
            Field(t => t.Fuel_price);
            Field(t => t.Fuel_quantity);
            Field(t => t.Fuel_Type);

        }
    }
}
