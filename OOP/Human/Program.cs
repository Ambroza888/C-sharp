using System;

namespace Human
{





    class Vehicle
    {
        int maxNumPassengers;
        string color;
        public Vehicle(int maxPass, string col){
            maxNumPassengers = maxPass;
            color = col;
        }
        public int MaxNumPassengers
        {
            get { return maxNumPassengers; }
        }
        public string Color
        {
            get { return color; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle veso = new Vehicle(10,"Green");
            Console.WriteLine(veso.Color);













            
        }
    }
}
