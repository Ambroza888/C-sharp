using System;

namespace Human
{

    class Human
    {
        //attributes
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        // Constructor
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

        //Properties
        public int H{
            get {
                return health;
            }
            set {
                health = value;
            }
        }
        //methods
        public int Attack(Human Target){
            Target.H = Target.H - (5 * Strength);
            Console.WriteLine($"Remaining health of the target is {Target.H}");
            return Target.H;

        }
    }



    
    class Program
    {
        static void Main(string[] args)
        {

            Human veso = new Human("veso");
            Human stas = new Human("Stas");
            veso.Attack(stas);
            Console.WriteLine(stas.H);








            
        }
    }
}
