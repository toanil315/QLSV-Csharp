using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeMidTerm.Models
{
    public class Class
    {
        public Class()
        {
            Students = new List<Student>();
        }
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }
    }
}