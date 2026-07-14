using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class SwmDepartment
    {
        public int Id { get; set; }

        [Display(Name = "Departamento")]
        public string Name { get; set; }

        public ICollection<SwmSeller> SwmSellers { get; set; } = new List<SwmSeller>();

        public SwmDepartment()
        { 
        }

        public SwmDepartment(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSalller(SwmSeller pseller)
        {
            SwmSellers.Add(pseller);
        }

        public double TotalSales(DateTime pinitial, DateTime pfinal)
        {
            return SwmSellers.Sum(pseller => pseller.TotalSales(pinitial, pfinal));
        }
    }
}
