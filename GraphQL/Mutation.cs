using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Mars_Backend.Data.Entity;
using Team_Mars_Backend.GraphQL;
using Team_Mars_Backend.Repository;
using GraphQL;
using GraphQL.Types;
using Team_Mars_Backend.Data_Admin.Entity_Admin;
using Team_Mars_Backend.GraphQL_Admin;
using Team_Mars_Backend.GraphQL_Fuel;

namespace Team_Mars_Backend.GraphQL
{
    public class Mutation : ObjectGraphType
    {
        public Mutation(VendorRepository vendorRepository, AdminRepository adminRepository,FuelRepository fuelRepository, OrderRepository orderRepository)
        {
            Field<VendorType>(
             "createVendor",
             arguments: new QueryArguments(new QueryArgument<NonNullGraphType<VendorInputType>> { Name = "name" }),
                resolve: context =>
                {
                    var vendor = context.GetArgument<VendorTable>("name");
                    return vendorRepository.CreateVendor(vendor);
                }
             );
            Field<VendorType>(
               "updateVendorPassword",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<VendorPatchType>> { Name = "Vendor_Id" }),
                  resolve: context =>
                  {
                      var vendor = context.GetArgument<VendorTable>("Vendor_Id");
                      return vendorRepository.updateVendorPassword(vendor.Password,vendor.Phone_number,vendor.Vendor_Id);
                  }
               );

            Field<AdminType>(
              "updateAdminPassword",
              arguments: new QueryArguments(new QueryArgument<NonNullGraphType<AdminPatchType>> { Name = "Admin_Id" }),
                 resolve: context =>
                 {
                     var admin = context.GetArgument<AdminTable>("Vendor_Id");
                     return adminRepository.updateAdminPassword(admin.Password, admin.Phone_number, admin.Admin_Id);
                 }
              );

            Field<FuelType>(
             "updateFuelQuantity",
             arguments: new QueryArguments(new QueryArgument<NonNullGraphType<FuelPatchType>> { Name = "Fuel_Id" }),
                resolve: context =>
                {
                    var fuel = context.GetArgument<FuelTable>("Fuel_Id");
                    return fuelRepository.updateFuelQuantity(fuel.Fuel_Id, fuel.Fuel_quantity);
                }
             );

            Field<OrderType>(
             "updateFuelQuantityInOrder",
             arguments: new QueryArguments(new QueryArgument<NonNullGraphType<OrderPatchType>> { Name = "Vendor_Id" }),
                resolve: context =>
                {
                    var order = context.GetArgument<Order>("Vendor_Id");
                    return orderRepository.updateVendorFuelQuantity(order.Vendor_Id, order.Fuel_Id,order.Fuel_quantity);
                }
             );


        }
    }
}
