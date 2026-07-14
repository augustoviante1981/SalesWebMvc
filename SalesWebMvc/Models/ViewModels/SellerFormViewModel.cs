using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public SwmSeller SwmSeller { get; set; }
        public ICollection<SwmDepartment> SwmDepartments { get; set; }
        
    }
}
