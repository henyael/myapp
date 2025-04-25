using System;
using System.Threading.Tasks;

namespace Hen{
public class Downloader {
    public string LastDownloadedContent { get; private set; }
    public Downloader(string lastDownloadedContent){
    LastDownloadedContent=lastDownloadedContent;
}
    public async Task<string> DownloadAsync(string url) {
        await Task.Delay(1000);
        string content= $"Content from {url}";
        LastDownloadedContent=content;
        return content;
    }
}
class Program {
        static public async Task Main(String[] args){
        Downloader downloader=new Downloader("");
        Console.WriteLine("Hen, please enter a URL");
        string text=Console.ReadLine();
        string LastDownloadedContent=await downloader.DownloadAsync(text);
        Console.WriteLine(downloader.LastDownloadedContent);

    } 
}
}