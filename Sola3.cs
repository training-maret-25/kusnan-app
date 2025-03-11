/*
    3️⃣ Kasus: Hitung Karakter Unik 🔢 (Medium-Hard)

    Deskripsi:
    Buat function yang menerima string dan mengembalikan jumlah karakter unik dalam string tersebut.
    Input: CountUniqueChars("hello");
    Output: 4 // ('h', 'e', 'l', 'o') -> 'l' dihitung satu kali
    📌 Hint: Gunakan HashSet<char>.
*/

using System;
using System.Linq;

class Soal3 {
    static void Main() {
        Console.WriteLine(CharUnik("helo")); 
    }

    // pake HashSet
    static int CharUnik(string input) {
        return new HashSet<char>(input).Count;
    }

    // pake Distinct
    // static int CharUnik(string input) {
    //     return input.Distinct().Count();
    // }
}