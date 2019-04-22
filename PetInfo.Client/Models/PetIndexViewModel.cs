using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using PetInfo.Models;

namespace PetInfo.Client.Models
{
    public class PetIndexViewModel
    {

        public IEnumerable<OwnerGenderWiseCats> CatInfoList { get; private set; } 

        public PetIndexViewModel(List<OwnerGenderWiseCats> catInfoList)
        {
            CatInfoList = catInfoList;
        } 
    }

    public class OwnerGenderWiseCats
    {
        public string Gender { get; set; }
        public IEnumerable<string> Cats { get; set; }
    }
}
