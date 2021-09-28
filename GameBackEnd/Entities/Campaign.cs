using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DiscountRate { get; set; }
    }
}
