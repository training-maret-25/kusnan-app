/*
    👀 Code Review - Kasus 3: Iterasi Manual vs LINQ

    📌 Masalah:
    - Menggunakan loop manual untuk menjumlahkan nilai dalam koleksi, padahal bisa lebih bersih dengan LINQ.

    List<int> sales = new List<int> { 100, 200, 150, 300, 250 };
    int totalSales = 0;
    foreach (var sale in sales)
    {
        totalSales += sale;
    }
    Console.WriteLine($"Total Penjualan: {totalSales}");

    🎯 Tantangan:
    - Bagaimana cara mengganti loop manual ini dengan LINQ?
    - Apa kelebihan LINQ dibandingkan loop manual dalam kasus ini?
*/

using System;
using System.Collections.Generic;
using System.Linq;

class CollectReview3 {
    // static void Main() {
    //     List<int> sales = new List<int> { 100, 200, 150, 300, 250 };
    //     int totalSales = sales.Sum();
        
    //     Console.WriteLine($"Total Penjualan: {totalSales}");
    // }
}