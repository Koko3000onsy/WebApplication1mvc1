using ClassLibrary1.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAL.Models
{
    public abstract class GymUser :BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone  { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string BildingNumber { get; set; } 
        public string Street { get; set; }
        public string City { get; set; }

    }
}
