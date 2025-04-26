using System;

namespace Hen{
public class Downloader {

public string LastDownloadedContent { get; private set; }

    public async Task<string> DownloadAsync(string url) {
        // Simulate downloading
        await Task.Delay(1000);
        LastDownloadedContent=$"Content from {url}";
        return LastDownloadedContent;
    }
} 

public class Program{

static public async Task Main (string[] args){

Console.WriteLine("Hey User, can you please type URL?");
string url=Console.ReadLine();
Downloader downloader=new Downloader();
await downloader.DownloadAsync(url);
Hen bla bla

}
}
}