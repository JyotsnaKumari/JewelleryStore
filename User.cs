using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelleryStore.Model
{
    public class User
    {
        public int UserId { get; set; }
        public UserType userType { get; set; }
        public double GoldWeight { get; set; }
        public double GoldRate { get; set; }
        public double DiscountInPercentage { get; set; }
        public double TotalPrice { get; set; }
    }
}
