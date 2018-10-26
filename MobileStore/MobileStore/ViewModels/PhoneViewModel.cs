using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.ViewModels
{
    public class PhoneViewModel
    {
        public int PhoneId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageThumbnailUrl { get; set; }
    }
}
