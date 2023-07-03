using System;
using System.Collections.Generic;
using System.Text;

namespace Semana14.Models
{
    public class Product
    {
        
       public String Productosid { get; set; }
       public String Name { get; set; }
       public String Description { get; set; }
       public Double Price { get; set; }
       public DateTime Expirationdate { get; set; }
    }
}
