using System;
using System.Collections;
using System.Collections.Generic;

namespace PetInfo.Models
{
    public class People
    { 
        public string Name { get; set; } 
        public string Gender { get; set; }
        public string Age { get; set; } 
        public ICollection<Pet> Pets { get; set; }

    }
}
