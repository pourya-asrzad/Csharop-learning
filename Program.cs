using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public string[] additionalThings;
        public bool IsStandard;
        public void printAtr()
        {
            // will print all properties in the console 
            Console.WriteLine("\n Name:{0} , Brand :{1} , color : {2} , price : {3} , Wheels : {4} , Speed : {5} , IsStandard : {6}", Name, Brand, Color, Price, Wheels, Speed, IsStandard);
            foreach (var s in additionalThings)
            {
                Console.WriteLine(s);
            }
        }
        public void speedUp()
        {
            // increase speed one bye one after using method
            Speed++;
        }
        public void breakUp()
        {
            // decrease the speed 10 km/h after using that
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
            myObj.additionalThings = new string[5];
            myObj.additionalThings[0] = "df";
            myObj.additionalThings[1] = "seconf";
            myObj.Speed = 180;
            myObj.IsStandard = false;
            myObj.printAtr();
            myObj.speedUp();
            myObj.speedUp();
            myObj.speedUp();
            myObj.speedUp();
            myObj.breakUp();
            Console.WriteLine(myObj.Speed);
            // Console.WriteLine(myObj.Color);

        }
    }
}
