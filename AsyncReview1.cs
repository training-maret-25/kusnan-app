using System;
using System.Threading.Tasks;

public class DataFetcher
{
    public async Task<string> FetchDataAsync()
    {
        await Task.Delay(2000);
        return "Data berhasil diambil";
    }
}

public class AsyncReview1
{
    public static async Task Main()
    {
        var fetcher = new DataFetcher();
        Console.WriteLine("Mengambil data...");
        string result = await fetcher.FetchDataAsync();
        Console.WriteLine(result);
    }
}