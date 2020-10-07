using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviors
{
    public class Window
    {
        private double _Width;
        public string Model { get; set; }
        public double Height { get; set;}
        public double Width
        {
            get { return _Width; }
            set
            {

                if (value <+ 0.0)
                {

                    throw new Exception("You must have a positive number for your width.");
                }

                else
                {
                    _Width = value;
                }


            }


        }

        public Window()
        {

            Height = 1.25;
            Width = 1.25;

        }


        public Window(string model, double height, double width)
        {
            Model = model;
            Height = height;
            Width = width;
            // best practice is for assigning values is to go through the property

        }

        //Behaviours (aka methods)

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return (Height + Width) * 2;


        }

        public double Estimate(double areaunitprice, int areaunit)
        {
            double area = Area();
            return (area / areaunit) + areaunitprice;
        }

        public override string ToString()
        {
            return $"Model: {Model}  Height: {Height}  Width: {Width} ";
        }

    }
}
