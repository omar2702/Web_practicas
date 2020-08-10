using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }

        public EUnit0fMeasurement EUnit0fMeasurement { get; set; }

        //Poblara list de productos en una columna en la clase Products
        public int categoryId { get; set;  }
        public Category Category { get; set; }
    }
}
