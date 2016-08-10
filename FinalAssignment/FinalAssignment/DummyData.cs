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
            OrderItems = new List<OrderItem>();
            Orders = new List<Order>();
            
            User Purchaser1 = new User();
            Purchaser1.Name = "Purchaser 1";
            User Purchaser2 = new User();
            Purchaser2.Name = "Purchaser 2";


            Items.Add(new Item() { ItemNumber = 1, Cost = 2.3M, Name = "Item 1", QuantityOnHand = 3 });
            Items.Add(new Item() { ItemNumber = 2, Cost = 5.2M, Name = "Item 2", QuantityOnHand = 9 });
            Items.Add(new Item() { ItemNumber = 3, Cost = 1.5M, Name = "Item 3", QuantityOnHand = 77 });
            Items.Add(new Item() { ItemNumber = 4, Cost = 7.99M, Name = "Item 4", QuantityOnHand = 59 });

            Orders.Add(new Order {OrderNumber = 1, DatePlaced =  Convert.ToDateTime("03/25/2015 17:43:00.00"), Purchaser = Purchaser1, TotalCost = 37.50m });
            Orders.Add(new Order { OrderNumber = 2, DatePlaced = Convert.ToDateTime("03/25/2015 17:43:00.00"), Purchaser = Purchaser2, TotalCost = 21.75m });

            OrderItems.Add(new OrderItem { OrderNumber = Orders[1].OrderNumber, ItemNumber = Items[0].ItemNumber, Item = Items[0], ItemCost = Items[0].Cost, Quantity = 3, Order = Orders[1], OrderItemNumber = 123 });
            OrderItems.Add(new OrderItem {OrderNumber = Orders[1].OrderNumber,  ItemNumber = Items[2].ItemNumber, Item = Items[2], ItemCost = Items[2].Cost, Quantity = 1, Order = Orders[1], OrderItemNumber = 123});

            OrderItems.Add(new OrderItem { OrderNumber = Orders[0].OrderNumber, ItemNumber = Items[3].ItemNumber, Item = Items[3], ItemCost = Items[3].Cost, Quantity = 3, Order = Orders[0], OrderItemNumber = 123 });
            OrderItems.Add(new OrderItem { OrderNumber = Orders[0].OrderNumber, ItemNumber = Items[1].ItemNumber, Item = Items[1], ItemCost = Items[1].Cost, Quantity = 3, Order = Orders[0], OrderItemNumber = 123 });

        }

        public IEnumerable<Item> GetItems()
        {
            foreach (Item i in Items)
            {
                yield return i;
            }
            //return Items
        }

        public Task<IEnumerable<Item>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItem> GetOrderItems(int orderNumber)
        {
            foreach (OrderItem oi in OrderItems)
            {
                yield return oi;
            }
            //return OrderItems;
        }

        public Task<IEnumerable<OrderItem>> GetOrderItemsAsync(int orderNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            foreach (Order o in Orders)
            {
                yield return o;
            }
            //return Orders;
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
