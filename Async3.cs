using System;
using System.Threading.Tasks;

public class Async3 {
    public static async Task LongRunningTask(CancellationToken cancellationToken) {
        for (int i = 0; i < 10; i++) {
            cancellationToken.ThrowIfCancellationRequested();

            await Task.Delay(1000, cancellationToken); // Simulasi kerja selama 10 detik
            Console.WriteLine($"Iterasi ke-{i + 1}");
        }
    }

    public static async Task Main() {
        using var cts = new CancellationTokenSource();
        cts.CancelAfter(3000); // Batalkan setelah 3 detik
        Console.WriteLine("Memulai task...");

        try {
            await LongRunningTask(cts.Token);
        } catch (System.Exception) {
            Console.WriteLine("Taks Dibatalkan");
        }
        
        Console.WriteLine("Task selesai.");
    }
}