using Net.M.A010.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A010.Entities
{
    public class Invoice : IPayable
    {
        #region Property
        public string partNumber { get; set; }
        public string partDescription { get; set; }
        public int quantity { get; set; }
        public double pricePerItem { get; set; }
        #endregion

        #region Method
        public double getPaymentAmount()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
