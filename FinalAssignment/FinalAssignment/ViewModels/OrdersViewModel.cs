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
    class OrdersViewModel : Screen
    {

        private IInventoryData InventoryData;
        // make our observable orders and tehn return the data from inventoryData and add into selectedOrder
        private ObservableCollection<Order> orders;
        // holds all of the orders
        public ObservableCollection<Order> Orders
        {
            get { return orders; }
            set
            {
                orders = value;
                NotifyOfPropertyChange(() => Orders);
            }
        }

        private Order selectedOrder;
        // filled in by caliburn automatically when you select an order in the data grid. 
        public Order SelectedOrder
        {
            get { return selectedOrder; }
            set
            {
                selectedOrder = value;
                NotifyOfPropertyChange(() => SelectedOrder);
            }
        }

        public OrdersViewModel(IInventoryData data)
        {
            // from bootstrapper to get dependency injection from the inventory class 
            InventoryData = data;
            // get all orders and insert get all the orders from the dummy data
            Orders = new ObservableCollection<Order>(InventoryData.GetOrders());
            // shows the first item automatically if there is any
            if (Orders.Any())
                SelectedOrder = Orders[0];
        }

        public void Update()
        {
            Orders = new ObservableCollection<Order>(InventoryData.GetOrders());
        }
    }

}
