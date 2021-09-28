using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int CampaignId { get; set; }
        public string InvoiceNumber { get; set; }
        public double Price { get; set; }
    }
}
