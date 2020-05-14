using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Proyecto22
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private List<TabItem> _tabItems;
        public MainWindow()
        {
            InitializeComponent();

            /*try
            {
                InitializeComponent();

                // initialize tabItem array
                _tabItems = new List<TabItem>();

                // add a tabItem with + in header 
                for(int i = 0; i < 5; i++)
                {
                    TabItem tabAdd = new TabItem();
                    tabAdd.Header = "+";
                    _tabItems.Add(tabAdd);
                }
                
                // add first tab
                //this.AddTabItem();

                // bind tab control
                tabControl.DataContext = _tabItems;
                tabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/


        }

        List<String> historial = new List<String>();

        private void Window_Loaded(Object sender, RoutedEventArgs e)
        {
            try
            {
                myweb.Source = new Uri("http://www.Google.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//go
        {
           
        }

        public ICommand NewTabCommand { get; }

        private void NewTab()
        {

        }


        private void Button_Click_4(object sender, RoutedEventArgs e)//back
        {
            try
            {
                myweb.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)//forward
        {
            try
            {
                myweb.GoForward();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)//go
        {
            try
            {
                historial.Add("http://" + search.Text);
                //tabControl.SelectedIndex
                TabItem tab = (TabItem)tabControl.SelectedItem;
                WebBrowser web = new WebBrowser();
                web.Source = new Uri("http://" + search.Text);
                web.Height = 394;
                web.Width = 974;
                tab.Content = web;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String variable = "";
            for(int i = 0; i < historial.Count; i++)
            {
                variable += historial[i] + " ";
            }
            MessageBox.Show(variable, "Historial", MessageBoxButton.OK, MessageBoxImage.Information);
            variable = "";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            historial.Clear();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)//Agregar Ventana
        {
            int idx = tabControl.Items.Count;
            tabControl.SelectedIndex = idx - 1;
            TabItem ti = new TabItem();
            ti.Name = "new";
            ti.Header = "new";
            WebBrowser web = new WebBrowser();
            web.Source = new Uri("http://www.Google.com");
            web.Height = 394;
            web.Width = 974;
            ti.Content = web;

            tabControl.Items.Insert(tabControl.Items.Count - 1, ti);

            tabControl.SelectedIndex = tabControl.Items.Count - 2;
        }

        /*ObservableCollection<ItemVM> _items;
        public ObservableCollection<ItemVM> Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new ObservableCollection<ItemVM>();
                    var itemsView = (IEditableCollectionView)CollectionViewSource.GetDefaultView(_items);
                    itemsView.NewItemPlaceholderPosition = NewItemPlaceholderPosition.AtEnd;
                }

                return _items;
            }
        }

        private DelegateCommand<object> _newCommand;
        public DelegateCommand<object> NewCommand
        {
            get
            {
                if (_newCommand == null)
                {
                    _newCommand = new DelegateCommand<object>(New_Execute);
                }

                return _newCommand;
            }
        }

        private void New_Execute(object parameter)
        {
            Items.Add(new ItemVM());
        }

    }

    public class TemplateSelector : DataTemplateSelector
    {
        public DataTemplate ItemTemplate { get; set; }
        public DataTemplate NewButtonTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == CollectionView.NewItemPlaceholder)
            {
                return NewButtonTemplate;
            }
            else
            {
                return ItemTemplate;
            }
        }*/
    }
}
