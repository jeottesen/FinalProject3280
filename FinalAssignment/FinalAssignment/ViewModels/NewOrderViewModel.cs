using Caliburn.Micro;
using InventoryData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataInteraction;
using InventoryDataMapping.Models;

namespace FinalAssignment.ViewModels
{
    class NewOrderViewModel : Screen
    {

        private IInventoryData InventoryData;

        private Order order;

        public Order Order
        {
            get { return order; }
            set
            {
                order = value;
                NotifyOfPropertyChange(() => Order);
            }
        }

        private decimal orderTotal;

        public decimal OrderTotal
        {
            get { return orderTotal;  }
            set
            {
                orderTotal = value;
                NotifyOfPropertyChange(() => OrderTotal);
            }
        }


        private ObservableCollection<OrderItem> orderItems;

        public ObservableCollection<OrderItem> OrderItems
        {
            get { return orderItems; }
            set
            {
                orderItems = value;
                NotifyOfPropertyChange(() => OrderItems);
            }
        }

        private OrderItem selectedOrderItem;

        public OrderItem SelectedOrderItem
        {
            get { return selectedOrderItem; }
            set
            {
                selectedOrderItem = value;
                NotifyOfPropertyChange(() => SelectedOrderItem);
            }
        }

        private ObservableCollection<Item> items;

        public ObservableCollection<Item> Items
        {
            get { return items; }
            set
            {
                items = value;
                NotifyOfPropertyChange(() => Items);
            }
        }

        private ObservableCollection<User> users;

        public ObservableCollection<User> Users
        {
            get { return users; }
            set
            {
                users = value;
                NotifyOfPropertyChange(() => Users);
            }
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                NotifyOfPropertyChange(() => SelectedOrderItem);
            }
        }

        private User selectedUser;

        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                NotifyOfPropertyChange(() => SelectedUser);
            }
        }

        public NewOrderViewModel(IInventoryData data)
        {
            InventoryData = data;
            int ordernumber = 0;
            foreach(Order o in InventoryData.GetOrders())
            {
                ordernumber = Math.Max(o.OrderNumber, ordernumber);
            }
            Order = new Order();
            Order.OrderNumber = ordernumber;
            Order.DatePlaced = DateTime.Now;
            Users = new ObservableCollection<User>(InventoryData.GetUsers());
            OrderItems = new ObservableCollection<OrderItem>();
            Items = new ObservableCollection<Item>(InventoryData.GetItems());
            SelectedItem = Items[0];
            SelectedOrderItem = new OrderItem();
            SelectedOrderItem.OrderNumber = ordernumber;
        }

        public void SaveOrder()
        {

            OrderTotal = 0;
            foreach (OrderItem order in OrderItems)
            {
                order.OrderNumber = Order.OrderNumber;
                order.Order = Order;
                order.ItemCost = order.Item.Cost;
                OrderTotal += order.Quantity * order.Item.Cost;
            }

            Order.Purchaser = SelectedUser;
            Order.OrderItems = OrderItems;
            Order.TotalCost = OrderTotal;
            InventoryData.SaveOrder(Order);
        }
    }
}
