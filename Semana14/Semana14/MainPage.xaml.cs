using Semana14.Models;
using Semana14.Services;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Semana14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            List<Product> products = new List<Product>();

            for (int i = 0; i < 3; i++)
            {
                // Obtener los valores de los campos
                string name = txtName.Text;
                string description = txtDescription.Text;
                double price = double.Parse(txtPrice.Text);
                DateTime expirationDate = txtdate.Date;

                // Crear un nuevo objeto Product con los valores ingresados
                Product product = new Product
                {
                    Name = name,
                    Description = description,
                    Price = price,
                    Expirationdate = expirationDate
                };

                products.Add(product);
            }

            service.CreateRange(products);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            lvlProduct.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            lvlProduct.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}
