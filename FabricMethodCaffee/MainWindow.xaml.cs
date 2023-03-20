using System;
using System.Windows;
using ChainOfResponsibility;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Security.Policy;

namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public static class ListExtensions
    {
        public static string StringList<T>(this List<T> list)
        {
            string result = string.Empty;
            foreach (T item in list)
            {
                result += string.Concat(Environment.NewLine, item!.ToString());
            }
            return result;
        }

        public static void MakeDiscount<T>(this List<T> list, DiscountHandler handler) where T : AbstractProduct
        {
            foreach (T item in list)
            {
                handler.HanldeRequest(item);
            }
        }

    }

    public partial class MainWindow : Window
    {
        List<FoodProduct> foodProducts;
        List<ChemicalIndustryProduct> chemicalProducts;
        List<DecorativeItemProduct> decorativeProducts;

        DiscountHandler foodProductsDiscount;
        DiscountHandler chemicalProductDiscount;
        DiscountHandler decorativeItemDiscount;

        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            foodProducts = new List<FoodProduct>();
            chemicalProducts = new List<ChemicalIndustryProduct>();
            decorativeProducts = new List<DecorativeItemProduct>();

            foodProductsDiscount = new FoodProductDiscountHandler();
            chemicalProductDiscount = new ChemicalIndustryProductDiscountHandler();
            decorativeItemDiscount = new DecorativeItemDiscountHandler();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PriceTextBox.Text = string.Empty;
            if (foodProducts.Count > 0)
            {
                PriceTextBox.Text += foodProducts.StringList();
                
            }
            if (chemicalProducts.Count > 0)
            {
                PriceTextBox.Text += Environment.NewLine;
                PriceTextBox.Text += chemicalProducts.StringList();
            }
            if (decorativeProducts.Count > 0)
            {
                PriceTextBox.Text += Environment.NewLine;
                PriceTextBox.Text += decorativeProducts.StringList();
                
            }

            //chain of responsibility
            foodProducts.MakeDiscount(foodProductsDiscount);
            foodProducts.MakeDiscount(chemicalProductDiscount);
            foodProducts.MakeDiscount(decorativeItemDiscount);

            chemicalProducts.MakeDiscount(foodProductsDiscount);
            chemicalProducts.MakeDiscount(chemicalProductDiscount);
            chemicalProducts.MakeDiscount(decorativeItemDiscount);

            decorativeProducts.MakeDiscount(foodProductsDiscount);
            decorativeProducts.MakeDiscount(chemicalProductDiscount);
            decorativeProducts.MakeDiscount(decorativeItemDiscount);

            //
            PriceTextBox.Text += Environment.NewLine;
            PriceTextBox.Text += Environment.NewLine;
            PriceTextBox.Text += "~~~After Discount~~~";
            PriceTextBox.Text += Environment.NewLine;
            if (foodProducts.Count > 0)
            {
                PriceTextBox.Text += foodProducts.StringList();
            }
            if (chemicalProducts.Count > 0)
            {
                PriceTextBox.Text += Environment.NewLine;
                PriceTextBox.Text += chemicalProducts.StringList();
            }
            if (decorativeProducts.Count > 0)
            {
                PriceTextBox.Text += Environment.NewLine;
                PriceTextBox.Text += decorativeProducts.StringList();
            }

            foodProducts.Clear();
            chemicalProducts.Clear();
            decorativeProducts.Clear();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;
            FoodProduct foodProduct = new FoodProduct(currentCheckBox.Content.ToString()!, "average food product", random.Next(10, 101));
            if (currentCheckBox.IsChecked == true)
            {
                foodProducts.Add(foodProduct);
            }
            else
            {
                FoodProduct productToDelete = foodProducts.Where(x => x.Name.Equals(foodProduct.Name)).FirstOrDefault()!;
                foodProducts.Remove(productToDelete);
            }
        }

        private void CheckBox_Click_1(object sender, RoutedEventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;
            ChemicalIndustryProduct chemicalProduct = new ChemicalIndustryProduct(currentCheckBox.Content.ToString()!, "average chemical industry product", random.Next(20, 201));
            if (currentCheckBox.IsChecked == true)
            {
                chemicalProducts.Add(chemicalProduct);
            }
            else
            {
                ChemicalIndustryProduct productToDelete = chemicalProducts.Where(x => x.Name.Equals(chemicalProduct.Name)).FirstOrDefault()!;
                chemicalProducts.Remove(productToDelete);
            }
        }

        private void CheckBox_Click_2(object sender, RoutedEventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;
            DecorativeItemProduct decorativeProduct = new DecorativeItemProduct(currentCheckBox.Content.ToString()!, "average decorative item product", random.Next(30, 301));
            if (currentCheckBox.IsChecked == true)
            {
                decorativeProducts.Add(decorativeProduct);
            }
            else
            {
                DecorativeItemProduct productToDelete = decorativeProducts.Where(x => x.Name.Equals(decorativeProduct.Name)).FirstOrDefault()!;
                decorativeProducts.Remove(productToDelete);
            }
        }
    }
}
