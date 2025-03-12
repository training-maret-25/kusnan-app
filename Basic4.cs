/*
    4️⃣ Kasus: Angka Terbesar Kedua 🔎 (Hard)

    Deskripsi:
    Buat function yang menerima array/list integer dan mengembalikan angka terbesar kedua dalam array tersebut.
    Input: SecondLargestNumber(new int[] { 3, 7, 2, 9, 5 });
    Output: 7
    📌 Hint: Gunakan sorting atau loop untuk mencari angka terbesar kedua.
*/

using System;

class Basic4 {
    static void Main() {
        int[] angka =  { 3, 7, 2, 9, 5 };
        Console.WriteLine(SecondLargest(angka));
    }

    static int SecondLargest(int [] arr) {
        int pertama = int.MinValue, kedua = int.MinValue;

        foreach (int num in arr) {
            if (num > pertama) {
                kedua = pertama;
                pertama = num;
            } else if (num > kedua && num != pertama) {
                kedua = num;
            }
        } return kedua;
    }
} 