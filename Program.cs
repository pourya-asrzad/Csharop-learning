
using System;
namespace HelloWold
{
    class Rectangle
    {
        
        private int width ;
        private int height;


        public int Width{
            get{return width;}
            set{if(value>0) width = value;else throw new ArgumentOutOfRangeException("what are you doing bro");}
        }
        public int Height{
            get{return height;}
            set{if(value>0) height = value;else  throw new ArgumentOutOfRangeException("what are you doing bro");}
        }

        public int Area() {return Height * Width;}
        public int Environment() {return 2*(Height + Width);}
        public void printInfo()
        {
            // will print all properties in the console 
            
            Console.WriteLine("\n area:{0} \n Environment{1}", Height*Width, 2*(Width+Height));
            
        }
        // public void speedUp()
        // {
            
        // }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
         Rectangle myObj = new Rectangle();
         myObj.Height = 10;
         myObj.Width =20;
         myObj.printInfo();
            
            // Console.WriteLine(myObj.Color);

        }
    }
}
