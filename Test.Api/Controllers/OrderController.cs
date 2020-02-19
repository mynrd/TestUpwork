using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Services;
using Test.Services.Models;

namespace Test.Api.Controllers
{
    [RoutePrefix("orders")]
    public class OrderController : ApiController
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [Route("getbyid/{id}")]
        public OrderModel Get(int id)
        {
            return _orderService.GetById(id);
        }

        [Route("getgroupbyaddress")]
        public IEnumerable<OrderGrouppedByAddressModel> GetGroupByAddress()
        {
            return _orderService.GetOrderGrouppedByAddress();
        }
    }
}