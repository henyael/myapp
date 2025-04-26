using System;
using System.Collections.Generic;

namespace Exam {

class Hen{

static void Main(string[]args){
List<int>numbers=new List<int>();
int Min=int.MaxValue;
int Oddnum=0;
int Evennum=0;
int Sum=0;
Console.WriteLine("Hey User, pls enter a number");
while(true){
int number=int.Parse(Console.ReadLine());
    if(number==-1)
    {
        break;
    }
    Console.WriteLine(number);
    numbers.Add(number);
    Sum+=number;
    if (number % 2 == 0){
     Evennum++;   
    }
    else{
     Oddnum++;   
    }
       if (number < Min)
                {
                    Min = number;
                }
}
            Console.WriteLine($"\nNumber of even numbers: {Evennum}");
                Console.WriteLine($"Number of odd numbers: {Oddnum}");
                Console.WriteLine($"The smallest number is: {Min}");

}
}
}