using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace Team_Mars_Backend.GraphQL_Admin
{
    public class FuelPatchType : InputObjectGraphType
    {
        public FuelPatchType()
        {
            Name = "fuelPatch";
           
           
            base.Field<NonNullGraphType<StringGraphType>>("Fuel_Id");
            base.Field<NonNullGraphType<StringGraphType>>("Fuel_Name");
            base.Field<NonNullGraphType<FloatGraphType>>("Fuel_price");
            base.Field<NonNullGraphType<IntGraphType>>("Fuel_quantity");
            base.Field<NonNullGraphType<StringGraphType>>("Fuel_Type");

        }

    }
}
