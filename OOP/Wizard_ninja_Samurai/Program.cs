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
    public int Heal(Human target)
    {
        int heal = 10*Intelligence;
        System.Console.WriteLine($"The {target.Name} got heal from {this.Name} with {heal}hp");
        return target.H += heal;;
    }
}
class Ninja : Human
{
    //================= Constructor ================
    public Ninja (string name) : base(name)
    {
        Dexterity = 175;
    }
    // ================== Methods ================
    public override int Attack(Human target)
    {
        Random rand = new Random();
        int chance = rand.Next(0,6);
        int dmg;
        if (chance == 0)
        {
            dmg = (Dexterity * 5) + 10;
            System.Console.WriteLine($"{this.Name} attacked {target.Name} and Ninja got 20% on the top of the dmg and the total is {dmg} and {target.Name} have {target.H} left.");
            return target.H -= dmg;
        }
        else
        {

            dmg = Dexterity * 5;
            System.Console.WriteLine($"{this.Name} attacked {target.Name} did only {dmg}dmg  and {target.Name} have {target.H} left.");
            return dmg;
        }
    }
    public int Steal(Human target)
    {
        int dmg = 5;
        this.health +=dmg;
        System.Console.WriteLine($"{this.Name} stole {dmg} hp from {target.Name} and {target.Name} has {target.H} left.");
        return target.H -= 5;
    }
}
class Samurai : Human
{
    public Samurai(string name) : base (name)
    {
        health = 200;
    }
    //==================Methods===================
    public override int Attack(Human target)
    {
        int dmg = Strength * 3;
        if ( target.H < 50)
        {
            Console.WriteLine($"{this.Name} attacked {target.Name} and the health of {target.H} was lower than 50hp so now is 0 !");
            return target.H = 0;
        }
        else
        {
            Console.WriteLine($"{this.Name} attacked {target.Name} and made only  {dmg}dmg because {target.Name} had more than 50hp!");
            return target.H -= dmg;
        }
    }
    public int Meditate()
    {
        System.Console.WriteLine($"{this.Name} Meditate and heal himself with 200hp and now the hp is {this.health}");
        return this.health = 200;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Samurai veso = new Samurai("Veso");
            Ninja stas = new Ninja("Stas");
            Wizard ferdi = new Wizard("Ferdi");
            // ferdi.Attack(veso);
            ferdi.Heal(veso);
            System.Console.WriteLine($"Name: {veso.Name},Int: {veso.Intelligence}, Str: {veso.Strength},Dex: {veso.Dexterity},Health: {veso.H}");
            System.Console.WriteLine($"Name: {stas.Name},Int: {stas.Intelligence}, Str: {stas.Strength},Dex: {stas.Dexterity},Health: {stas.H}");
            System.Console.WriteLine($"Name: {ferdi.Name},Int: {ferdi.Intelligence}, Str: {ferdi.Strength},Dex: {ferdi.Dexterity},Health: {ferdi.H}");

        }
    }
}
