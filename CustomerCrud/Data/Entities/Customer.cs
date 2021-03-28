using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerCrud.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
       
        public string SureName { get; set; }
        
        public DateTime date { get; set; }

    }
}
