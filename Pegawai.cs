/*
    3️⃣ Cari Pegawai dengan Masa Kerja Terlama
    Gunakan List untuk menyimpan data pegawai:

    class Employee
    {
        public string Name { get; set; }
        public int YearsOfService { get; set; }
    }
    List<Employee> employees = new List<Employee>
    {
        new Employee { Name = "Adit", YearsOfService = 5 },
        new Employee { Name = "Bella", YearsOfService = 7 },
        new Employee { Name = "Cindy", YearsOfService = 3 },
        new Employee { Name = "Dian", YearsOfService = 10 }
    };

    Tantangan:
    Gunakan LINQ untuk menemukan pegawai dengan masa kerja terlama.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Pegawai {
    public string Name { get; set; } = "";
    public int Tahun { get; set; }
}

class Program {
    static void Main() {
        List<Pegawai> pegawai = new List<Pegawai> {
            new Pegawai { Name = "Adit", Tahun = 5 },
            new Pegawai { Name = "Bella", Tahun = 7 },
            new Pegawai { Name = "Cindy", Tahun = 3 },
            new Pegawai { Name = "Dian", Tahun = 10 }
        };

        Pegawai? pgwTerlama = pegawai.MaxBy(pgw => pgw.Tahun); 

        Console.WriteLine($"Pegawai dengan masa kerja terlama: {pgwTerlama?.Name} - {pgwTerlama?.Tahun} tahun");
    }
}