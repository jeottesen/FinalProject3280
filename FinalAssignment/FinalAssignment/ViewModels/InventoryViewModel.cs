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
    class InventoryViewModel : PropertyChangedBase
    {
        private IInventoryData InventoryData;
        private List<Item> inventory;

        public List<Item> Inventory
        {
            get { return inventory; }
            set
            {
                inventory = value;
                NotifyOfPropertyChange(() => Inventory);
            }
        }

        public InventoryViewModel(IInventoryData data)
        {
            InventoryData = data;
            Inventory = new List<Item>(InventoryData.GetItems());
        }
    }
}
