using BanDongHo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BanDongHo.Models.Service
{
    public class CartService
    {
        public static bool CheckNumberProduct(int id,int soluong)
        {
            BANDONGHOEntities db = new BANDONGHOEntities();
            SANPHAM sp = db.SANPHAM.Where(s => s.MASP == id).SingleOrDefault();
            return sp.SOLUONG >= soluong;
        }
    }
}