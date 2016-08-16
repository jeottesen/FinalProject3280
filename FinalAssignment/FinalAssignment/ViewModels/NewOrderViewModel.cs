using Caliburn.Micro;
using InventoryData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private int orderTotal;

        public int OrderTotal
        {
            get { return orderTotal;  }
            set
            {S
                orderTotal = value;
                NotifyOfPropertyChange(() => OrderTotal);
            }
        }

        private User purchaser;

        public User Purchaser
        {
            get { return purchaser; }
            set
            {
                purchaser = value;
                NotifyOfPropertyChange(() => Purchaser);
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

        public NewOrderViewModel(IInventoryData data)
        {
            InventoryData = data;
            OrderItems = new ObservableCollection<OrderItem>();
            Items = new ObservableCollection<Item>(InventoryData.GetItems());


        }

    }
}
