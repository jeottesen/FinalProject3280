using InventoryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class DummyData : IInventoryData
    {
        private List<Item> Items;

        public DummyData()
        {
            Items = new List<Item>();
            
            Items.Add(new Item() { ItemNumber = 1, Cost = 2.3M, Name = "Item 1", QuantityOnHand = 3 });
            Items.Add(new Item() { ItemNumber = 2, Cost = 5.2M, Name = "Item 2", QuantityOnHand = 9 });
            Items.Add(new Item() { ItemNumber = 3, Cost = 1.5M, Name = "Item 3", QuantityOnHand = 77 });
            Items.Add(new Item() { ItemNumber = 4, Cost = 7.99M, Name = "Item 4", QuantityOnHand = 59 });
        }

        public IEnumerable<Item> GetItems()
        {
            return Items;
        }

        public Task<IEnumerable<Item>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItem> GetOrderItems(int orderNumber)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItem>> GetOrderItemsAsync(int orderNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public bool SaveItem(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveItemAsync(Item item)
        {
            throw new NotImplementedException();
        }

        public bool SaveOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public bool SaveOrderItem(int orderNumber, OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveOrderItemAsync(int orderNumber, OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
