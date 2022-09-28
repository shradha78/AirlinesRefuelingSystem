using Microsoft.AspNetCore.Mvc;
using Team_Mars_Backend.Data;
using Team_Mars_Backend.Data.Entity;
using Team_Mars_Backend.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Mars_Backend.Data_Admin.Entity_Admin;

namespace Team_Mars_Backend.Controller
{
    [Route("orders/[controller]")]
    [ApiController]

    public class OrderController : ControllerBase
    {
        public OrderRepository _repo;

        public OrderController(OrderRepository _repo)
        {
            this._repo = _repo;
        }

        [HttpPatch("{Vendor_ID},{Fuel_Id},{Fuel_quantity}")]
        public Order Patch(int v_id, string f_id, int quantity)
        {
            return _repo.updateVendorFuelQuantity(v_id, f_id, quantity);
        }
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return _repo.GetAllOrders();
        }
        [HttpGet("{Fuel_Id}")]
        public IEnumerable<Order> GetOrdersOnFuel(string f_id)
        {
            return _repo.GetAllOrdersWithFuelId(f_id);
        }
        [HttpGet("{Vendor_Id}")]
        public IEnumerable<Order> GetOrdersWithVendor(int v_id)
        {
            return _repo.GetAllOrdersWithVendorId(v_id);
        }
    }
}
