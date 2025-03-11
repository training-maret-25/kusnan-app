using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

/* L I S T */
// class LatihanMandiri {
//     static void Main() {
//         List<int> l = new List<int>();

//         l.Add(10);
//         l.Add(20);
//         l.Add(30);
//         l.Add(40);
//         l.AddRange(new List<int> { 50, 60, 70 });
//         l.Reverse();
//         l.RemoveAll(l => l > 40);
//         l.RemoveAt(3);

//         Console.WriteLine("Elemen in the list: ");
//         foreach (int i in l) {
//             Console.WriteLine(i);
//         }
//     }
// }

/* D I C T I O N A R Y */
// class LatihanMandiri {
//     static void Main()
//     {
//         // Create a dictionary to store key-value pairs
//         Dictionary<string, int> d = new Dictionary<string, int>();

//         // Insert elements into the dictionary
//         d.Add("Geek1", 1);
//         d.Add("Geek2", 2);
//         d.Add("Geek3", 3);

//         // Display all key-value pairs in the dictionary
//         foreach (var i in d)
//         {
//             Console.WriteLine($"key: {i.Key}, value: {i.Value}");
//         }
//     }
// }

/* J S O N   O B J E C T*/
// class LatihanMandiri {
//     static void Main()
//     {
//         var mahasiswa = new
//         {
//             Nama = "Ap",
//             Umur = 21,
//             Hobi = new string[] { "Coding", "Gaming", "Mancing" }
//         };

//         // Convert Object ke JSON
//         string json = JsonSerializer.Serialize(mahasiswa, new JsonSerializerOptions { WriteIndented = true });

//         Console.WriteLine(json);
//     }
// }

// class LatihanMandiri {
//     static void Main() {
//         List<int> angka = new List<int>();
//         List<string> huruf = new List<string> {"adi", "uda", "ida"};

//         angka.AddRange(9, 11, 20, 71, 91);

//         int hasil = angka.Sum();

//         Console.WriteLine($"Jumlah Semua Angka {hasil}");
//         Console.WriteLine($"Isi List: " + string.Join(", ", huruf));
//     }
// }