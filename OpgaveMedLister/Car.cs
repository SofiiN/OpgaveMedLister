using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveMedLister
{
    class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }

        public Car (int inputID, string inputModel, string inputBrand, int inputYear, int inputPrice, string inputColor)
        {
            ID = inputID;
            Model = inputModel;
            Brand = inputBrand;
            Year = inputYear;
            Price = inputPrice;
            Color = inputColor;
        }
    }
}
