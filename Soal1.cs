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

class Soal1
{
    static List<int> GenerateFibonacci(int n) {
        List<int> fibList = new List<int> { 0, 1 }; 

        for (int i = 2; i < n; i++) {
            fibList.Add(fibList[i - 1] + fibList[i - 2]);
        }

        return fibList.GetRange(0, n); 
    }

    // static void Main() {
    //     int n = 6; 
    //     Console.WriteLine(string.Join(", ", GenerateFibonacci(n))); 
    // }
}