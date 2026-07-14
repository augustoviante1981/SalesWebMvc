using SalesWebMvc.Models.Enuns;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SwmSalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public SwmSalesStatus Status { get; set; }
        public SwmSeller SwmSeller { get; set; }

        public SwmSalesRecord() 
        { 
        }

        public SwmSalesRecord(int id, DateTime date, double amount, SwmSalesStatus status, SwmSeller swmSeller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            SwmSeller = swmSeller;
        }
    }
}
