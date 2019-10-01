using System;
using System.Collections.Generic;
namespace Puzzles
{
    class Program
    {   
        
        public static int[] RandomArray(){
            Random rand = new Random();
            int[]  arr = new int[10];
            int max = arr[0];
            int min = 26;
            for (var i =0 ; i < arr.Length;i++){
                arr[i] = rand.Next(5,25);
                if(arr[i] > max){
                    max = arr[i];
                }
                if(arr[i] < min){
                    min = arr[i];
                }
            }
            Console.WriteLine($"Max is :{max}");
            Console.WriteLine($"Min is :{min}");
            return arr;
        }
        public static string TossCoin(){
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int num = rand.Next(0,2);
            if (num == 0){
                Console.WriteLine("Heads");
                return "Heads";
            }
            else{
                Console.WriteLine("Tails");
                return "Tails";
            }
        }
        public static double TossMultipleCoins(int num){
            int headCount = 0;
            int tailCount = 0;
            for (var i = 1 ; i <= num; i++){
                string yo = TossCoin();
                if (yo == "Heads"){
                    headCount++;
                }
                else{
                    tailCount++;
                }
            }
                double papi = (double)headCount/(double)num;
                Console.WriteLine($"The ratio of the head toss to total toss is {papi}");
                return papi;
        }
        

        public static List<string> Names(){
            List<string> names = new List<string>();
            names.Add("stasqqqqqq");
            names.Add("stasichqqqq");
            names.Add("staz");
            names.Add("ferdinandqqqq");
            names.Add("lia");
            names.Sort();
            for (var i = 0 ; i < names.Count;i++){
                if (names[i].Length < 5){
                    names.RemoveAt(i);
                }

            }
            return names;
        }

        
        static void Main(string[] args)
        {

            foreach(var i in Names()){
                Console.WriteLine(i);
            };








            // foreach(var i in RandomArray()){
            //     Console.WriteLine(i);
            // };
        }
    }
}
