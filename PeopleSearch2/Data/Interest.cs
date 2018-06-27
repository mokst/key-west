using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PeopleSearch2.Data
{
    public class Interest
    {
        [Key]
        public int RowId { get; set; }
        public int PersonId { get; set; }
        public string InterestDescription { get; set; }
        public Person Person { get; set; }
    }
}
