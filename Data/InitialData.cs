
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Team_Mars_Backend.Data.Entity;
using Team_Mars_Backend.Data_Admin.Entity_Admin;

namespace Team_Mars_Backend.Data
{
    public static class InitialData
    {
        public static void Seed(this DatabaseContext dbcontext)
        {
            if (!dbcontext.vendorDetails.Any())
            {
                dbcontext.vendorDetails.Add(new VendorTable
                {
                    Phone_number = 1111111111,
                    Name = "Indigo",
                    email = "Indigo@gmail.com",
                    Password = "12345678"
 

                });

                dbcontext.vendorDetails.Add(new VendorTable
                {
                    Phone_number = 222222222,
                    Name = "KingFisher",
                    email = "kingfisher@kf.ac.in",
                    Password = "12345678"
                });
                dbcontext.SaveChanges();
            }
            if (!dbcontext.adminDetails.Any())
            {
                dbcontext.adminDetails.Add(new AdminTable
                {
                    Admin_Id = "ARS2",
                    Phone_number = 9876543321,
                    email = "brian@abc.com",
                    Company_Name = "ABC",
                    Password = "ABC.123",


                });

                dbcontext.adminDetails.Add(new AdminTable
                {
                    Admin_Id = "ARS3",
                    Phone_number = 4785384711,
                    email = "bob@abc.com",
                    Company_Name = "ABC",
                    Password = "DEF.123"
                });
            }
            if (!dbcontext.adminDetails.Any())
            { 
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "K1",
                    Fuel_Name = "Jet-A",
                    Fuel_price = 4684,
                    Fuel_quantity= 10000,
                    Fuel_Type="Kerosene"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "K2",
                    Fuel_Name = "Jet-A1",
                    Fuel_price = 8723,
                    Fuel_quantity = 48600,
                    Fuel_Type = "Kerosene"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "K3",
                    Fuel_Name = "Jet-B",
                    Fuel_price = 9273,
                    Fuel_quantity = 60000,
                    Fuel_Type = "Kerosene"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "M1",
                    Fuel_Name = "JP-1",
                    Fuel_price = 3762,
                    Fuel_quantity = 50000,
                    Fuel_Type = "Miltary"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "M2",
                    Fuel_Name = "JP-2 and JP-3",
                    Fuel_price = 1676,
                    Fuel_quantity = 40000,
                    Fuel_Type = "Miltary"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "M3",
                    Fuel_Name = "JP-4",
                    Fuel_price = 2368,
                    Fuel_quantity = 90000,
                    Fuel_Type = "Miltary"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "M4",
                    Fuel_Name = "JP-5",
                    Fuel_price = 1484,
                    Fuel_quantity = 41000,
                    Fuel_Type = "Miltary"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "M5",
                    Fuel_Name = "JP-6",
                    Fuel_price = 1677,
                    Fuel_quantity = 56000,
                    Fuel_Type = "Miltary"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "M6",
                    Fuel_Name = "JP-7",
                    Fuel_price = 1393,
                    Fuel_quantity = 47000,
                    Fuel_Type = "Miltary"
                });
                
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "A1",
                    Fuel_Name = "AVGAS 82UL",
                    Fuel_price = 1657,
                    Fuel_quantity = 65000,
                    Fuel_Type = "AvGas"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "A2",
                    Fuel_Name = "AVGAS 100",
                    Fuel_price = 2167,
                    Fuel_quantity = 35000,
                    Fuel_Type = "AvGas"
                });
                dbcontext.fuelDetails.Add(new FuelTable
                {
                    Fuel_Id = "A3",
                    Fuel_Name = "AVGAS 100LL",
                    Fuel_price = 4831,
                    Fuel_quantity = 90000,
                    Fuel_Type = "AvGas"
                });
                dbcontext.SaveChanges();

            }

            if (!dbcontext.orderDetails.Any())
            {
                dbcontext.orderDetails.Add(new Order
                {
                    Fuel_Id = "A3",
                    Vendor_Id = 1,
                    Fuel_quantity = 0
                }) ;

                dbcontext.orderDetails.Add(new Order
                {
                    Fuel_Id = "A4",
                    Vendor_Id = 1,
                    Fuel_quantity = 0
                });
                dbcontext.orderDetails.Add(new Order
                {
                    Fuel_Id = "A4",
                    Vendor_Id = 2,
                    Fuel_quantity = 0
                });
                dbcontext.SaveChanges();
            }

        }
    }
}

