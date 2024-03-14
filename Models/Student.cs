using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Student
    {
        public int Id {get;set;}
        [Required]
        public string Name {get;set;}=string.Empty;
        public string? Addresses {get;set;}
        public string? PhoneNumber {get;set;}
        public string? Email {get;set;}
    }
}