using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_oquendo
{
    class Customer : PersonV2
    {
        private DateTime customerSince;
        private Double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;


        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }

            set
            {
                customerSince = value;
            }
        }

        public Double TotalPurchases
        {
            get
            {
                return totalPurchases;
            }

            set
            {
                totalPurchases = value;
            }
        }

        public bool DiscountMember
        {
            get
            {
                return discountMember;
            }

            set
            {
                discountMember = value;
            }
        }

        public int RewardsEarned
        {
            get
            {
                return rewardsEarned;
            }

            set
            {
                rewardsEarned = value;
            }
        }

        public Customer() : base()
        {
            CustomerSince = DateTime.Now;
            TotalPurchases = 0;
            DiscountMember = false;
            RewardsEarned = 0;

        }

    }
}
