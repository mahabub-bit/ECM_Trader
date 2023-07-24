using ECM_ExcellentWeb.Model.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECM_ExcellentWeb.Models.VM
{
    public class PurchaseOrderCreateVM
    {
        public PurchaseOrderCreateVM()
        {
            PurchaseOrder = new PurchaseOrderCreateDTO();
            PurchaseOrderDetail = new PurchaseOrderDetailCreateDTO();
            Product = new ProductCreateDTO();
        }

        public PurchaseOrderCreateDTO PurchaseOrder { get; set; }
        public PurchaseOrderDetailCreateDTO PurchaseOrderDetail { get; set; }
        public ProductCreateDTO Product { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CompanyList { get; set; }
        public IEnumerable<SelectListItem> ProductList { get; set; }
        public IEnumerable<SelectListItem> UserList { get; set; }
        public IEnumerable<SelectListItem> SupplierList { get; set; }
    }
}
