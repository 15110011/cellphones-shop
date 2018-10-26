using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Mocks
{
    public class MockPhoneRepository : IPhoneRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Phone> Phones
        {
            get
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        Name="Iphone XS Max",
                        Price = 34M, ShortDescription = "Dien thoai ban chay nhat hien tai",                        
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "",                        
                        IsPreferredPhone = true,
                        ImageThumbnailUrl = ""
                    },
                    new Phone
                    {
                        Name="Iphone XS",
                        Price = 28M, ShortDescription = "Dien thoai ban chay nhat hien tai",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "",
                        IsPreferredPhone = true,
                        ImageThumbnailUrl = ""
                    },
                    new Phone
                    {
                        Name="Iphone XR",
                        Price = 22M, ShortDescription = "Dien thoai ban chay nhat hien tai",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "",
                        IsPreferredPhone = true,
                        ImageThumbnailUrl = ""
                    },
                        new Phone
                    {
                        Name="Samsung Galaxy note 9",
                        Price = 22M, ShortDescription = "Dien thoai android ban chay nhat hien tai",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "",
                        IsPreferredPhone = true,
                        ImageThumbnailUrl = ""
                    }
                };
            }
        }
        public IEnumerable<Phone> PreferredPhones { get; }

        public IEnumerable<Phone> PreferedPhones => throw new NotImplementedException();

        public Phone GetPhoneById(int phoneID)
        {
            throw new NotImplementedException();
        }
    }
}
