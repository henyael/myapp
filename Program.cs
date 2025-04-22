using System;

namespace HenTest {
public class Hen {
public async Task Hen1(){
Console.WriteLine("Hey Hen, the program is about to start");
var text= await Hen2();
Console.WriteLine("2 seconds passed");
}
public async Task<string> Hen2(){
await Task.Delay(2000);
return ("The program is finished the run");
}
}

class Program {
public static async Task Main(string[] args){
Hen hen=new Hen();
await hen.Hen1();
}
}
}