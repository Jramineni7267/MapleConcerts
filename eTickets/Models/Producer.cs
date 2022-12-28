using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Sponsor Banner")]
        [Required(ErrorMessage = "Sponsors Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Sponsor Name")]
        [Required(ErrorMessage = "Sponsor Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Sponsor's Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Sponsors's Details")]
        [Required(ErrorMessage = "Sponsors's Details are required")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
