using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace learning.Models
{
    public class Car
    {

        public int carId { get; set; }

        [Display(Name = "Model")]
        public string carModel { get; set; }

        [Display(Name = "Merk")]
        public Brands brands { get; set; }

        [Display(Name = "Zitplaatsen")]
        public string carSeats { get; set; }

        [Display(Name = "Kleur")]
        public string carColor { get; set; }

        [Display(Name = "Bouwjaar")]
        [DataType(DataType.Date)]
        public DateTime carManYear { get; set; }

        [Display(Name = "Brandstof")]
        public virtual List<Engine> engine { get; set; }

        [Display(Name = "Kentekenplaat")]
        public string carLicensePlate { get; set; }

        [Display(Name = "Dagprijs")]
        public double carDayPrice { get; set; }

        [Display(Name = "Vesteging")]
        public virtual List<Location> location { get; set; }

        [Display(Name = "Afbeelding")]
        [DataType(DataType.Upload)]
        public string carImage { get; set; }

    }
}