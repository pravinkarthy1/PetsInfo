using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PetInfo.Client.Models;

namespace PetInfo.Client.Services
{
    public interface IPersonService
    {
        Task<List<OwnerGenderWiseCats>> GetOwnerGenderWiseCats();
    }
}
