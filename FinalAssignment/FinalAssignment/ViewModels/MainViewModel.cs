using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.ViewModels 
{
    class MainViewModel : Conductor<object>
    {
        private OrdersViewModel ovm;
        private InventoryViewModel ivm;
        private NewOrderViewModel novm;

        public MainViewModel(OrdersViewModel ordersVM, InventoryViewModel inventoryVM, NewOrderViewModel newOrdersVM)
        {
            ovm = ordersVM;
            ivm = inventoryVM;
            novm = newOrdersVM;
            Orders();
        }

        public void Orders()
        {
            ActivateItem(ovm);
        }

        public void Inventory()
        {
            ActivateItem(ivm);
        }

        public void NewOrders()
        {
            ActivateItem(novm);
        }
    }
}
