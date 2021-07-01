
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3.Entities
{
    /// <summary>
    /// Ford information
    /// </summary>
    public class Ford : Car
    {
        public int Year { get; set; }
        public int ManufacturerDiscount { get; set; }

        public Ford(decimal Speed, double RegularPrice, string Color, int Year, int ManufacturerDiscount)
            : base(Speed, RegularPrice, Color)
        {
            this.Year = Year;
            this.ManufacturerDiscount = ManufacturerDiscount;
        }
        public override double GetSalePrice()
        {
            return this.RegularPrice - this.RegularPrice * this.ManufacturerDiscount / 100;
        }
    }
}
