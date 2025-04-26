using System;
using System.Collections.Generic;
namespace Hen{
    class Hen1{

        static  void Main (string[]args){
        List<int>numbers=new List<int>();
        int maximum=0;
        int sum=0;
        int number=0;
        Console.WriteLine("Hen, can you pls type 1 number?");
        while (true){
            number=int.Parse(Console.ReadLine());
        
        if (number==-1){
            break;

        }
        numbers.Add(number);
        sum+=number;
        }

        foreach(int index in numbers){
            if(index>maximum){
                maximum=index;
            }
        }
        if (numbers.Count>0){
        double average=(double)sum/numbers.Count;
        Console.WriteLine($"The average is:{average}");
        Console.WriteLine($"The max number is {maximum}");
        }
        }

    }

}