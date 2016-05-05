using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.Unity;
using Altium.NewProjectDialog.Models;

namespace Altium.NewProjectDialog.ViewModels
{
    public class TreeViewViewModel: ViewModelBase
    {
        private ObservableCollection<NavigationTreeItem> _rootItems = new ObservableCollection<NavigationTreeItem>();
        public event EventHandler<NavigationTreeItem> SelectedChanged;

        public TreeViewViewModel()
        {
            SelectedItemChanged = new RelayCommand<NavigationTreeItem>(ItemChanged);
            _rootItems.Add(new NavigationTreeItem { Name = "Test" });
            _rootItems.Add(new NavigationTreeItem { Name = "Test2" });
            _rootItems.Add(new NavigationTreeItem { Name = "Test3", Items = new ObservableCollection<NavigationTreeItem> { new NavigationTreeItem { Name= "SubTest3"} } });
        }

        public RelayCommand<NavigationTreeItem> SelectedItemChanged { get; private set; }

        public ObservableCollection<NavigationTreeItem> RootItems
        {
            get { return _rootItems; }
            set
            {
                _rootItems = value;
                RaisePropertyChanged(()=> RootItems);
            }
        }

        public NavigationTreeItem SelectedItem { get; set; }

        private void ItemChanged(NavigationTreeItem item)
        {
            SelectedItem = item;

            var call = SelectedChanged;
            if (call != null)
                call(this, SelectedItem);
        }
    }
}
