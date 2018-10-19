using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }       
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredPhone { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
