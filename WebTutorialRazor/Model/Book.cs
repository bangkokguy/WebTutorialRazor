using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTutorialRazor.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public String Name { get; set; }

        public String Author { get; set; }

        public String ISBN { get; set; }


    }
}
