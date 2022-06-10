﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.User
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirsName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
