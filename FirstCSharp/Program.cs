using System;
using System.Collections.Generic;


namespace FirstCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      //     int start = 1;
      //     int end = 255;
      //    for (int i = start; i <= end;i++){
      //        Console.WriteLine(i);
      //    } 
      // int start = 1;
      // int end = 100;
      // for (int i = start; i < end;i++){
      //     if (i % 3 == 0 && i % 5 ==0){
      //         Console.WriteLine("FizzBuzz");
      //     }
      //     else if (i% 5 == 0){
      //         Console.WriteLine("Buzz");
      //     }
      //     else if (i%3 ==0){
      //         Console.WriteLine("FIzz");
      //     }
      //     else{
      //         Console.WriteLine(i);
      //     }
      // }
      // while loop
      // while (start < end){
      //     if (start % 3 ==0 && start % 5==0){
      //         Console.WriteLine("FizzBuzz");
      //     }
      //     else if ( start % 5 ==0){
      //         Console.WriteLine("Buzz");
      //     }
      //     else if (start % 3==0){
      //         Console.WriteLine("Fizz");
      //     }
      //     else{
      //         Console.WriteLine(start);
      //     }
      //     start++;
      // }
      // int[] numArray = new int[5];
      // for (int i = 0; i < numArray.Length();i++){
      // Console.WriteLine(numArray[i]);
      // }
      // string[] myCars = new string[] {"pap","yyo","qweqw"};
      // foreach (string i in myCars){
      //     Console.WriteLine($"i won a {i}");
      // }
      //Initializing an empty list of Motorcycle Manufacturers
      List<string> bikes = new List<string>();
      //Use the Add function in a similar fashion to push
      bikes.Add("Kawasaki");
      bikes.Add("Triumph");
      bikes.Add("BMW");
      bikes.Add("Moto Guzzi");
      bikes.Add("Harley Davidson");
      bikes.Add("Suzuki");
      //Accessing a generic list value is the same as you would an array
      Console.WriteLine(bikes[2]); //Prints "BMW"
      Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

    }
  }
}
