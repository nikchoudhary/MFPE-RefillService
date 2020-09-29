using MailOrderPharmacyRefillService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailOrderPharmacyRefillService.Repository
{
    public interface IRefillRepository
    {
        public dynamic viewRefillStatus(int Subscription_ID);
        //RefillDetails getRefillDuesAsOfDate(int Subscription_ID, DateTime FromDate);
        public dynamic PendingRefill(int Sub_id, DateTime date, string Token);
        public dynamic requestAdhocRefill(RefillOrderLine order, string Token);
        //public IEnumerable<RefillDetails> GetAll();
    }
}