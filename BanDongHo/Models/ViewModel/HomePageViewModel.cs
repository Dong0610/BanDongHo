using System;
using System.Collections.Generic;
using System.Linq;
namespace BanDongHo.Models.ViewModel
{
    public class HomePageViewModel
    {
        public IEnumerable<SANPHAM> ProductsSelling { get; set; }
        public IEnumerable<ProductViewModel> NewProducts { get; set; }
    }
}