/*
    4️⃣ Ambil 2 Transaksi Terbaru
    Gunakan array untuk daftar transaksi:

    class Transaction
    {
        public string TransactionId { get; set; }
        public DateTime Date { get; set; }
    }
    Transaction[] transactions = new Transaction[]
    {
        new Transaction { TransactionId = "TX001", Date = new DateTime(2024, 2, 15) },
        new Transaction { TransactionId = "TX002", Date = new DateTime(2024, 1, 10) },
        new Transaction { TransactionId = "TX003", Date = new DateTime(2024, 3, 20) },
        new Transaction { TransactionId = "TX004", Date = new DateTime(2024, 4, 5) }
    };

    Tantangan:
    Gunakan LINQ untuk mengambil 2 transaksi terbaru berdasarkan tanggal terbaru.
*/

using System;
using System.Linq;

class Transaksi {
    public required string trId { get; set; } = "";
    public DateTime Date { get; set; }
}

class Program {
    static void Main() {
        Transaksi[] transaksi = new Transaksi[] {
            new Transaksi { trId = "TX001", Date = new DateTime(2024, 2, 15) },
            new Transaksi { trId = "TX002", Date = new DateTime(2024, 1, 10) },
            new Transaksi { trId = "TX003", Date = new DateTime(2024, 3, 20) },
            new Transaksi { trId = "TX004", Date = new DateTime(2024, 4, 5) }
        };

        var trTerbaru = transaksi
            .OrderByDescending(t => t.Date)
            .Take(2);

        foreach (var t in trTerbaru) {
            Console.WriteLine($"ID: {t.trId}, Date: {t.Date:yyyy-MM-dd}");
        }
    }
}