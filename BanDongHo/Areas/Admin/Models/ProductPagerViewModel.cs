using System.Collections.Generic;
using BanDongHo.Models;
namespace BanDongHo.Areas.Admin.Models
{
	public class ProductPagerViewModel
    {
        public IEnumerable<SANPHAM> Products { get; set; }
        public Pager Pager { get; set; }

    }

}