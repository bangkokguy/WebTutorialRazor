using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebTutorialRazor.Model
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        [Required]
        [DisplayName("Name")]
        public String Name { get; set; }

        public enum Statuses
        {
            Waiting,
            Reading
        }

        public Statuses Status { get; set; }

        public int Queue { get; set; }

    }
}
