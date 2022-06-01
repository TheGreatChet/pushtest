using NamordnikApp.ADO;
using NamordnikApp.Classes;
using NamordnikApp.Windows;
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

namespace NamordnikApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window  
    {
        int curPage = 0;
        int maxPages;
        int countInPage = 20;

        public MainWindow()
        {
            InitializeComponent();
            ProdLv.ItemsSource =  ConnectionClass.connection.Product.ToList();

            var prodTypes = ConnectionClass.connection.ProductType.ToList();
            prodTypes.Insert(0, new ADO.ProductType() { ID = 0, Title = "Все типы" });
            FilterCb.ItemsSource = prodTypes;
            FilterCb.DisplayMemberPath = "Title";
            FilterCb.SelectedValuePath = "ID";

            SortCb.ItemsSource = new List<string>()
            {
                "По наименование (возр.)",
                "По наименование (убыв.)",
                "По цеху (возр.)",
                "По цеху (убыв.)",
                "По стоимости (возр.)",
                "По стоимости (убыв.)",
            };


            Sort();
        }

        void Sort()
        {
            var list = ConnectionClass.connection.Product.ToList();

            if (FilterCb.SelectedValue != null)
                if (FilterCb.SelectedValue.ToString() != "0")
                    list = list.Where(c => c.ProductTypeID == Convert.ToInt32(FilterCb.SelectedValue)).ToList();

            if (SortCb.SelectedIndex == 0)
                list = list.OrderBy(c => c.Title).ToList();
            else if (SortCb.SelectedIndex == 1)
                list = list.OrderByDescending(c => c.Title).ToList();
            else if (SortCb.SelectedIndex == 2)
                list = list.OrderBy(c => c.ProductionWorkshopNumber).ToList();
            else if (SortCb.SelectedIndex == 3)
                list = list.OrderByDescending(c => c.ProductionWorkshopNumber).ToList();
            else if (SortCb.SelectedIndex == 4)
                list = list.OrderBy(c => c.MinCostForAgent).ToList();
            else if (SortCb.SelectedIndex == 5)
                list = list.OrderByDescending(c => c.MinCostForAgent).ToList();

            if (!string.IsNullOrEmpty(SearchTb.Text))
                list = list.Where(c => c.Title.Contains(SearchTb.Text)).ToList();

            maxPages = (int)Math.Ceiling((list.Count * 1.0) / countInPage);
            list = list.Skip(curPage * countInPage).Take(countInPage).ToList();
            GenerateButtons();

            ProdLv.ItemsSource = list;
        }

        void GenerateButtons()
        {
            PagesSp.Children.Clear();

            Button back = new Button();
            back.Background = Brushes.Transparent;
            back.BorderBrush = Brushes.Transparent;
            back.Content = "<";
            back.Height = 40;
            back.Width = 20;
            back.Margin = new Thickness(2);
            back.Click += BackBtn_Click;
            PagesSp.Children.Add(back);

            for (int i = 1; i < maxPages + 1; i++)
            {
                Button b = new Button();
                b.Background = Brushes.Transparent;
                b.BorderBrush = Brushes.Transparent;
                b.Content = i.ToString();
                b.Height = 40;
                b.Width = 20;
                b.Margin = new Thickness(2);
                b.Click += PageBtn_Click;
                PagesSp.Children.Add(b);
            }

            Button next = new Button();
            next.Background = Brushes.Transparent;
            next.BorderBrush = Brushes.Transparent;
            next.Content = ">";
            next.Height = 40;
            next.Width = 20;
            next.Margin = new Thickness(2);
            next.Click += NextBtn_Click;
            PagesSp.Children.Add(next);
        }

        private void PageBtn_Click(object sender, RoutedEventArgs e)
        {
            curPage = Convert.ToInt32((sender as Button).Content) - 1;
            Sort();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (curPage != 0)
            {
                curPage--;
                Sort();
            }
            else 
                MessageBox.Show("Первая страница!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (curPage < maxPages - 2)
            {
                curPage++;
                Sort();
            }
            else
                MessageBox.Show("Последняя страница!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }



        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e) => Sort();

        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e) => Sort();

        private void FilterCb_SelectionChanged(object sender, SelectionChangedEventArgs e) => Sort();

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<Window>().Where(c => c.Title == "Добавление/изменение товара").Any())
            {
                AddChangeWindow win = new AddChangeWindow(null);
                win.Show();
            }
        }

        private void ClearSortBtn_Click(object sender, RoutedEventArgs e)
        {
            SortCb.SelectedIndex = -1;
            Sort();
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            SortCb.SelectedIndex = -1;
            FilterCb.SelectedIndex = -1;
            curPage = 0;
            Sort();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<Window>().Where(c => c.Title == "Добавление/изменение товара").Any())
            {
                AddChangeWindow win = new AddChangeWindow(ProdLv.SelectedItem as Product);
                win.Show();
            }
        }
    }
}
