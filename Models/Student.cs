﻿using System.ComponentModel.DataAnnotations;

namespace TestProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
       
    }
}
