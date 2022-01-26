﻿using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Voivodeship { get; set; }
        public string ZipCode { get; set; }

        [Required]
        public string UserId { get; set; }
        public User AppUser { get; set; }
    }
}