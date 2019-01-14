using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExample.Models
{
    public partial class Phone
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        public int? Number { get; set; }
        public int? PersonId { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("phone")]
        public virtual Person Person { get; set; }
    }
}