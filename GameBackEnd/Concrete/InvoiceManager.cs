using GameBackEnd.Abstract;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concrete
{
    class InvoiceManager : IInvoiceService
    {
        public void Add(Invoice invoice,Player player, Campaign campaign)
        {
            invoice.PlayerId = player.Id;
            invoice.CampaignId = campaign.Id;
            Console.WriteLine("Fatura eklendi : " + invoice.InvoiceNumber);
        }
        public void Update(Invoice invoice, Player player, Campaign campaign)
        {
            invoice.PlayerId = player.Id;
            invoice.CampaignId = campaign.Id;
            Console.WriteLine("Fatura güncellendi : " + invoice.InvoiceNumber);
        }
        public void Delete(Invoice invoice)
        {
            Console.WriteLine("Fatura silindi : " + invoice.InvoiceNumber);
        }
    }
}
