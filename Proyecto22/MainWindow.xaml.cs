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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
                myweb.Source = new Uri("http://" + search.Text);
                historial.Add("http://" + search.Text);
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
