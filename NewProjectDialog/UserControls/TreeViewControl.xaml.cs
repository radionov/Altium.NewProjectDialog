using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.Unity;
using Altium.NewProjectDialog.ViewModels;

namespace Altium.NewProjectDialog.UserControls
{
    /// <summary>
    /// Interaction logic for TreeViewControl.xaml
    /// </summary>
    public partial class TreeViewControl : UserControl
    {
        private TreeViewViewModel _viewModel;

        public TreeViewControl()
        {
            InitializeComponent();
            _viewModel = new TreeViewViewModel();
            DataContext = _viewModel;
        }
    }
}
