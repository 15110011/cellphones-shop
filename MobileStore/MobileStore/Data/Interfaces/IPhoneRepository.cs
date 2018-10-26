using MobileStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Interfaces
{
    public interface IPhoneRepository
    {
        IEnumerable<Phone> Phones { get;}
        IEnumerable<Phone> PreferedPhones { get;}
        Phone GetPhoneById(int phoneId);
    }
}
