using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWold
{

    class Car
    {
        public string Name;
        public string Brand;
        public float Price;
        public int Wheels;
        public string Color;
        public int Speed;
        public bool IsStandard;
        public void printAtr()    // method
        {
            Console.WriteLine("\n Name:{0} , Brand :{1} , color : {2} , price : {3} , Wheels : {4} , Speed : {5} , IsStandard : {6}", Name, Brand, Color, Price, Wheels, Speed, IsStandard);
        }
        public void speedUp()    // method
        {
            Speed++;

        }

        public void breakUp()    // method
        {
            Speed -= 10;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.Brand = "saipa";
            myObj.Name = "pride";
            myObj.Price = 800000;
            myObj.Wheels = 4;
            myObj.Color = "blue";
            myObj.Speed = 180;
            myObj.IsStandard = false;
            myObj.printAtr();
            myObj.speedUp();
            myObj.speedUp();
            myObj.speedUp();
            myObj.speedUp();
            myObj.breakUp();
            Console.WriteLine(myObj.Speed);
            Console.WriteLine(myObj.Color);

        }
    }
}
