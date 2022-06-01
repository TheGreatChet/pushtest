using Microsoft.Win32;
using NamordnikApp.ADO;
using NamordnikApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NamordnikApp.Windows
{
    /// <summary>
    /// Interaction logic for AddChangeWindow.xaml
    /// </summary>
    public partial class AddChangeWindow:Window
    {
        Product Cur;
        public AddChangeWindow(Product cur)
        {
            InitializeComponent();
            Cur = cur;

            TypeCb.ItemsSource = ConnectionClass.connection.ProductType.ToList();
            TypeCb.DisplayMemberPath = "Title";
            TypeCb.SelectedValuePath = "ID";

            if (Cur != null)
            {
                ArticleTb.Text = Cur.ArticleNumber;
                TitleTb.Text = Cur.Title;
                TypeCb.SelectedValue = Cur.ProductTypeID;
                AmountTb.Text = Cur.ProductionPersonCount.ToString();
                WorkshopTb.Text = Cur.ProductionWorkshopNumber.ToString();
                PriceTb.Text = Cur.MinCostForAgent.ToString();
                DescrTb.Text = Cur.Description;
                PhotoImg.Source = new BitmapImage(new Uri(Cur.ActualImage, UriKind.RelativeOrAbsolute));
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ArticleTb.Text) || string.IsNullOrEmpty(TitleTb.Text) || TypeCb.SelectedItem == null || string.IsNullOrEmpty(AmountTb.Text) || string.IsNullOrEmpty(WorkshopTb.Text) || string.IsNullOrEmpty(PriceTb.Text) || string.IsNullOrEmpty(DescrTb.Text) || PhotoImg.Source == null)
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (Cur == null)
            {
                Product product = new Product();
                product.ArticleNumber = ArticleTb.Text;
                product.Title = TitleTb.Text;
                product.ProductTypeID = Convert.ToInt32(TypeCb.SelectedValue);
                product.ProductionPersonCount = Convert.ToInt32(AmountTb.Text);
                product.ProductionWorkshopNumber = Convert.ToInt32(WorkshopTb.Text);
                product.MinCostForAgent = Convert.ToDecimal(PriceTb.Text);
                product.Description = DescrTb.Text;
                product.Image = PhotoImg.Source.ToString();

                ConnectionClass.connection.Product.Add(product);
                ConnectionClass.connection.SaveChanges();
            }
            else
            {
                Cur.ArticleNumber = ArticleTb.Text;
                Cur.Title = TitleTb.Text;
                Cur.ProductTypeID = Convert.ToInt32(TypeCb.SelectedValue);
                Cur.ProductionPersonCount = Convert.ToInt32(AmountTb.Text);
                Cur.ProductionWorkshopNumber = Convert.ToInt32(WorkshopTb.Text);
                Cur.MinCostForAgent = Convert.ToDecimal(PriceTb.Text);
                Cur.Description = DescrTb.Text;
                Cur.Image = PhotoImg.Source.ToString();

                ConnectionClass.connection.SaveChanges();
            }

            this.Close();
        }

        private void ArticleTb_PreviewKeyDown(object sender, KeyEventArgs e) => ConstraintsClass.ExceptSpace(e);

        private void ArticleTb_PreviewTextInput(object sender, TextCompositionEventArgs e) => ConstraintsClass.OnlyNums(e);

        private void AmountTb_PreviewKeyDown(object sender, KeyEventArgs e) => ConstraintsClass.ExceptSpace(e);

        private void WorkshopTb_PreviewKeyDown(object sender, KeyEventArgs e) => ConstraintsClass.ExceptSpace(e);

        private void PriceTb_PreviewKeyDown(object sender, KeyEventArgs e) => ConstraintsClass.ExceptSpace(e);

        private void PriceTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (PriceTb.Text.Length < 1)
            {
                if (!Regex.IsMatch(e.Text, @"[0-9]"))
                    e.Handled = true;
            }
            else if (PriceTb.Text.Length >= 1 && PriceTb.Text.Length <= 9)
            {
                if (!Regex.IsMatch(e.Text, @"[0-9 ,]"))
                    e.Handled = true;
            }
            else
            {
                if (!Regex.IsMatch(e.Text, @"[0-9]"))
                    e.Handled = true;
            }

        }

        private void WorkshopTb_PreviewTextInput(object sender, TextCompositionEventArgs e) => ConstraintsClass.OnlyNums(e);

        private void AmountTb_PreviewTextInput(object sender, TextCompositionEventArgs e) => ConstraintsClass.OnlyNums(e);

        private void AddImageBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == true)
                {
                    PhotoImg.Source = new BitmapImage(new Uri(dialog.FileName, UriKind.RelativeOrAbsolute));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (ConnectionClass.connection.ProductSale.Where(c => c.ProductID == Cur.ID).Any())
                {
                    MessageBox.Show("Существуют продажи с продуктом, удаление запрещено", "Ошибка", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    return;
                }

                if(ConnectionClass.connection.ProductMaterial.Where(c => c.ProductID == Cur.ID).Any())
                {
                    foreach (var item in ConnectionClass.connection.ProductMaterial.Where(c => c.ProductID == Cur.ID))
                    {
                        ConnectionClass.connection.ProductMaterial.Remove(item);
                    }
                }

                if (ConnectionClass.connection.ProductCostHistory.Where(c => c.ProductID == Cur.ID).Any())
                {
                    foreach (var item in ConnectionClass.connection.ProductCostHistory.Where(c => c.ProductID == Cur.ID))
                    {
                        ConnectionClass.connection.ProductCostHistory.Remove(item);
                    }
                }

                ConnectionClass.connection.Product.Remove(Cur);

                ConnectionClass.connection.SaveChanges();
                this.Close();
            }
        }
    }
}
