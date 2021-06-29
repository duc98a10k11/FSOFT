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
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public double PricePerItem { get; set; }
        #endregion

        #region Method
        public double GetPaymentAmount()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
