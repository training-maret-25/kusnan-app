/*
    👀 Code Review - Kasus 5: Pemakaian var yang Berlebihan

    📌 Masalah:
    - var digunakan tanpa kejelasan tipe data, membuat kode kurang terbaca.

    var numbers = new List<int> { 10, 20, 30, 40, 50 };
    var result = numbers.Select(x => x * 2).Where(x => x > 50);
    foreach (var item in result)
    {
        Console.WriteLine(item);
    }

    🎯 Tantangan:
    - Kapan sebaiknya kita menggunakan var dan kapan harus eksplisit dengan tipe data?
    - Perbaiki kode ini agar lebih jelas tanpa kehilangan fleksibilitas.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class CollectReview5 {
    static void Main() {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        IEnumerable<int> result = numbers.Select(x => x * 2).Where(x => x > 50);
        
        foreach (int item in result) {
            Console.WriteLine(item);
        }
    }
}