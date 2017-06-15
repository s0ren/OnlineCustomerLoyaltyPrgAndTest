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

        System.Collections.Generic.Dictionary<int, int> pointList;

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
            if (qty == 0 || itemId == 0)
            {
                return 0;
            }
            else
            {
                return pointList[itemId] * qty;
            }
        }
    }
}
