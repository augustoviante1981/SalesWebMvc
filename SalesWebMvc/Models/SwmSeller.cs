using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class SwmSeller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Aniversário")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary{ get; set; }
        [Display(Name = "Departamento")]
        public SwmDepartment SwmDepartment { get; set; }
        [Display(Name = "Departamento")]
        public int SwmDepartmentId { get; set; }
        public ICollection<SwmSalesRecord> SwmSales { get; set; } = new List<SwmSalesRecord>();

        public SwmSeller()
        { 
        }

        public SwmSeller(int id, string name, string email, DateTime birthDate, double baseSalary, SwmDepartment swmDepartment)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            SwmDepartment = swmDepartment;
        }

        public void AddSales(SwmSalesRecord psr)
        {
            SwmSales.Add(psr);
        }

        public void RemoveSales(SwmSalesRecord psr)
        {
            SwmSales.Remove(psr);
        }

        public double TotalSales(DateTime pinitial, DateTime pfinal)
        {
            return SwmSales.Where(sr => sr.Date >= pinitial && sr.Date <= pfinal).Sum(sr => sr.Amount);
        }
    }
}
