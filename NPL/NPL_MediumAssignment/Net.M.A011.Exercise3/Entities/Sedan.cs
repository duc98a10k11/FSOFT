using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3.Entities
{
    /// <summary>
    /// Sedan informatin
    /// </summary>
    /// CreatedBy: DucLM28 (01/07/2021)
    public class Sedan : Ford
    {
        public int Length { get; set; }

        public Sedan(decimal Speed, double RegularPrice, string Color, int Year, int ManfacturerDiscount = 0, int Length = 0)
            : base(Speed, RegularPrice, Color, Year, ManfacturerDiscount)
        {

            this.Length = Length;
            //ManufacturerDiscount = Convert.ToInt32(GetSalePrice());
        }
        public override double GetSalePrice()
        {
            if (this.Length > 20)
            {
                return this.RegularPrice - this.RegularPrice * 0.05;
            }
            return this.RegularPrice - this.RegularPrice * 0.1;
        }
    }
}
