using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string TcKimlikNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int YearOfBirth { get; set; }
    }
}
