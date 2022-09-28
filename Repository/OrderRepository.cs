using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Mars_Backend.Data;
using Team_Mars_Backend.Data.Entity;
using Team_Mars_Backend.Data_Admin.Entity_Admin;

namespace Team_Mars_Backend.Repository
{
    public class OrderRepository
    {
        public DatabaseContext _orderContext;
        public OrderRepository(DatabaseContext orderContext)
        {
            _orderContext = orderContext;
        }

        public Order updateVendorFuelQuantity(int v_id,string f_id, int quantity)
        {
            var orderFound = _orderContext.orderDetails.FirstOrDefault(a => a.Vendor_Id == v_id && a.Fuel_Id == f_id);
            if (orderFound != null)
            {
                orderFound.Fuel_quantity = orderFound.Fuel_quantity + quantity;
                this._orderContext.SaveChanges();
            }
                
            return orderFound;
        }
        public IEnumerable<Order> GetAllOrdersWithFuelId(string f_id)
        {
           var orderWithId =  _orderContext.orderDetails.Where(f => f_id == f.Fuel_Id);
            return orderWithId;
        }
        public IEnumerable<Order> GetAllOrdersWithVendorId(int v_id)
        {
            var orderWithId = _orderContext.orderDetails.Where(v => v.Vendor_Id == v_id);
            return orderWithId;
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _orderContext.orderDetails;
        }
    }
}