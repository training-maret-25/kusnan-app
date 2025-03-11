/*
    👀 Code Review - Kasus 1: Penggunaan List vs Dictionary

    📌 Masalah:
    - Menggunakan List untuk menyimpan data yang seharusnya lebih optimal dengan Dictionary.
    - Pencarian data dalam List kurang efisien karena menggunakan Where() dibandingkan langsung mengambil nilai dalam Dictionary.

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    List<Employee> employees = new List<Employee>
    {
        new Employee { Id = 1, Name = "Andi" },
        new Employee { Id = 2, Name = "Budi" },
        new Employee { Id = 3, Name = "Cindy" }
    };
    // Mencari pegawai berdasarkan ID
    var emp = employees.Where(e => e.Id == 2).FirstOrDefault();
    Console.WriteLine(emp?.Name);

    🎯 Tantangan:
    - Apa kelemahan dari pendekatan ini? 
    - Bagaimana cara memperbaikinya agar lebih optimal dengan Dictionary?
*/

using System;
using System.Collections.Generic;

class CollectReview1 {
    public int Id { get; set; } 
    public required string Name { get; set; } = "";
}

// class Program {
//     static void Main() {
//         Dictionary<int, CollectReview1> employees = new Dictionary<int, CollectReview1> {
//             { 1, new CollectReview1 { Id = 1, Name = "Andi" } },
//             { 2, new CollectReview1 { Id = 2, Name = "Budi" } },
//             { 3, new CollectReview1 { Id = 3, Name = "Cindy" } }
//         };

//         if (employees.TryGetValue(2, out CollectReview1? emp)) {
//             Console.WriteLine(emp.Name);
//         } else {
//             Console.WriteLine("Pegawai tidak ditemukan.");
//         }
//     }
// }