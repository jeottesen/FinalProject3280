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
            // pulls the views in and assigns them to activateItem method that was created by caliburn
            ovm = ordersVM;
            ivm = inventoryVM;
            novm = newOrdersVM;
            Orders();
        }
        // these change the title of the window and links to the orders button and activates OrderViewModel
        public void Orders()
        {
            ovm.Update();
            ActivateItem(ovm);
            DisplayName = "Orders";
        }

        public void Inventory()
        {
            ivm.Update();
            ActivateItem(ivm);
            DisplayName = "Inventory";
        }

        public void NewOrders()
        {
            ActivateItem(novm);
            DisplayName = "New Orders";
        }
    }
}
