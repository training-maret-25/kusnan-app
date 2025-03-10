/*
    2️⃣ Kasus: Palindrome Checker 🔄 (Medium)

    Deskripsi:
    Buat function yang menerima string dan mengembalikan true jika string tersebut adalah palindrome (dibaca sama dari depan dan belakang). Abaikan huruf besar/kecil.
    Input: IsPalindrome("Radar");
    Output: True
    📌 Hint: Gunakan ToLower() dan reverse string.
*/

using System;

class Soal2 {
    static bool IsPalindrome(string kata) {
        kata = kata.ToLower();
        char[] charArray = kata.ToCharArray();
        Array.Reverse(charArray); 
        string reversedkata = new string(charArray); 
        
        return kata == reversedkata;
    }

    // static void Main() {
    //     Console.WriteLine(IsPalindrome("Radar"));
    //     Console.WriteLine(IsPalindrome("Rudar"));
    // }
}