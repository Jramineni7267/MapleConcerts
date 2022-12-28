using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Concert name")]
        [Required(ErrorMessage = "Concert Name is required")]
        public string Name { get; set; }

        [Display(Name = "Concert description")]
        [Required(ErrorMessage = "Concert Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Concert poster URL")]
        [Required(ErrorMessage = "Concert poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Concert start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Concert end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a Genre")]
        [Required(ErrorMessage = "Concert Genre is required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Select Singer(s)")]
        [Required(ErrorMessage = "Concert actor(s) is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select Location")]
        [Required(ErrorMessage = "Location name is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a Sponsor")]
        [Required(ErrorMessage = "Concert Sponsor is required")]
        public int ProducerId { get; set; }
    }
}
