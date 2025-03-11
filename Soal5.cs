/*
    5️⃣ Kasus: Format Rupiah 💰 (Hard)

    Deskripsi:
    Buat function yang menerima angka integer dan mengembalikan format mata uang Rupiah 
    (dengan pemisah ribuan dan prefix "Rp").
    Input: FormatRupiah(1500000);
    Output: "Rp1.500.000"
    📌 Hint: Gunakan String.Format() atau ToString("N0").
*/

using System;

class Soal5 {
    static void Main() {
        int uang = 15000000;
        Console.WriteLine(FormatRupiah(uang));
    }

    static string FormatRupiah(int uang) {
        return $"Hasil Format {uang} menjadi Rp. {uang:N0}";
    }
}