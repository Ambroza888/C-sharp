using System;

namespace Wizard_ninja_Samurai
{


    class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    protected int health;
    //===== Proporties ========
    public int H
    {
        get { return health;}
        set{ health = value;}
    }
    // ====== Constructor ============
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }
     
    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        health = hp;
    }
     
    // ============= Methods ==================
    // Build Attack method
    public virtual int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.health;
    }
}

class Wizard : Human
{
    // ======= Constructor ==================
    public Wizard(string name) : base(name)
    {
        Name = name;
        health = 50;
        Intelligence = 25;
    }
    // ================= Methods =============
        public override int Attack(Human target)
    {
        int dmg = Intelligence * 5;
        target.H -= dmg;
        this.health += dmg;

        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage! and heal himself {dmg}");
        return target.H;
    }
}
class Ninja : Human
{
    //================= Constructor ================
    public Ninja (string name) : base(name)
    {
        Dexterity = 175;
    }
    // ================== Method ================
    public override int Attack(Human target)
    {
        Random rand = new Random();
        int chance = rand.Next(0,6);
        int dmg;
        if (chance == 0)
        {
            dmg = (Dexterity * 5) + 10;
        }
        else
        {
            dmg = Dexterity * 5;
        }
        target.H -= dmg;
        this.health += dmg;

        return target.H;
    }
}
class Samurai : Human
{
    public Samurai(string name) : base (name)
    {
        health = 200;
    }
    public override int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.H -= dmg;
        if ( target.H < 50)
        {
            Console.WriteLine($"{Name} attacked {target.Name} and the health of {target.H} was lower than 50hp so now is 0 !");
            return target.H = 0;

        }
        else
        {
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.H -= dmg;
        }
    }
}







    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Samurai veso = new Samurai("Veso");
            Ninja stas = new Ninja("Stas");
            Wizard ferdi = new Wizard("Ferdi");
            ferdi.Attack(veso);
            System.Console.WriteLine($"{veso.Name}, {veso.Intelligence},{veso.Strength},{veso.Dexterity}, {veso.H}");
            System.Console.WriteLine($"{ferdi.Name}, {ferdi.Intelligence},{ferdi.Strength},{ferdi.Dexterity}, {ferdi.H}");

        }
    }
}
