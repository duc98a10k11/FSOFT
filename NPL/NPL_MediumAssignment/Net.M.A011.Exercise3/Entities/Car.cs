using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3.Entities
{
    /// <summary>
    /// Car information
    /// </summary>
    /// CreatedBy: DucLM28 (01/07/2021)
    public abstract class Car
    {
        public decimal Speed { get; set; }
        public double RegularPrice { get; set; }
        public string Color { get; set; }

        public Car(decimal Speed, double RegularPrice, string Color)
        {
            this.Speed = Speed;
            this.RegularPrice = RegularPrice;
            this.Color = Color;
        }
        public abstract double GetSalePrice();
        
        public string ToString()
        {
            return $"Speeed:{this.Speed}, RegularPrice:{this.RegularPrice}, Color:{this.Color}, SalePrice:{GetSalePrice()}";
        }
    }
}
