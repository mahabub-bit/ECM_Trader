using AutoMapper;
using ECM_ExcellentWeb.Model.Dto;
using ECM_ExcellentWeb.Models;
using ECM_ExcellentWeb.Models.VM;
using ECM_ExcellentWeb.Service.IService;
using ECM_Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace ECM_ExcellentWeb.Controllers
{
    public class PurchaseOrderDetailController : Controller
    {
        private readonly IPurchaseOrderDetailService _purchaseOrderDetailService;
        private readonly IPurchaseOrderService _purchaseOrderService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public PurchaseOrderDetailController(IPurchaseOrderDetailService dbPurchaseOrderDetail, IProductService dbProduct, IPurchaseOrderService dbPurchaseOrder, IMapper mapper)
        {
            _purchaseOrderDetailService = dbPurchaseOrderDetail;
            _purchaseOrderService = dbPurchaseOrder;
            _productService = dbProduct;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexPurchaseOrderDetail()
        {
            List<PurchaseOrderDetailDTO> list = new();
            var response = await _purchaseOrderDetailService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<PurchaseOrderDetailDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }

        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> CreatePurchaseOrderDetail()
        {
            PurchaseOrderDetailCreateVM purchaseOrderDetailVM = new();
            var response = await _purchaseOrderService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                purchaseOrderDetailVM.PurchaseOrderList = JsonConvert.DeserializeObject<List<PurchaseOrderDTO>>
                    (Convert.ToString(response.Result)).Select(i => new SelectListItem
                    {
                        Text = i.PO_Status,
                        Value = i.Id.ToString()
                    }); ;
            }
            var res = await _productService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (res != null && res.IsSuccess)
            {
                purchaseOrderDetailVM.ProductList = JsonConvert.DeserializeObject<List<ProductDTO>>
                    (Convert.ToString(res.Result)).Select(i => new SelectListItem
                    {
                        Text = i.PName,
                        Value = i.Id.ToString()
                    }); ;
            }
            return View(purchaseOrderDetailVM);
        }

        //[Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePurchaseOrderDetail(PurchaseOrderDetailCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var response = await _purchaseOrderDetailService.CreateAsync<APIResponse>(model.PurchaseOrderDetail, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexPurchaseOrderDetail));
                }
                else
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        ModelState.AddModelError("ErrorMessages", response.ErrorMessages.FirstOrDefault());
                    }
                }
            }

            var resp = await _purchaseOrderDetailService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (resp != null && resp.IsSuccess)
            {
                model.PurchaseOrderList = JsonConvert.DeserializeObject<List<PurchaseOrderDTO>>
                    (Convert.ToString(resp.Result)).Select(i => new SelectListItem
                    {
                        Text = i.PO_Status,
                        Value = i.Id.ToString()
                    }); ;

                model.ProductList = JsonConvert.DeserializeObject<List<ProductDTO>>
                    (Convert.ToString(resp.Result)).Select(i => new SelectListItem
                    {
                        Text = i.PName,
                        Value = i.Id.ToString()
                    }); ;

            }


            return View(model);
        }


        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdatePurchaseOrderDetail(int purchaseOrderDetailId)
        {
            PurchaseOrderDetailUpdateVM purchaseOrderDetailVM = new();
            var response = await _purchaseOrderDetailService.GetAsync<APIResponse>(purchaseOrderDetailId, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                PurchaseOrderDetailDTO model = JsonConvert.DeserializeObject<PurchaseOrderDetailDTO>(Convert.ToString(response.Result));
                purchaseOrderDetailVM.PurchaseOrderDetail = _mapper.Map<PurchaseOrderDetailUpdateDTO>(model);
            }
            if(response != null && response.IsSuccess)
            {
                response = await _purchaseOrderService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    purchaseOrderDetailVM.PurchaseOrderList = JsonConvert.DeserializeObject<List<PurchaseOrderDTO>>
                        (Convert.ToString(response.Result)).Select(i => new SelectListItem
                        {
                            Text = i.PO_Status,
                            Value = i.Id.ToString()
                        });
                }

                response = await _productService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    purchaseOrderDetailVM.ProductList = JsonConvert.DeserializeObject<List<ProductDTO>>
                        (Convert.ToString(response.Result)).Select(i => new SelectListItem
                        {
                            Text = i.PName,
                            Value = i.Id.ToString()
                        });
                }
                return View(purchaseOrderDetailVM);
            }
            return NotFound();
        }

        //[Authorize(Roles = "admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePurchaseOrderDetail(PurchaseOrderDetailUpdateVM model)
        {
            if (ModelState.IsValid)
            {
                var response = await _purchaseOrderDetailService.UpdateAsync<APIResponse>(model.PurchaseOrderDetail, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexPurchaseOrderDetail));
                }
                else
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        ModelState.AddModelError("ErrorMessages", response.ErrorMessages.FirstOrDefault());
                    }
                }
            }
            var resp = await _purchaseOrderDetailService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (resp != null && resp.IsSuccess)
            {
                model.PurchaseOrderList = JsonConvert.DeserializeObject<List<PurchaseOrderDTO>>
                    (Convert.ToString(resp.Result)).Select(i => new SelectListItem
                    {
                        Text = i.PO_Status,
                        Value = i.Id.ToString()
                    });
                model.ProductList = JsonConvert.DeserializeObject<List<ProductDTO>>
                    (Convert.ToString(resp.Result)).Select(i => new SelectListItem
                    {
                        Text = i.PName,
                        Value = i.Id.ToString()
                    });
            }
            return View(model);
        }

        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> DeletePurchaseOrderDetail(int purchaseOrderDetailId)
        {
            PurchaseOrderDetailDeleteVM purchaseOrderDetailVM = new();
            var response = await _purchaseOrderDetailService.GetAsync<APIResponse>(purchaseOrderDetailId, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                PurchaseOrderDetailDTO model = JsonConvert.DeserializeObject<PurchaseOrderDetailDTO>(Convert.ToString(response.Result));
                purchaseOrderDetailVM.PurchaseOrderDetail = model;
            }

            response = await _purchaseOrderService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                purchaseOrderDetailVM.PurchaseOrderList = JsonConvert.DeserializeObject<List<PurchaseOrderDTO>>
                    (Convert.ToString(response.Result)).Select(i => new SelectListItem
                    {
                        Text = i.PO_Status,
                        Value = i.Id.ToString()
                    });
                return View(purchaseOrderDetailVM);
            }

            response = await _productService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                purchaseOrderDetailVM.ProductList = JsonConvert.DeserializeObject<List<ProductDTO>>
                    (Convert.ToString(response.Result)).Select(i => new SelectListItem
                    {
                        Text = i.PName,
                        Value = i.Id.ToString()
                    });
                return View(purchaseOrderDetailVM);
            }
            return NotFound();
        }

        //[Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePurchaseOrderDetail(PurchaseOrderDetailDeleteVM model)
        {

            var response = await _purchaseOrderDetailService.DeleteAsync<APIResponse>(model.PurchaseOrderDetail.Id, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexPurchaseOrderDetail));
            }

            return View(model);
        }
    }
}
