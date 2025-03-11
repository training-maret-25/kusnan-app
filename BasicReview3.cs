/*
    6️⃣ Boolean yang Tidak Perlu dalam If Statement

    bool isValid = CheckSomething();
    if (isValid == true) {
        Console.WriteLine("Valid!");
    }
    🛠️ Masalah:
    - if (isValid == true) seharusnya cukup if (isValid).
*/

using System;

// class BasicReview3 {
//     static void Main() {
//         bool isValid = CheckSomething();

//         if (isValid) {
//             Console.WriteLine("Valid!");
//         } else {
//             Console.WriteLine("Tidak Valid!");
//         }
//     }

//     static bool CheckSomething() {
//         return DateTime.Now.Day % 2 == 0; 
//     }
// }