// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*
    1️⃣ Kasus: Deret Fibonacci 📈 (Easy-Medium)

    Deskripsi:
    Buat function yang menerima integer N dan mengembalikan deret Fibonacci sebanyak N elemen dalam bentuk array/list.
    Input: GenerateFibonacci(6);
    Output: [0, 1, 1, 2, 3, 5]
    📌 Hint: Gunakan loop untuk menghitung elemen berikutnya.
*/

using System;
using System.Collections.Generic;

class Soal1 {
    static void Main() {
        int n = 6;
        CetakFibonacci(n);
    }

    static void CetakFibonacci(int n) {
        int angka1 = 0, angka2 = 1;

        for (int i = 0; i < n; i++) {
            if (i == n - 1) {
                Console.Write(angka1);
            } else {
                Console.Write(angka1 + ", "); 
            }
            
            int next = angka1 + angka2;
            angka1 = angka2;
            angka2 = next;
        }
    }
}