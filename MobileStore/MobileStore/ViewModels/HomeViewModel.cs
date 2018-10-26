using MobileStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Phone> IsPreferredPhone { get; set; }
    }
}
