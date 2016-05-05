using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using Altium.NewProjectDialog.Models;

namespace Altium.NewProjectDialog.ViewModels
{
    public class MainVindowViewModel : ViewModelBase
    {
        //private TreeViewViewModel _navigation;

        public MainVindowViewModel()
        {
            //Navigation = new TreeViewViewModel();
            //Content1 = new TreeContentViewModel();
            //Navigation.SelectedChanged += Content1.Navigation_SelectedChanged;

            SolutionSelectTypes = new ObservableCollection<BaseItem>(new List<BaseItem>
            {
                new BaseItem { ID = 1, Name = "Create new solution" },
                new BaseItem { ID = 2, Name = "Add to solution" },
                new BaseItem { ID = 3, Name = "Create in new instance" }
            });

            SelectedSolutionTypes = SolutionSelectTypes[0];
            
            
        }

        //public TreeViewViewModel Navigation { get; set; }

        //public TreeContentViewModel Content1 { get; set; }

        private ObservableCollection<BaseItem> _solutionSelectTypes;
        public ObservableCollection<BaseItem> SolutionSelectTypes
        {
            get { return _solutionSelectTypes; }
            set { _solutionSelectTypes = value; }
        }

        private BaseItem _selectedSolutionTypes;
        public BaseItem SelectedSolutionTypes
        {
            get { return _selectedSolutionTypes; }
            set { _selectedSolutionTypes = value; }
        }
    }
}
