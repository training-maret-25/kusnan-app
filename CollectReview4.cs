/*
    👀 Code Review - Kasus 4: Sorting yang Tidak Optimal

    📌 Masalah:
    - Menggunakan Sort() pada List secara manual, padahal bisa lebih rapi dengan LINQ.

    List<string> names = new List<string> { "Zara", "Andi", "Budi", "Cindy" };
    names.Sort();
    names.Reverse();
    Console.WriteLine(string.Join(", ", names));

    🎯 Tantangan:
    - Apa kekurangan pendekatan ini?
    - Bagaimana cara mengganti Sort() dan Reverse() agar lebih bersih dengan LINQ?
*/

using System;
using System.Collections.Generic;
using System.Linq;

class CollectReview4 {
    static void Main() {
        List<string> names = new List<string> { "Zara", "Andi", "Budi", "Cindy" };
        var sort = names.OrderByDescending(x => x).ToList();
        Console.WriteLine(string.Join(", ", sort));
    }
}