using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Abstract
{
    interface IInvoiceService
    {
        void Add(Invoice invoice,Player player,Campaign campaign);
        void Update(Invoice invoice, Player player, Campaign campaign);
        void Delete(Invoice invoice);
    }
}
