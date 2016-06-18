using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        public DateTime Created_at { get; set; }
    }
}