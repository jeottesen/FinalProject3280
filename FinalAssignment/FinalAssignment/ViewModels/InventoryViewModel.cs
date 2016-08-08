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
        private ObservableCollection<Item> inventory;

        public ObservableCollection<Item> Inventory
        {
            get { return inventory; }
            set
            {
                inventory = value;
                NotifyOfPropertyChange("Inventory");
            }
        }

        public InventoryViewModel(IInventoryData data)
        {
            InventoryData = data;
            Inventory = InventoryData.GetItems() as ObservableCollection<Item>;
        }
    }
}
