using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Altium.NewProjectDialog.Models
{
    public class NavigationTreeItem
    {
        private ObservableCollection<NavigationTreeItem> _children = new ObservableCollection<NavigationTreeItem>();

        public int ID { get; set; }
        public string Name { get; set; }
        public ImageSource Image { get; set; }
        public bool IsSelected { get; set; }

        public ObservableCollection<NavigationTreeItem> Items
        {
            get { return _children; }
            set { _children = value; }
        }
    }
}
