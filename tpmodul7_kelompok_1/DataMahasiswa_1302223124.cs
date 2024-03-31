using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

    public static class DataMahasiswa_1302223124
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\fadillah\\OneDrive - Telkom University\\Dokumen\\My File\\RPL\\SEMESTER 4\\Kontruksi Perangkat Lunak\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_1_1302223124.json");
            MahasiswaData mahasiswa = JsonSerializer.Deserialize<MahasiswaData>(jsonString);
            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari Fakultas " + mahasiswa.fakultas);
        }

    }

}
