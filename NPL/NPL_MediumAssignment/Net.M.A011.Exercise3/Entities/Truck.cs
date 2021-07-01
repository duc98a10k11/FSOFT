using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3.Entities
{
    /// <summary>
    /// Truck information
    /// </summary>
    /// CreatedBy: DucLM28 (01/07/2021)
    public class Truck : Car
    {
        public int Weight { get; set; }

        public Truck(decimal Speed, double RegularPrice, string Color, int Weight)
            : base(Speed, RegularPrice, Color)
        {
            this.Weight = Weight;
        }
        public override double GetSalePrice()
        {
            if (this.Weight > 2000)
            {
                return this.RegularPrice - this.RegularPrice * 0.1;
            }
            return this.RegularPrice - this.RegularPrice * 0.2;
        }
    }
}
