using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
            _rootItems.Add(new NavigationTreeItem
            {
                ID=1,
                Name = "Recent",
                Items = new ObservableCollection<NavigationTreeItem>
                {
                    new NavigationTreeItem
                    {
                        ID=11,
                        Name = "All"
                    }
                }
            });

            _rootItems.Add(new NavigationTreeItem
            {
                ID = 2,
                Name = "Templates",
                Items = new ObservableCollection<NavigationTreeItem>
                {
                    new NavigationTreeItem
                    {
                        ID=21,
                        Name = "Visual C#",
                        Items = new ObservableCollection<NavigationTreeItem>
                        {
                            new NavigationTreeItem
                            {
                                ID=201,
                                Name = "Windows",
                                Items = new ObservableCollection<NavigationTreeItem>
                                {
                                    new NavigationTreeItem
                                    {
                                        ID=2011,
                                        Name = "Universal",
                                    },
                                    new NavigationTreeItem
                                    {
                                        ID=2012,
                                        Name = "Windows 8",
                                        Items = new ObservableCollection<NavigationTreeItem>
                                        {
                                            new NavigationTreeItem
                                            {
                                                ID=20121,
                                                Name = "Universal",
                                            },
                                            new NavigationTreeItem
                                            {
                                                ID=20122,
                                                Name = "Windows",
                                            },
                                            new NavigationTreeItem
                                            {
                                                ID=20123,
                                                Name = "Windows Phone",
                                            },
                                        }
                                    },
                                    new NavigationTreeItem
                                    {
                                        ID=2013,
                                        Name = "Classic Desctop",
                                    },
                                }
                            },
                            new NavigationTreeItem
                            {
                                ID=202,
                                Name = "Web",
                            },
                            new NavigationTreeItem
                            {
                                ID=203,
                                Name = "Office/Sharepoint",
                                Items = new ObservableCollection<NavigationTreeItem>
                                {
                                    new NavigationTreeItem
                                    {
                                        ID=2031,
                                        Name = "Apps",
                                    },
                                    new NavigationTreeItem
                                    {
                                        ID=2032,
                                        Name = "Office Add-ins",
                                    },
                                    new NavigationTreeItem
                                    {
                                        ID=2033,
                                        Name = "SharePoint Solutions",
                                    },
                                }
                            },
                            new NavigationTreeItem
                            {
                                ID=204,
                                Name = "Android",
                            },
                            new NavigationTreeItem
                            {
                                ID=205,
                                Name = "Cloud",
                            },
                            new NavigationTreeItem
                            {
                                ID=206,
                                Name = "Extensibility",
                            },
                            new NavigationTreeItem
                            {
                                ID=207,
                                Name = "iOS",
                            },
                            new NavigationTreeItem
                            {
                                ID=208,
                                Name = "LightSwitch",
                            },
                            new NavigationTreeItem
                            {
                                ID=209,
                                Name = "Reporting",
                            },
                            new NavigationTreeItem
                            {
                                ID=210,
                                Name = "Silverlight",
                            },
                            new NavigationTreeItem
                            {
                                ID=211,
                                Name = "Test",
                            },
                            new NavigationTreeItem
                            {
                                ID=212,
                                Name = "WCF",
                            },
                            new NavigationTreeItem
                            {
                                ID=213,
                                Name = "Workflow",
                            },
                        }
                    }
                }
            });

            _rootItems.Add(new NavigationTreeItem
            {
                ID =3,
                Name = "Online"
            });
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
