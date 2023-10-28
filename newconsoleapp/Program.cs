using System;

namespace HelloWold
{
    internal class Rectangle
    {
        
        private int _golam ;
        private int _hoshang;
        
        public int golam{
            get{return _golam;}
            set{if(value>0) _golam = value;else throw new ArgumentOutOfRangeException("what are you doing bro");}
        }
        public int hoshang{
            get{return _hoshang;}
            set{if(value>0) _hoshang = value;else  throw new ArgumentOutOfRangeException("what are you doing bro");}
        }

        public int Area() {return hoshang * golam;}
        public int Environment() {return 2*(hoshang + golam);}
        public void PrintInfo()
        {
            // will print all properties in the console 
            
            Console.WriteLine("\n area:{0} \n Environment{1}", hoshang*golam, 2*(golam+hoshang));
            
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
         myObj.hoshang = 10;
         myObj.golam = 20;
         myObj.PrintInfo();
        
            
            // Console.WriteLine(myObj.Color);

        }
    }
}
