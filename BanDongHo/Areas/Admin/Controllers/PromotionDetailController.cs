using BanDongHo.Areas.Admin.Models;
using BanDongHo.Common;
using BanDongHo.Models;
using System.Web.Mvc;

namespace BanDongHo.Areas.Admin.Controllers
{
	public class PromotionDetailController : Controller
    {
        PromotionDetailService promotionDetailService = new PromotionDetailService();
       
        // GET: Admin/PromotionDetail
        public ActionResult Index()
        {
            var userSession = (UserLogin)Session[CommonConstands.ADMIN_SESSION];
            if (userSession == null)
            {
                return Redirect("~/Admin/Login/Login");
            }
            return View(promotionDetailService.getAllPromotionDetail());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.message = "";
            PromotionDetailViewModel promotionDetailViewModel = new PromotionDetailViewModel();
            ViewBag.KHUYENMAIx = promotionDetailService.getALLPromotion();
            ViewBag.SANPHAMx = promotionDetailService.getAllProduct();
            return View(promotionDetailViewModel);
        }

        [HttpPost]
        public ActionResult Create(PromotionDetailViewModel ctkm)
        {
            if (ModelState.IsValid)
            {
                CHITIETKM chitietkm = new CHITIETKM();
                chitietkm.MAKM = ctkm.MAKM;
                chitietkm.MASP = ctkm.MASP;
                chitietkm.PHANTRAMKM = ctkm.PHANTRAMKM;

                if (promotionDetailService.addPromotionDetail(chitietkm))
                {
                    ViewBag.message = "Thêm mới chi tiết khuyến mãi thành công";                 
                }
            }
            ViewBag.KHUYENMAIx = promotionDetailService.getALLPromotion();
            ViewBag.SANPHAMx = promotionDetailService.getAllProduct();
            return View(ctkm);
        }

        [HttpGet]
        public ActionResult Update(string makm, int masp)
        {
           
            CHITIETKM chitietkm = promotionDetailService.getOnePromotionDetail(makm, masp);

            PromotionDetailViewModel promotionDetailViewModel = new PromotionDetailViewModel();
            promotionDetailViewModel.MAKM = chitietkm.MAKM;
            
            promotionDetailViewModel.MASP = chitietkm.MASP;
           
            promotionDetailViewModel.PHANTRAMKM = (int) chitietkm.PHANTRAMKM;

            ViewBag.KHUYENMAI = chitietkm.MAKM;
            ViewBag.SANPHAM = chitietkm.MASP;

            return View(promotionDetailViewModel);
          
        }

        public ActionResult Update(PromotionDetailViewModel ctkm)
        {          
            if (ModelState.IsValid)
            {
                CHITIETKM chitietkm = new CHITIETKM();
                chitietkm.MAKM = ctkm.MAKM;
                chitietkm.MASP = ctkm.MASP;
                chitietkm.PHANTRAMKM = ctkm.PHANTRAMKM;

                if (promotionDetailService.updatePromotionDetail(chitietkm))
                {                 
                    return RedirectToAction("Index", "PromotionDetail", promotionDetailService.getAllPromotionDetail());
                }
               
            }
            CHITIETKM chitiet = promotionDetailService.getOnePromotionDetail(ctkm.MAKM, ctkm.MASP);
            ViewBag.KHUYENMAI = chitiet.PHANTRAMKM;
            ViewBag.SANPHAM = chitiet.MASP;
            return View(ctkm);
        }

        public ActionResult Delete(string makm, int masp)
        {
            return Json(new { result = promotionDetailService.deletePromotionDetail(makm, masp) });
        }
    }
}