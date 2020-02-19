using EPA.Core.Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Services.Models;

namespace Test.Services
{
    public interface IOrderService
    {
        OrderModel GetById(int id);
        IEnumerable<OrderGrouppedByAddressModel> GetOrderGrouppedByAddress();
    }

    public class OrderService : IOrderService
    {
        private readonly IRepository<TestOrder> _repoTestOrder;

        public OrderService(IRepository<TestOrder> repoTestOrder)
        {
            _repoTestOrder = repoTestOrder;
        }

        public OrderModel GetById(int id)
        {
            return _repoTestOrder
                .Query()
                .Filter(x => x.Id == id)
                .Get()
                .Select(x => new OrderModel()
                {
                    OrderId = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = x.Address,
                    City = x.City,
                    State = x.State,
                    Country = x.Country,
                    Products = x.TestOrderProducts
                        .Select(op => new OrderProduct()
                        {
                            Sku = op.TestProduct.Sku,
                            Quantity = op.Quantity ?? 0,
                        })
                }).FirstOrDefault();
        }

        public IEnumerable<OrderGrouppedByAddressModel> GetOrderGrouppedByAddress()
        {
            return _repoTestOrder
                .Query()
                .Get()
                .GroupBy(x => x.Address)
                .Select(x => new OrderGrouppedByAddressModel()
                {
                    Address = x.Key,
                    Categories = x.SelectMany(p => p.TestOrderProducts)
                        .GroupBy(top => top.TestProduct.TestProductCategories.FirstOrDefault().TestCategory.Name)
                        .Select(tc => new Models.Category()
                        {
                            CategoryName = tc.Key,
                            Products = tc.Select(op => new OrderProduct()
                            {
                                Sku = op.TestProduct.Sku,
                                Quantity = op.Quantity ?? 0,
                            })
                        })
                }).ToList();
        }
    }
}