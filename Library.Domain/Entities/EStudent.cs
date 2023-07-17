using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class EStudent
    {
        [Key]
        public int Student_Id { get; set; }
        public string Student_Name { get; set;}
        public string Student_Email { get; set;}
        public string Student_Password { get; set;}
        public string Student_Class { get; set;}
        public string Student_RollNo { get; set;}

    }
}
