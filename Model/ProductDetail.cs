using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Adisyon.Model
{
    public class ProductDetail
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public List<string> Sizes { get; set; }
        public List<ReviewModel> Reviews { get; set; }
        public Color Colors { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }

    }

    public class ReviewModel
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }
        public float Rating { get; set; }
    }
}
