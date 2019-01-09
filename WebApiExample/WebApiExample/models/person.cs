using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExample.models
{
    public partial class Person
    {
        public 
            Person(string name, int? age)
        {
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? Age { get; set; }
    }
}