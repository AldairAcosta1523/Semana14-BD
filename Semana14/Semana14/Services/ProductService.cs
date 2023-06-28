using Semana14.DataContext;
using Semana14.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Semana14.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService() => _context = App.GetContext();


        public bool Create(Product item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Products.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Product> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Products.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Product> Get()
        {
            return _context.Products.ToList();
        }


        public List<Product> GetByText(string text)
        {
            return _context.Products.Where(x => x.Name.Contains(text)).ToList();
        }



    }
}