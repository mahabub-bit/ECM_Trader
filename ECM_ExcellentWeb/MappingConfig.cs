using AutoMapper;
using ECM_ExcellentWeb.Model.Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECM_ExcellentWeb
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CompanyDTO, CompanyCreateDTO>().ReverseMap();
            CreateMap<CompanyDTO, CompanyUpdateDTO>().ReverseMap();

            CreateMap<CategoryDTO, CategoryCreateDTO>().ReverseMap();
            CreateMap<CategoryDTO, CategoryUpdateDTO>().ReverseMap();

            CreateMap<SupplierDTO, SupplierCreateDTO>().ReverseMap();
            CreateMap<SupplierDTO, SupplierUpdateDTO>().ReverseMap();

            CreateMap<CategoryTypeDTO, CategoryTypeCreateDTO>().ReverseMap();
            CreateMap<CategoryTypeDTO, CategoryTypeUpdateDTO>().ReverseMap();

            CreateMap<ProductDTO, ProductCreateDTO>().ReverseMap();
            CreateMap<ProductDTO, ProductUpdateDTO>().ReverseMap();

            CreateMap<ProductRateHistoryDTO, ProductRateHistoryCreateDTO>().ReverseMap();
            CreateMap<ProductRateHistoryDTO, ProductRateHistoryUpdateDTO>().ReverseMap();

            CreateMap<CustomerDTO, CustomerCreateDTO>().ReverseMap();
            CreateMap<CustomerDTO, CustomerUpdateDTO>().ReverseMap();

            CreateMap<CustomerAddressDTO, CustomerAddressCreateDTO>().ReverseMap();
            CreateMap<CustomerAddressDTO, CustomerAddressUpdateDTO>().ReverseMap();

            CreateMap<PurchaseOrderDTO, PurchaseOrderCreateDTO>().ReverseMap();
            CreateMap<PurchaseOrderDTO, PurchaseOrderUpdateDTO>().ReverseMap();

            CreateMap<PurchaseOrderDetailDTO, PurchaseOrderDetailCreateDTO>().ReverseMap();
            CreateMap<PurchaseOrderDetailDTO, PurchaseOrderDetailUpdateDTO>().ReverseMap();
        }
    }
}
