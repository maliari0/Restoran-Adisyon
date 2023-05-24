using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Adisyon.Model
{
    public class ProductListModel
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string Price { get; set; }
        public string Details { get; set; }
        public double Qty { get; set; }
    }

}
