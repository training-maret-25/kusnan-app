/*
    👀 Code Review - Kasus 2: LINQ yang Tidak Efisien

    📌 Masalah:
    - Terlalu banyak pemanggilan LINQ yang bisa disederhanakan.
    - Where() dan Select() seharusnya bisa digabung.

    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var evenNumbers = numbers.Where(n => n % 2 == 0).Select(n => n).ToList();
    Console.WriteLine(string.Join(", ", evenNumbers));

    🎯 Tantangan:
    - Bagaimana cara menyederhanakan kode ini tanpa kehilangan fungsionalitasnya? 
    - Mengapa kode ini kurang optimal? 
*/

using System;
using System.Collections.Generic;
using System.Linq;

class CollectReview2 {
    // static void Main() {
    //     List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //     var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
    //     Console.WriteLine(string.Join(", ", evenNumbers));
    // }
}