/*
    1️⃣ Temukan Produk dengan Harga Termurah
    Gunakan array untuk menyimpan daftar produk dan harganya:

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    Product[] products = new Product[]
    {
        new Product { Name = "Tablet", Price = 4000000 },
        new Product { Name = "Smartphone", Price = 3000000 },
        new Product { Name = "Smartwatch", Price = 1500000 },
        new Product { Name = "Laptop", Price = 10000000 }
    };

    Tantangan:
    Gunakan LINQ untuk menemukan produk dengan harga termurah.
*/

using System;
using System.Linq;

class Produk {
    public string Name { get; set; } = ""; 
    public double Price { get; set; }
}

class Program {
    static void Main() {
        Produk[] daftarProduk = new[] {
            new Produk { Name = "Tablet", Price = 4000000 },
            new Produk { Name = "Smartphone", Price = 3000000 },
            new Produk { Name = "Smartwatch", Price = 1500000 },
            new Produk { Name = "Laptop", Price = 10000000 }
        };

        Produk? termurah = daftarProduk.MinBy(b => b.Price); 
        Console.WriteLine($"Produk termurah adalah {termurah?.Name} - Rp. {termurah?.Price:N0}");
    }
}