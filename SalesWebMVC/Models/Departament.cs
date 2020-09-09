using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void AddSeller() {}

        public double TotalSales(DateTime initial, DateTime final)
        {
            return 0.0;
        }

    }
}
