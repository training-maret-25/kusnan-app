using System;
using System.IO;

class Handling1 {
    static void Main() {
        string filepath = "output.txt";
        string logFile = "error.log";

        try {
            using (StreamWriter writer = new StreamWriter(filepath, true)) {
                writer.WriteLine($"{DateTime.Now}: Data penting yang harus disimpan.");
            }
            Console.WriteLine("Data berhasil disimpan.");
        } 
        catch (UnauthorizedAccessException ex) {
            string logMessage = $"[{DateTime.Now}] ERROR: {ex.Message}\nStackTrace: {ex.StackTrace}\n";
            File.AppendAllText(logFile, logMessage);
            Console.WriteLine("Terjadi error: Tidak memiliki izin untuk menulis.");
        } 
        catch (IOException ex) {
            string logMessage = $"[{DateTime.Now}] ERROR: {ex.Message}\nStackTrace: {ex.StackTrace}\n";
            File.AppendAllText(logFile, logMessage);
            Console.WriteLine($"Terjadi error I/O: {ex.Message}");
        } 
        catch (Exception ex) {
            string logMessage = $"[{DateTime.Now}] ERROR: {ex.Message}\nStackTrace: {ex.StackTrace}\n";
            File.AppendAllText(logFile, logMessage);
            Console.WriteLine($"Error tidak terduga: {ex.Message}");
        }
    }
}