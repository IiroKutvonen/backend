using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExample.Models
{
    public partial class Person
    {
        public Person()
        {
            phone = new HashSet<Phone>();
        }

        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? Age { get; set; }

        [InverseProperty("Person")]
        public virtual ICollection<Phone> phone { get; set; }
    }
}