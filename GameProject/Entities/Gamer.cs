using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public string NationalNumber { get; set; }
    }
}
