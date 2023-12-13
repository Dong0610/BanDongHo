
using BanDongHo.Models;
using System;
using System.Collections.Generic;

namespace BanDongHo.Areas.Admin.Models
{
    public class PromotionDetailService
    {
        BANDONGHOEntities db;

        public PromotionDetailService()
        {
            db = new BANDONGHOEntities();
        }
        public IEnumerable<CHITIETKM> getAllPromotionDetail()
        {           
            return db.CHITIETKM;
        }

        public IEnumerable<SANPHAM> getAllProduct()
        {
            return db.SANPHAM;
        }

        public IEnumerable<KHUYENMAI> getALLPromotion()
        {
            return db.KHUYENMAI;
        }

        public CHITIETKM getOnePromotionDetail(string makm, int masp)
        {         
            return db.CHITIETKM.Find(makm, masp);          
        }

        public bool addPromotionDetail(CHITIETKM ctkm)
        {
            try
            {
                db.CHITIETKM.Add(ctkm);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool updatePromotionDetail(CHITIETKM ctkm)
        {
            try
            {
                var result = db.CHITIETKMs.Find(ctkm.MAKM, ctkm.MASP);
                if (result != null)
                {                   
                    result.PHANTRAMKM = ctkm.PHANTRAMKM;
                    db.SaveChanges();
                    return true;
                    
                }             
                return false;                     
               
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletePromotionDetail(string makm, int masp)
        {
            try
            {
                db.CHITIETKMs.Remove(db.CHITIETKMs.Find(makm, masp));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }


    }
}