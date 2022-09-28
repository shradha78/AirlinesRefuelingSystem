
using Team_Mars_Backend.Repository;
using GraphQL;
using GraphQL.Types;
using Team_Mars_Backend.GraphQL_Admin;
using Team_Mars_Backend.GraphQL_Fuel;

namespace Team_Mars_Backend.GraphQL
{
    public class Query :ObjectGraphType
    {
        public Query(VendorRepository Vend_repo,AdminRepository admin_repo,FuelRepository fuel_repo,OrderRepository order_repo)
        {
            Field<ListGraphType<VendorType>>(
                "vendorQuery",
                resolve: context => Vend_repo.GetVendors());
            Field<VendorType>(
                "AllVendorquery", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "Phone_number" }),
                resolve: context =>
                {
                    var name = context.GetArgument<long>("Phone_number");
                    return Vend_repo.GetVendorWithPhoneNumber(name);
                });

            Field<VendorType>(
                "Vendorquerybyphonenumber", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "Phone_number" }),
                resolve: context =>
                {
                    var name = context.GetArgument<long>("Phone_number");
                    return Vend_repo.GetVendorId(name);
                });

            Field<VendorType>(
                "VendorquerybyId", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "Vendor_Id" }),
                resolve: context =>
                {
                    var name = context.GetArgument<int>("Vendor_Id");
                    return Vend_repo.GetVendorWithID(name);
                });
            Field<ListGraphType<AdminType>>(
                "adminQuery",
                resolve: context => admin_repo.GetAdmins()
                );

            Field<ListGraphType<FuelType>>(
                "allFuelQuery",
                resolve: context => fuel_repo.GetAllFuel()
                );

            Field<FuelType>(
                "FuelDetailsById", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "Fuel_Id" }),
                resolve: context =>
                {
                    var name = context.GetArgument<string>("Fuel_Id");
                    return fuel_repo.GetFuelWithID(name);
                });

            Field<FloatGraphType>(
                "FuelPriceQuery", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "Fuel_Id" }),
                resolve: context =>
                {
                    var name = context.GetArgument<string>("Fuel_Id");
                    return fuel_repo.GetFuelPrice(name);
                });



            Field<ListGraphType<OrderType>>(
               "AllOrdersQuery",
               resolve: context => order_repo.GetAllOrders()
               );

            Field<ListGraphType<OrderType>>(
                "OrdersQueryWithFuel", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "Fuel_Id" }),
                resolve: context =>
                {
                    var name = context.GetArgument<string>("Fuel_Id");
                    return order_repo.GetAllOrdersWithFuelId(name);
                });
            Field<ListGraphType<OrderType>>(
                "OrdersQueryWithVendor", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "Vendor_Id" }),
                resolve: context =>
                {
                    var name = context.GetArgument<int>("Vendor_Id");
                    return order_repo.GetAllOrdersWithVendorId(name);
                });



        }
    }

}
