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
    //   List<string> bikes = new List<string>();
    //   bikes.Add("Kawasaki");
    //   bikes.Add("Triumph");
    //   bikes.Add("BMW");
    //   bikes.Add("Moto Guzzi");
    //   bikes.Add("Harley Davidson");
    //   bikes.Add("Suzuki");
    // bikes.Insert(2,"Yamaha");
    // bikes.Remove("Yamaha");
    // bikes.RemoveAt(0);
    //     // bikes.Remove("Kawasaki");
    //     foreach(string i in bikes){
    //         Console.WriteLine("- " + i);
    //     }    
// Dictionary<string,string> profile = new Dictionary<string,string>();
// //Almost all the methods that exists with Lists are the same with Dictionaries
// profile.Add("Name", "Speros");
// profile.Add("Language", "PHP");
// profile.Add("Location", "Greece");
// // Console.WriteLine("Instructor Profile");
// // Console.WriteLine("Name - " + profile["Name"]);
// // Console.WriteLine("From - " + profile["Location"]);
// // Console.WriteLine("Favorite Language - " + profile["Language"]);
// foreach(KeyValuePair<string,string> veso in profile){
//     Console.WriteLine(veso.Key);
// }
    // Create an array to hold integer values 0 through 9
    // int[] arr = new int[10];
    // for (var i = 0; i < arr.Length;i++){
    //     arr[i]= i;
    //     Console.WriteLine(i);
    // }
    // int[] arr2 = {1,2,3,4,5,6,7,8,9};
    // foreach( var i in arr2){
    // Console.WriteLine(i);
    // }
    // // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
    // string[] arr3 = {"Tim","Martin","Nikki","Sara"};
    // foreach (var i in arr3){
    //     Console.WriteLine(i);
    // }
    // Create an array of length 10 that alternates between true and false values, starting with true
    bool[] arr4 = new bool[10];
    for (var i = 0; i < arr4.Length;i++){
        if(i % 2 == 0){
            arr4[i] = true;
        }
        else{
            arr4[i] = false;
        }
    }
    foreach (var i in arr4){
        Console.WriteLine(i);
    }










    }
  }
}
