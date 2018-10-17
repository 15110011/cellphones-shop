using Microsoft.EntityFrameworkCore;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Repository
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly MobileStoreDbContext _mobileStoreDbContext;
        public PhoneRepository(MobileStoreDbContext mobileStoreDbContext)
        {
            _mobileStoreDbContext = mobileStoreDbContext;
        }
        public IEnumerable<Phone> Phones => _mobileStoreDbContext.Phones.Include(c => c.Category);

        public IEnumerable<Phone> PreferedPhones => _mobileStoreDbContext.Phones.Where(p=>p.IsPreferredPhone).Include(c=>c.Category);

        public Phone GetPhoneById(int phoneId) => _mobileStoreDbContext.Phones.FirstOrDefault(p => p.PhoneId == phoneId);
        
    }
}
