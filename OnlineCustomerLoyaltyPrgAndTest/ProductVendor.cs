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
        
        /// <summary>
        /// This constructor initilizes point to supplied number,
        /// and initializes the pointList to hold two items.
        /// Finally it initilizes customerPuchases, the list of actual pucheses, as an empty dictionary.
        /// </summary>
        /// <param name="initialPoints">the initial saldo of point to give out.</param>
        public ProductVendor(int initialPoints)
        {
            this.PointSaldo = initialPoints;

            pointList = new Dictionary<int, int>();
            pointList[1] = 3;
            pointList[2] = 7;

            customerPurchases = new Dictionary<string, int>();
        }

        public int PointSaldo { get; set;}

        /// <summary>
        /// When a customer make a purchase he or she is entitled to loyalty points.
        /// The ProductVendor calculates how much, and returns the points as an int
        /// </summary>
        /// <param name="customer">An instance of a Customer object</param>
        /// <param name="itemId">the id of the item purchased</param>
        /// <param name="qty">The quantaty of purchased og this item</param>
        /// <returns></returns>
        public int requirePoints(Customer customer, int itemId, int qty)
        {
           
            /// check if inputs are valid, noteably if item exists in list
            if (qty <= 0 || itemId == 0 || !pointList.ContainsKey(itemId))
            {
                return 0;
            }
            else 
            {
                int boostReward = 0;
                /// has the customer purchased this item before?
                if(!customerPurchases.ContainsKey(customer.Id.ToString() + itemId.ToString()))
                {
                    boostReward = (int)Math.Ceiling(pointList[itemId] / 2.0) ;

                    customerPurchases[customer.Id.ToString() + itemId.ToString()] = qty;
                }

                PointSaldo += (pointList[itemId] + boostReward) * qty;
                return (pointList[itemId] + boostReward) * qty;
               
            }
        }
    }
}
