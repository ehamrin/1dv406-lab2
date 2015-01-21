using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kvitto.Model
{
    public class Receipt
    {
        private double _subtotal;

        public double Subtotal{
            get {
                return _subtotal;
            }
            set {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Double must be greater than 0");
                }
                _subtotal = value;
            }
        }
        public double Total { get; set; }
        public double Discount { get; set; }
        public double Rate { get; set; }

        public Receipt(double subtotal)
        {
            Subtotal = subtotal;
            Calculate(Subtotal);
        }

        private void Calculate(double subtotal) {
            if (subtotal >= 0 && subtotal < 500)
            {
                Rate = 0;
            }
            else if (subtotal >= 500 && subtotal < 1000)
            {
                Rate = 0.05;
            }
            else if (subtotal >= 1000 && subtotal < 5000)
            {
                Rate = 0.10;
            }
            else if (subtotal >= 5000)
            {
                Rate = 0.15;
            }
            else {
                throw new Exception("Kunde inte bestämma en rabattsats");
            }

            Discount = subtotal * Rate;
            Total = Subtotal - Discount;
        }

    }
}