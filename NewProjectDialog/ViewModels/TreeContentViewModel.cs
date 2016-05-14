using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altium.NewProjectDialog.Models;
using GalaSoft.MvvmLight;

namespace Altium.NewProjectDialog.ViewModels
{
    public class TreeContentViewModel: ViewModelBase
    {
        public TreeContentViewModel()
        {
            Frameworks =
                new ObservableCollection<BaseItem>(new List<BaseItem>
                {
                    new BaseItem {ID = 1, Name = ".NET Framework 2.0"},
                    new BaseItem {ID = 2, Name = ".NET Framework 3.0"},
                    new BaseItem {ID = 3, Name = ".NET Framework 3.5"},
                    new BaseItem {ID = 4, Name = ".NET Framework 4.0"},
                    new BaseItem {ID = 5, Name = ".NET Framework 4.5"},
                    new BaseItem {ID = 6, Name = ".NET Framework 4.5.1"},
                    new BaseItem {ID = 7, Name = ".NET Framework 4.5.2"},
                    new BaseItem {ID = 8, Name = ".NET Framework 4.6"},
                    new BaseItem {ID = 9, Name = ".NET Framework 4.6.1"}
                });

            SelectedFramework = Frameworks[6];

            SortByItems =
                new ObservableCollection<BaseItem>(new List<BaseItem>
                {
                    new BaseItem {ID = 1, Name = "Default"},
                    new BaseItem {ID = 1, Name = "Name Ascending"},
                    new BaseItem {ID = 1, Name = "Name Descending"}
                });

            SelectedSortByItem = SortByItems[0];

            ListViewContentItems = new ObservableCollection<ListViewContent>(new List<ListViewContent>
            {
                new ListViewContent { Image="/Images/wpf.png", Text1 = "Windows Forms Application", Text2 = "Visual C#"},
                new ListViewContent { Image="/Images/wpf.png", Text1 = "WPF Application", Text2 = "Visual C#"},
                new ListViewContent { Image="/Images/wpf.png", Text1 = "Console Application", Text2 = "Visual C#"},
                new ListViewContent { Image="/Images/wpf.png", Text1 = "Shared Project", Text2 = "Visual C#"},
                new ListViewContent { Image="/Images/wpf.png", Text1 = "Class Library (Portable for iOS, Android and Windows)", Text2 = "Visual C#"},
                new ListViewContent { Image="/Images/wpf.png", Text1 = "Class Library", Text2 = "Visual C#"},
                new ListViewContent { Image="/Images/wpf.png", Text1 = "Class Library (Portable)", Text2 = "Visual C#"},

                new ListViewContent { Image="/Images/wpf.png", Text1 = "Class Library (Portable for iOS, Android and Windows)", Text2 = "Visual C#"},
                new ListViewContent { Image="/Images/wpf.png", Text1 = "Class Library", Text2 = "Visual C#"},
                new ListViewContent { Image="/Images/wpf.png", Text1 = "Class Library (Portable)", Text2 = "Visual C#"},
            });
        }

        public void Navigation_SelectedChanged(object sender, NavigationTreeItem e)
        {
            //Frameworks.Add(new BaseItem {ID = e.ID, Name = e.Name});
            //RaisePropertyChanged(() => Frameworks);
        }

        private ObservableCollection<BaseItem> _frameworks;
        public ObservableCollection<BaseItem> Frameworks
        {
            get { return _frameworks; }
            set
            {
                _frameworks = value;
                RaisePropertyChanged(()=> Frameworks);
            }
        }

        private BaseItem _selectedFramework;
        public BaseItem SelectedFramework
        {
            get { return _selectedFramework; }
            set
            {
                _selectedFramework = value;
                RaisePropertyChanged(() => SelectedFramework);
            }
        }

        private ObservableCollection<BaseItem> _sortByItems;
        public ObservableCollection<BaseItem> SortByItems
        {
            get { return _sortByItems; }
            set
            {
                _sortByItems = value;
                RaisePropertyChanged(() => SortByItems);
            }
        }

        private BaseItem _selectedSortByItem;
        public BaseItem SelectedSortByItem
        {
            get { return _selectedSortByItem; }
            set
            {
                _selectedSortByItem = value;
                RaisePropertyChanged(() => SelectedSortByItem);
            }
        }

        private ObservableCollection<ListViewContent> _listViewContentItems;
        public ObservableCollection<ListViewContent> ListViewContentItems
        {
            get { return _listViewContentItems; }
            set
            {
                _listViewContentItems = value;
                RaisePropertyChanged(() => ListViewContentItems);
            }
        }
    }
}
