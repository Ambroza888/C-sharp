using System;

namespace Human
{

    class Human
    {
        //attributes all are PRIVATE for that i am using Properties to access them;
        string Name;
        int Strength;
        int Intelligence;
        int Dexterity;
        int health;
        // Constructor===========================================
        public Human(string nam){
            Name = nam;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string nam,int str, int intel,int dex, int hp){
            Name = nam;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        //Properties===================================
        public int H{
            get {
                return health;
            }
            set {
                health = value;
            }
        }
        public int Str{
            get {
                return Strength;
            }
            set {
                Strength = value;
            }
        }
        public int intProp{
            get { return Intelligence; }
            set { Intelligence = value; }
        }

        //methods =============================================
        public int Attack(Human Target){
            Target.H = Target.H - (5 * Strength);
            Console.WriteLine($"Remaining health of the target is {Target.H}");
            return Target.H;
        }
        public int StealStr(Human target){
            target.Str = target.Str - 14;
            Console.WriteLine($"The  {target.Name} got stolen 14str from {this.Name}");
            return target.Str;
        }
        public int Healing(Human target){
            return target.H= target.H + (8*Intelligence);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human veso = new Human("veso", 50,50,50,100);
            Human stas = new Human("Stas",50,50,50,100);
            veso.Healing(stas);
            Console.WriteLine(stas.H);
            








            
        }
    }
}
