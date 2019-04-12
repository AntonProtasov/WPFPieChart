using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Dashboard
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<AssetClass> classes;

        public MainWindow()
        {   
            InitializeComponent();

            classes = new ObservableCollection<AssetClass>(AssetClass.ConstructTestData());
            this.DataContext = classes;
        }

        /// <summary>
        /// Handle clicks on the listview column heading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnColumnHeaderClick(object sender, RoutedEventArgs e)
        {
            GridViewColumn column = ((GridViewColumnHeader)e.OriginalSource).Column;
            piePlotter.PlottedProperty = column.Header.ToString();
        }

        private void AddNewItem(object sender, RoutedEventArgs e)
        {
            AssetClass asset = new AssetClass { Category = "Источник расходов"};
            classes.Add(asset);
        }
    }
}