using System;
using System.Collections.Generic;
using System.Text;

namespace _10._02._2023
{
    internal class Medicine
    {
        public string Category;
        string _name;
        double _price;
        double _discountPrice;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length > 3 && char.IsUpper(value[0]))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Ad min 3 herf ve ilk herfi boyuk olmalidi!");
                }
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value >= 0)
                {
                    _price= value;
                }
            }
        }

        public double DiscountPrice
        {
            get
            {
                return _discountPrice;  
            }

            set
            {
                if (value >= 0)
                {
                    value = Price * (value / 100);
                    _discountPrice= value;
                }
            }
        }
    }
}
