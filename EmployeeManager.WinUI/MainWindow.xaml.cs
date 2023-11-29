using EmployeeManager.DataAccess;
using EmployeeManager.ViewModel;
using Microsoft.UI.Xaml;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace EmployeeManager.WinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel(new EmployeeDataProvider());
            this.Activated += MainWindow_Activated; 
        }

        private void MainWindow_Activated(object sender, WindowActivatedEventArgs args)
        {
            if (ViewModel.Employees.Count == 0) {
                ViewModel.Load();
            }
        }

        public MainViewModel ViewModel { get; }
    }
}
