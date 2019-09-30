using System;
using System.Collections.Generic;


namespace FirstCSharp
{
  class Program
  {
      public static void PrintNumbers(){
          for (var i =1 ; i<= 255; i++){
              Console.WriteLine(i);
          }
      }

      public static void PrintOdds(){
          for (var i = 1 ; i <= 255;i++){
              if (i%2 == 1){
                  Console.WriteLine(i);
              }
          }
      }
      public static void PrintSum(){
          int sum = 0;
          for (var i =0 ; i<=255; i++){
              sum = sum + i;
              Console.WriteLine($"New number is {i} Sum: {sum}");
          }
      }
      public static void LoopArray(int[] numbers){
          for (var i =0; i < numbers.Length;i++){
              Console.WriteLine(i);
          }
      }
      public static int FindMax(int[] numbers){
          int max = numbers[0];
          for (var i = 1; i< numbers.Length;i++){
              if (numbers[i] > max){
                  max = numbers[i];
              }
          }
          return max;
      }
      public static int Sigma(int number){
          int sum = 0;
          for (var i =0 ; i <= number;i++){
              sum = sum + i;
              Console.WriteLine(sum);
          }
          return sum;
      }
      public static void GetAverage(int[] arr){
          int sum = 0;
          for (var i =0 ; i < arr.Length;i++){
              sum = sum + arr[i];
          }
          Console.WriteLine(sum / arr.Length);
      }
    public static int[] OddArray(){
        int[] arr = new int[256/2];
        int j =0;
        for (var i =1 ; i <=255; i++){
            if ( i%2 == 1){
            arr[j] = i;
            j++;
            }
            else{
                Console.WriteLine("you didn't get in the if statement");
            }
        }
        return arr;
    }
    public static int GreaterThanY(int[] arr, int y){
        int count = 0;
        for (var i =0 ; i < arr.Length;i++){
            if(arr[i] > y){
                count++;
            }
        }
        return count;
    }
    public static int[] SquareArrayValues(int[] arr){
        for (var i = 0; i < arr.Length;i++){
            arr[i] = arr[i] * arr[i];
        }
        return arr;
    }

    public static int[] EliminateNegatives(int[] arr){
        for (var i =0 ; i < arr.Length;i++){
            if (arr[i] < 0){
                arr[i] = 0;
            }
        }
        return arr;
    }
    public static void MinMaxAverage(int[] arr){
        int max = arr[0];
        int min = arr[0];
        int sum = 0;
        for (var i = 1; i < arr.Length;i++){
            sum = sum + arr[i];
            if (arr[i] > max){
                max = arr[i];
            }
            else if (arr[i] < min){
                min = arr[i];
            }
        }
        int avg = sum/arr.Length;
        Console.WriteLine($"The max Value is {max}");
        Console.WriteLine($"The min Value is {min}");
        Console.WriteLine($"The avg Value is {avg}");
    }




    static void Main(string[] args)
    {       
            //====================== Basic 13 =====================================
            int[] arr = {1,2,-3,-4};
            MinMaxAverage(arr);
            //  foreach(var i in EliminateNegatives(arr)){
            //      Console.WriteLine(i);
            //  }
            // foreach(var i in SquareArrayValues(arr)){
            // Console.WriteLine(i);
            // }

            // Console.WriteLine(GreaterThanY(arr,3));
            // Console.WriteLine(OddArray());
            // GetAverage(arr);
            // Sigma(5);
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // Console.WriteLine(FindMax(arr));

            // int[] yo = OddArray();
            // foreach( var i in yo){
            //     Console.WriteLine(i);
            // }








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
    // foreach (var i in arr3){
    //     Console.WriteLine(i);
    // }
    // Create an array of length 10 that alternates between true and false values, starting with true
    // bool[] arr4 = new bool[10];
    // for (var i = 0; i < arr4.Length;i++){
    //     if(i % 2 == 0){
    //         arr4[i] = true;
    //     }
    //     else{
    //         arr4[i] = false;
    //     }
    // }
    // foreach (var i in arr4){
    //     Console.WriteLine(i);
    // }
    // List<string> iceCream = new List<string>();
    // iceCream.Add("chocholate");
    // iceCream.Add("vanilla");
    // iceCream.Add("banana");
    // iceCream.Add("caramel");
    // iceCream.Add("blackMamba");
    // iceCream.RemoveAt(2);
    // // Console.WriteLine($"the length of this list is : {iceCream.Count}");
    // Random rand = new Random();
    // int num;
    // string[] arr3 = {"Tim","Martin","Nikki","Sara"};
    // Dictionary <string,string> User = new Dictionary<string, string>();
    // num = rand.Next(0 , iceCream.Count);
    // User.Add(arr3[0], iceCream[num]);
    // num = rand.Next(0 , iceCream.Count);
    // User.Add(arr3[1], iceCream[num]);
    // num = rand.Next(0 , iceCream.Count);
    // User.Add(arr3[2], iceCream[num]);
    // num = rand.Next(0 , iceCream.Count);
    
    // User.Add(arr3[3], iceCream[num]);
    // foreach ( var i in User){
    //     Console.WriteLine(i);
    // }
    // double val = 5.8;
    // int dval = (int)val;
    // Console.WriteLine(dval);

    //=============================== Boxing and Unboxig==================

    // List<object> stuff = new List<object>();
    // stuff.Add(7);
    // stuff.Add(28);
    // stuff.Add(-1);
    // stuff.Add(true);
    // stuff.Add("chair");
    // foreach (var i in stuff){
    //     Console.WriteLine(i);
    // }
    // int sum = 0;
    // foreach (var i in stuff){
    //     if (i is int){
    //         sum = sum + (int)i;
    //     }
    // }
    // Console.WriteLine(sum);











    }
  }
}
