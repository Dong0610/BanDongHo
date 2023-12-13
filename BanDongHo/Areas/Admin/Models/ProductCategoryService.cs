using BanDongHo.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BanDongHo.Areas.Admin.Models
{
    public class ProductCategoryService
    {

        BANDONGHOEntities db;

        public ProductCategoryService()
        {
            db = new BANDONGHOEntities();
        }

        public IEnumerable<LOAISANPHAM> getAllProductCategory()
        {        
            return db.LOAISANPHAM;
        }

        public bool addProductCategory(LOAISANPHAM lsp)
        {
            try
            {
                db.LOAISANPHAM.Add(lsp);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateProductCategory(LOAISANPHAM lsp)
        {
            try
            {
                var result = db.LOAISANPHAMs.Find(lsp.MALOAISP);
                if(result != null)
                {
                    result.TENLOAISP = lsp.TENLOAISP;
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteProductCategory(string malsp)
        {          
                try
                {              
                    string query = "DELETE FROM SANPHAM WHERE MALOAISP = '" + malsp + "'";
                    string query2 = "DELETE FROM LOAISANPHAM WHERE MALOAISP = '" + malsp + "'";
                    db.Database.ExecuteSqlCommand(query);
                    db.Database.ExecuteSqlCommand(query2);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }          

        }

        public string getLastRecord()
        {
            string res = "";
            var lastrecord = db.LOAISANPHAMs.OrderByDescending(p => p.MALOAISP).FirstOrDefault();
            if (lastrecord != null)
            {
                res = lastrecord.MALOAISP;
            }

            return res ;
        }

        public LOAISANPHAM getProductCategoryById(string malsp)
        {
            return db.LOAISANPHAM.Find(malsp);
        }

    }
}