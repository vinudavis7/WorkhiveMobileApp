﻿using System.ComponentModel.DataAnnotations;

namespace WorkHiveMobileApp.ViewModel
{
    public class Users
    {

        public int UserId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Phone { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string Location { get; set; }
        [Required, MaxLength(50)]
        public string UserType { get; set; }
        public string ProfileImage { get; set; }
        [Required, MaxLength(50)]
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
    }
}