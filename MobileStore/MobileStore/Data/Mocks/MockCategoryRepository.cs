using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories{
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName="Apple",Description="Sản xuất bởi Apple"},
                    new Category{CategoryName="Samsung",Description="Sản xuất bởi Samsung"},                    
                };
            }   
        }
    }
}
