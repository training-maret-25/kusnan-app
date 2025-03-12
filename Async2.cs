using System;
using System.Threading.Tasks;

public class Async2 {
    public static async Task<string> GetDataAsync() {
        await Task.Delay(1000);
        return "Data berhasil diambil";
    }

    public static async Task RunAsync() {
        Console.WriteLine("Mengambil data...");
        string result = await GetDataAsync();
        Console.WriteLine(result);
    }

    static async Task Main() { // Tambahkan Main agar bisa dijalankan
        await RunAsync();
    }
}