using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCustomerLoyaltyPrgAndTestNS
{
    public class Customer
    {
        public Guid Id { get; private set; }

        public Customer()
        {
            Id = Guid.NewGuid();
        }

        // TODO ELEV opret metoden getMyPointsForPurchase(vendor, productId, qty)
        // TODO ELEV Implementer en måde at huske om vi har købt samme vare hos samme leverandør før, f.eks. med Dictionary<ProductVendor, int>

    }
}
