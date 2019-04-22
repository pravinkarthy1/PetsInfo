using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PetInfo.Client.Services
{
    public interface IPersonHttpClient
    {
        Task<HttpClient> GetClient();
    }
}
