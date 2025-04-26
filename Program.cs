using System;
namespace Hen{

public class Logger{

public int LogCount {get;private set;}=0;

public async Task<int> LogAsync(string message){
    await Task.Delay(500);
    Console.WriteLine($"The message is:{message}");
    LogCount++;
    return LogCount;
}
}

public class Program{
static public async Task Main(string[] args){
    Console.WriteLine("Hey, can you please enter a message");
    string text=Console.ReadLine();
    Logger logger=new Logger();
    await logger.LogAsync(text);
    Console.WriteLine($"The Counter is:{logger.LogCount}");
    await logger.LogAsync(text);
    Console.WriteLine($"The Counter is:{logger.LogCount}");
} 
}
}