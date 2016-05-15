using System.Collections.Generic;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using Altium.NewProjectDialog.Models;
using GalaSoft.MvvmLight.Command;
using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Altium.NewProjectDialog.ViewModels
{
    public class MainVindowViewModel : ViewModelBase
    {
        public MainVindowViewModel()
        {
            SolutionSelectTypes = new ObservableCollection<BaseItem>(new List<BaseItem>
            {
                new BaseItem { ID = 1, Name = "Create new solution" },
                new BaseItem { ID = 2, Name = "Add to solution" },
                new BaseItem { ID = 3, Name = "Create in new instance" }
            });

            SelectedSolutionTypes = SolutionSelectTypes[0];
        }

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

        RelayCommand _browseCommand;
        public RelayCommand BrowseCommand
        {
            get
            {
                return _browseCommand ?? (_browseCommand = new RelayCommand(Browse));
            }
        }

        private void Browse()
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
        }
    }
}
