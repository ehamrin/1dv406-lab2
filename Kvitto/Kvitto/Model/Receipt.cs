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
                    throw new ArgumentOutOfRangeException("Receipt::Subtotal - Double must be greater than 0");
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

        /// <summary>
        /// Calulates and sets properties from subtotal
        /// </summary>
        /// <param name="subtotal">Subtotal for purchase</param>
        private void Calculate(double subtotal) {
            Rate = GetRate(subtotal);
            Discount = subtotal * Rate;
            Total = Subtotal - Discount;
        }

        /// <summary>
        /// Calculates rate, returns unformatted double
        /// </summary>
        /// <param name="subtotal">Subtotal for purchase</param>
        /// <returns></returns>
        private double GetRate(double subtotal) {
            double rate;

            if (subtotal >= 0 && subtotal < 500)
            {
                rate = 0;
            }
            else if (subtotal >= 500 && subtotal < 1000)
            {
                rate = 0.05;
            }
            else if (subtotal >= 1000 && subtotal < 5000)
            {
                rate = 0.10;
            }
            else if (subtotal >= 5000)
            {
                rate = 0.15;
            }
            else
            {
                throw new Exception("Receipt::GetRate - Unknwon error occurred");
            }

            return rate;
        }

    }
}