using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly MobileStoreDbContext _mobileStoreDbContext;
        public CategoryRepository(MobileStoreDbContext mobileStoreDbContext)
        {
            _mobileStoreDbContext = mobileStoreDbContext;
        }

        public IEnumerable<Category> Categories => _mobileStoreDbContext.Categories;
    }
}
