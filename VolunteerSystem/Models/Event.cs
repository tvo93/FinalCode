using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace VolunteerSystem.Models
{
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }


        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public virtual Job Job { get; set; }
     
        public virtual Volunteer Volunteer { get; set; }

        public virtual ICollection<Event> Events { get; set; }
      //  public virtual ICollection<Volunteer> Volunteers { get; set; }
    }
}