using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;

namespace tpmodul7_kelompok_1
{
    class MahasiswaData
    {
        public NamaData nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
    }

    class NamaData
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public static class DataMahasiswa
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\KPL\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_1_1302220022.json");
            MahasiswaData mahasiswa = JsonSerializer.Deserialize<MahasiswaData>(jsonString);

            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari Fakultas " + mahasiswa.fakultas);
        }
    }
}