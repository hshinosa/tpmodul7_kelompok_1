using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_1
{
    class CoursesData
    {
        public List<CourseData> courses { get; set; }
    }

    class CourseData
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    class KuliahMahasiswa
    {
        public static void ReadJSON()
        {
            Console.WriteLine("\nDaftar Mata Kuliah:");

            // Kode untuk membaca data mata kuliah dari tp7_2_1302220079.json
            string jsonCourse = File.ReadAllText("C:\\Users\\fadillah\\OneDrive - Telkom University\\Dokumen\\My File\\RPL\\SEMESTER 4\\Kontruksi Perangkat Lunak\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_2_1302223124.json");
            CoursesData courses = JsonSerializer.Deserialize<CoursesData>(jsonCourse);

            foreach (CourseData course in courses.courses)
            {
                Console.WriteLine($"MK 1 {course.code} - {course.name}");
            }
        }
    }

}
