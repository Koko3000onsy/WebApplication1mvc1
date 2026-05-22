using ClassLibrary1.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAL.Models
{
    public class Trainer :GymUser
    {
        public Specialisty Specialisty { get; set; }
    }
}
