/*
    5️⃣ Filter Nama Pelanggan Berdasarkan Panjang Nama
    Gunakan Dictionary untuk menyimpan daftar pelanggan dan panjang namanya:

    Dictionary<string, int> customerNames = new Dictionary<string, int>
    {
        { "Amanda", 6 },
        { "Budi", 4 },
        { "Catherine", 9 },
        { "Daniel", 6 },
        { "Erika", 5 }
    };

    Tantangan:
    Gunakan LINQ untuk menemukan pelanggan dengan panjang nama lebih dari 5 huruf.
*/

using System;
using System.Collections.Generic;
using System.Linq;

// class Collection5 {
//     static void Main() {
//         int n = 5;

//         Dictionary<string, int> pelanggan = new Dictionary<string, int> {
//             { "Amanda", 6 },
//             { "Budi", 4 },
//             { "Catherine", 9 },
//             { "Daniel", 6 },
//             { "Erika", 5 }
//         };

//         var hasil = pelanggan
//             .Where(c => c.Value > n)
//             .Select(c => c.Key); 

//         Console.WriteLine($"Pelanggan dengan nama lebih dari {n} huruf: " + string.Join(", ", hasil));
//     }
// }