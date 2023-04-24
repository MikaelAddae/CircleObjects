using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    class Circle
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }
        public double Circumference { get; set; }
        public double Area { get; set; }
        public double Growth { get; set; }
        

        public Circle(double radius)
        {
            this.Radius = radius;
            this.Diameter = CalculateDiameter(radius);
            this.Circumference = CalculateCircumference(radius);
            this.Area = CalculateArea(radius);
            this.Growth = radius * 2;
            
        }

        public static double CalculateDiameter (double radius)
        {
            return radius * radius;
        }

        public double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }


        public double GetRadius(double radius)
        {
            return radius;
        }

    }
    
        

}
