using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCustomerLoyaltyPrgAndTestNS
{

    public class ProductVendor
    {
        //private int pointSaldo = 0; 

        Dictionary<int, int> pointList;
        Dictionary<String, int> customerPurchases;
        

        public ProductVendor(int initialPoints)
        {
            this.PointSaldo = initialPoints;

            pointList = new Dictionary<int, int>();
            pointList[1] = 5;
            pointList[2] = 10;
        }

        public int PointSaldo { get; set;}

        public int requirePoints(Customer customer, int itemId, int qty)
        {
            // TODO LÆRER check om itemId findes pointList
            // TODO LÆRER check om qty er et POSITIVT tal

            if (qty == 0 || itemId == 0)
            {
                return 0;
            }
            else
            {
                return pointList[itemId] * qty;
                // TODO LÆRER brug customerPurcheses til at checke om brugeren har købt en anden vare hos os før := mere rabat
                // TODO LÆRER brug customerPurcheses til at checke om brugeren har købt samme vare hos os før := mindre rabat
                
            }
        }
    }
}
