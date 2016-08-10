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
    class OrdersViewModel : PropertyChangedBase
    {

        private IInventoryData InventoryData;

        private ObservableCollection<Order> orders;
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
            InventoryData = data;
            Orders = new ObservableCollection<Order>(InventoryData.GetOrders());
            SelectedOrder = Orders[0];
        }
    }
}
