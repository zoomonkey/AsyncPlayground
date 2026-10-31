
using System;
using System.Threading.Tasks;

Console.WriteLine("Starting download...");
Task<string> downloadTask = DownloadDataAsync();

Console.WriteLine("Doing other work...");
Console.WriteLine("Calculating 10 + 20...");
Console.WriteLine($"Answer: {10 + 20 + 30}");

Console.WriteLine("Waiting for download result...");
string result = await downloadTask;

Console.WriteLine($"Download result: {result}");

static async Task<string> DownloadDataAsync()
{
    Console.WriteLine("....Download started.");

    await Task.Delay(15000);

    Console.WriteLine("....Download completed.");

    return "    Customer data received!";
}
