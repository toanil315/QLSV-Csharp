using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeMidTerm.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime? Birthday { get; set; }

        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}