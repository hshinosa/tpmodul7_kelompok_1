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
            string jsonCourses = File.ReadAllText("D:\\KPL\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_2_1302220079.json");
            CoursesData courses = JsonSerializer.Deserialize<CoursesData>(jsonCourses);

            foreach (CourseData course in courses.courses)
            {
                Console.WriteLine($"Kode: {course.code}, Nama: {course.name}");
            }
        }
    }
}
