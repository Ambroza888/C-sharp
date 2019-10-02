﻿using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Food
        {   
            //====== Attributes=======
            public string Name;
            public int Calories;
            public bool isSpicy;
            public bool isSweet;
            // ======== Constructor ======
            public Food(string nam, int cal, bool spice,bool sweet)
            {   
                this.Name = nam;
                this.Calories = cal;
                this.isSpicy = spice;
                this.isSweet = sweet;
            }
        }
        
        class Buffet
        {
            //======= Attributes======
            public List<Food> Menu;
            //====== Constructor======
            public Buffet()
            {
                Menu = new List<Food>(){
                    new Food("Apple",12,false,true),
                    new Food("Banana",10,false,true),
                    new Food("Pizza",1000,true,false),
                    new Food("Salat",80,false,false),
                    new Food("Rice",600,false,false),
                    new Food("Chicken",450,false,false),
                    new Food("Turkey",300,false,false)
                };
            }
            // ===== Methods=======
            public Food Serve()
            {
                return this.Menu[new Random().Next(0,Menu.Count)];
            }
        }
        class Ninja
        {
            //====== Attributes ======
            private int colorieIntake;
            public List<Food> FoodHistory;
            // ===== Constructor=====
            public Ninja()
            {
                this.colorieIntake = 0;
                this.FoodHistory = new List<Food>();
            }
            //======== Properties========
            //1
            public bool isFull
            {
                get{return this.colorieIntake > 1200 ? true:false;}
            }
            //2
            public void Eat(Food item)
            {
                // Buffet b = new Buffet();
                // Food f = b.Serve();
                this.colorieIntake += new Buffet().Serve().Calories;
                this.FoodHistory.Add(new Buffet().Serve());
                
            }



        }
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
