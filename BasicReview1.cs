/*
    4️⃣ Hardcoded String Tanpa Konstanta

    public static void GreetUser(string name) {
        Console.WriteLine("Hello, " + name + "! Welcome to our system.");
    }
    🛠️ Masalah:
    - String harus menggunakan interpolasi ($"{name}").
    - "Hello, ..." bisa dijadikan konstanta.
*/

using System;

class BasicReview1 {
    public static void GreetUser(String name) {
        Console.WriteLine($"Hello, {name}! Welcome to our system.");
    }

    static void Main() {
        GreetUser("Udin");
    }
}