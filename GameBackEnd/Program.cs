using GameBackEnd.Concrete;
using GameBackEnd.Entities;
using GameBackEnd.TcKimlik.Concrete;
using System;

namespace GameBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player() { Id=1,Name="Mehmet",Surname="Yücetürk",TcKimlikNo="12345678901",YearOfBirth=1976};
            Campaign campaign = new Campaign() {Id=1,Name="Eylül İndirimi",DiscountRate=25,StartDate=new DateTime(2021,9,1),EndDate=new DateTime(2021,9,30) };
            Invoice invoice = new Invoice() { Id=1,InvoiceNumber="45678",Price=100};

            
            PlayerManager playerManager = new PlayerManager(new TcKimlikValidateManager());
            CampaignManager campaignManager = new CampaignManager();
            InvoiceManager invoiceManager = new InvoiceManager();
                        
            campaignManager.Add(campaign);
            if(playerManager.Add(player))
            { 
            invoiceManager.Add(invoice, player, campaign);
            }

        }
    }
}
