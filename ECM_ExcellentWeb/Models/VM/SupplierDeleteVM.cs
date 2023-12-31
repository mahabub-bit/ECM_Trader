﻿using ECM_ExcellentWeb.Model.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECM_ExcellentWeb.Models.VM
{
    public class SupplierDeleteVM
    {
        public SupplierDeleteVM()
        {
            Supplier = new SupplierDTO();
        }

        public SupplierDTO Supplier { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CompanyList { get; set; }
    }

}
