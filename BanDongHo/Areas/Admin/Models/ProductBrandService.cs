﻿using System;
using System.Collections.Generic;
using BanDongHo.Models;

namespace BanDongHo.Areas.Admin.Models
{
   
    public class ProductBrandService
    {
        BANDONGHOEntities db;

        public ProductBrandService()
        {
            db = new BANDONGHOEntities();
        }

        public IEnumerable<THUONGHIEU> getAllProductBrand()
        {          
            return db.THUONGHIEU;
        }

        public THUONGHIEU getProductBrandById(int math)
        {
            return db.THUONGHIEU.Find(math);
        }

        public bool addProductBrand(THUONGHIEU th)
        {
            try
            {
                db.THUONGHIEU.Add(th);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool updateProductBrand(THUONGHIEU th)
        {
            try
            {
                var result = db.THUONGHIEUx.Find(th.MATH);
                if(result != null)
                {
                    result.TENTH = th.TENTH;
                    result.HINHTH = th.HINHTH;
                    db.SaveChanges();
                    return true;
                }
               return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteProductBrand(int math)
        {
            try
            {
                string query = "DELETE FROM SANPHAM WHERE MATH = '" + math + "'";
                string query2 = "DELETE FROM THUONGHIEU WHERE MATH = '" + math + "'";
                db.Database.ExecuteSqlCommand(query);
                db.Database.ExecuteSqlCommand(query2);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}