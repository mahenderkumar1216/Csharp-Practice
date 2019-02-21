using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Circle
    {
        static float _PI;
        int _Raidus;

        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            _PI = 3.141F;
        }

        public Circle(int Raidus)
        {
            Console.WriteLine("Non- Static Constructor Called");
            this._Raidus = Raidus;
        }
        public float CalculateArea()
        {
            return Circle._PI * this._Raidus * this._Raidus;
        }
    }
    class StaticClass
    {
        static void Main()
        {
            Circle c1 = new Circle(5);
            Console.WriteLine("The Area of Circle is ={0}", c1.CalculateArea());

            Circle c2 = new Circle(6);
            Console.WriteLine("The Area of Circle is ={0}", c2.CalculateArea());
        }
    }
}
